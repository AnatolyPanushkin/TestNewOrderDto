// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;
using Contracts.Models.NewAvia;
using MixVel.Models.Extra;
using Carrier = Contracts.Models.NewAvia.Carrier;
using City = Contracts.Models.NewAvia.City;
using ContactInfo = Contracts.Avia.ContactInfo;
using Passenger = Contracts.Models.NewAvia.Passenger;
using Segment = Contracts.Models.NewAvia.Segment;
using Tariff = Contracts.Models.NewAvia.Tariff;
using Tax = Contracts.Models.NewAvia.Tax;
using Ticket = Contracts.Models.NewAvia.Ticket;



    Console.WriteLine("fdfs");
    using (  StreamReader reader = new StreamReader(@"C:\Users\User\Downloads\Telegram Desktop\15_23_15_MixVel_api_Order_change_Response.xml"))
    {
        XmlSerializer serializer = new XmlSerializer(typeof(OrderViewRS.Message));
        var message = (OrderViewRS.Message) serializer.Deserialize(reader);

        var newOrderDto = message.Map();
    }

public static class OrderViewMapper
{
    /// <summary>
    /// Преобразует ответ Mixvel в обьект заказа
    /// </summary>
    /// <param name="resp"></param>
    /// <returns></returns>
    public static OrderDto Map(this OrderViewRS.Message resp)
    {
        var mixOrder = resp.Body.AppData.OrderView.Response.MixOrder;
        var ticketDocInfos = resp.Body.AppData.OrderView.Response.TicketDocInfos;
        var dataLists = resp.Body.AppData.OrderView.Response.DataLists;
        var payment = resp.Body.AppData.OrderView.Response.PaymentFunctions;
        var orderDto = new OrderDto()
        {
            WorkId = mixOrder.MixOrderID,
            CreatedAt = DateTime.Now,
            BaseCost = mixOrder.TotalAmount.Value,
            Cost = mixOrder.TotalAmount.Value,
            Provider = "MixVel",
            GDS = "Sirena",
            /*Status = (int)ParseStatus(mixOrder, ticketDocInfos),*/
            Bookings = new List<Booking>()
            {
                new Booking()
                {
                    Pnr = mixOrder.Order.BookingRefs.First().BookingID,
                    BookPrice = new BookPrice()
                    {
                        Base = mixOrder.Order.OrderItems.First().Price.BaseAmount.Value,
                        Total = mixOrder.Order.TotalPrice.TotalAmount.Value,
                        Tariff = new Tariff()
                        {
                            Code = "",
                            Name = "",
                            Baggage = ""
                        },

                        Taxes = mixOrder.Order.OrderItems.First().Price.TaxSummary.Taxes.Select(tax => new Tax
                        {
                            Code = tax.TaxCode,
                            Value = tax.Amount.Value
                        }).ToList()

                    },
                    Segments = dataLists.PaxSegmentList.Select(seg => new Segment
                    {
                        DeparturePoint = new TravelPoint()
                        {
                            Terminal = seg.Dep.TerminalName,
                            Date = seg.Dep.AircraftScheduledDateTime.Date,
                            City = new City()
                            {
                                Name = seg.Dep.StationName,
                                Code = seg.Dep.LocationCode
                            },
                        },
                        ArrivalPoint = new TravelPoint()
                        {
                            Terminal = seg.Arrival.TerminalName,
                            Date = seg.Arrival.AircraftScheduledDateTime.Date,
                            City = new City()
                            {
                                Name = seg.Arrival.StationName,
                                Code = seg.Arrival.LocationCode
                            },
                        },
                        FlightNumber = seg.MarketingCarrierInfo.MarketingCarrierFlightNumberText,
                        //отсюда???(1-2)
                        MarketingAirline = new Carrier()
                        {
                            Code = seg.MarketingCarrierInfo.CarrierDesigCode,
                        },
                        OperatingAirline = new Carrier()
                        {
                            Code = seg.DatedOperatingLeg.CarrierAircraftType.CarrierAircraftTypeCode
                        },
                        Class = mixOrder.Order.OrderItems
                            .FirstOrDefault(cl =>
                                cl.FareDetail.FareComponents.First().PaxSegmentRefID == seg.PaxSegmentID).FareDetail
                            .FareComponents.First().CabinType.CabinTypeCode,
                        SubClass = "", //откуда броать?RBD

                    }).ToList(),
                    TickPasses = ticketDocInfos.Select(tickPass => new TickPass()
                    {
                        Passenger = dataLists.PaxList.Select(pax => new Passenger
                        {
                            Birthday = DateTime.Parse((string) dataLists.PaxList
                                .FirstOrDefault(pas => pas.PaxID == tickPass.PaxRefID).Individual.Birthdate),
                            GenderCode = dataLists.PaxList.FirstOrDefault(pas => pas.PaxID == tickPass.PaxRefID)
                                .Individual.GenderCode,
                            Surname = dataLists.PaxList.FirstOrDefault(pas => pas.PaxID == tickPass.PaxRefID).Individual
                                .Surname,
                            Name = dataLists.PaxList.FirstOrDefault(pas => pas.PaxID == tickPass.PaxRefID).Individual
                                .GivenNames.FirstOrDefault(),
                            Patronymic = dataLists.PaxList.FirstOrDefault(pas => pas.PaxID == tickPass.PaxRefID)
                                .Individual.MiddleNames.FirstOrDefault(),
                            Email = dataLists.ContactInfoList.FirstOrDefault(con =>
                                    con.ContactInfoID == dataLists.PaxList
                                        .FirstOrDefault(pas => pas.PaxID == tickPass.PaxRefID).ContactInfoRefID)
                                .EmailAddress.EmailAddressText,
                            Phone = dataLists.ContactInfoList.FirstOrDefault(con =>
                                    con.ContactInfoID == dataLists.PaxList
                                        .FirstOrDefault(pas => pas.PaxID == tickPass.PaxRefID).ContactInfoRefID).Phones
                                .First().PhoneNumber,
                            Document = new Document()
                            {
                                Number = dataLists.PaxList.FirstOrDefault(pas => pas.PaxID == tickPass.PaxRefID)
                                    .IdentityDocs.FirstOrDefault().IdentityDocID,
                                Code = dataLists.PaxList.FirstOrDefault(pas => pas.PaxID == tickPass.PaxRefID)
                                    .IdentityDocs.FirstOrDefault().IdentityDocTypeCode,
                                CountryCode = dataLists.PaxList.FirstOrDefault(pas => pas.PaxID == tickPass.PaxRefID)
                                    .IdentityDocs.FirstOrDefault().IssuingCountryCode,
                                ExpireDate = DateTime.Parse(dataLists.PaxList
                                    .FirstOrDefault(pas => pas.PaxID == tickPass.PaxRefID).IdentityDocs.FirstOrDefault()
                                    .ExpiryDate),
                            }
                        }).First(),
                        Ticket = ticketDocInfos.Select(tic => new Ticket
                        {
                            ///Возврат и обмен не нашла, про receipt просить
                            Number = tic.Ticket.TicketNumber,
                            Date = tic.IssueDateTime,
                            Refund = false,
                            Excange = false,
                            /*OtherReceipt = tic.Ticket.TicketReceipt*/

                        }).First(),
                        AgencyMarkup = new AgencyMarkup()
                        {
                            ///Какой code и value ? Что это и где?
                        }

                    }).ToList()
                }
            },
        };
        return orderDto;

    }
}

public class OrderDto
{
    public int Id { get; set; }
    public string WorkId { get; set; } = null!;
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// From service
    /// </summary>
    public double BaseCost { get; set; }

    /// <summary>
    /// Total
    /// </summary>
    public double Cost { get; set; }
    public string Provider { get; set; } = null!;
    public string GDS { get; set; } = null!;
    public Status Status { get; set; } = null!;
    public List<Booking> Bookings { get; set; } = null!;
}

public static class OrderViewRS
    {
        [XmlRoot(ElementName = "Envelope", Namespace = "https://www.mixvel.com/API/XSD/mixvel_envelope/1_06")]
        [Serializable]
        public class Message : IResponse
        {
            [XmlElement(ElementName = "Header", Namespace = "")]
            public Header Header { get; set; }
            [XmlElement(ElementName = "Body", Namespace = "")]
            public Body Body { get; set; }

            public IServiceError GetError()
            {
                return Body.Error ?? Body.AppData.OrderView.Error ?? Body.AppData.OrderView.Response.Warning;
            }
            public bool IsValid()
            {
                return Body.Error == null && Body.AppData.OrderView.Error == null;
            }
            public string Provider => "MixVel";
        }
        public class Body
        {
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            [XmlElement(ElementName = "MessageInfo")]
            public MessageInfo MessageInfo { get; set; }
            [XmlElement(ElementName = "AppData", Namespace = "")]
            public AppData AppData { get; set; }
            [XmlElement(ElementName = "Error")]
            public Error Error { get; set; }
        }
        public class AppData
        {
            [XmlElement(ElementName = "Mixvel_OrderViewRS", Namespace = "https://www.mixvel.com/API/XSD/Mixvel_OrderViewRS/1_01")]
            public OrderView OrderView { get; set; }
        }
        public class OrderView
        {
            [XmlElement(ElementName = "Error", Namespace = "")]
            public Error Error { get; set; }
            [XmlElement(ElementName = "Response", Namespace = "")]
            public Response Response { get; set; }
        }
        public class Response
        {
            [XmlElement(ElementName = "Warning")]
            public Error Warning { get; set; }
            [XmlElement(ElementName = "DataLists")]
            public DataLists DataLists { get; set; }
            [XmlElement(ElementName = "MixOrder")]
            public MixOrder MixOrder { get; set; }
            [XmlElement(ElementName = "PaymentFunctions")]
            public PaymentFunctions PaymentFunctions { get; set; }
            [XmlElement(ElementName = "TicketDocInfo")]
            public List<TicketDocInfo> TicketDocInfos { get; set; }
        }
    }
    
public class Status
{
    public string Code { get; set; } = null!;
    public string Text{ get; set; } = null!;
}

public interface IResponse
{
    public string Provider { get;}
    /// <summary>
    /// Проверяет, содержит ли обьект ошибки</summary>
    /// <returns>true - содержит ошибку, false - не содержит</returns>
    bool IsValid();

    /// <summary>
    /// Возвращает обьект ошибки запроса
    /// </summary>
    /// <returns></returns>
    IServiceError GetError();
}

public class DataLists
{
    [XmlArray(ElementName = "ContactInfoList")]
    public List<global::ContactInfo> ContactInfoList { get; set; }
    [XmlArray(ElementName = "BaggageAllowanceList")]
    public List<BaggageAllowance> BaggageAllowanceList { get; set; }
    [XmlArray(ElementName = "OriginDestList")]
    public List<OriginDest> OriginDestList { get; set; }
    [XmlArray(ElementName = "PaxJourneyList")]
    public List<PaxJourney> PaxJourneyList { get; set; }
    [XmlArray(ElementName = "PaxList")]
    public List<Pax> PaxList { get; set; }
    [XmlArray(ElementName = "PaxSegmentList")]
    public List<PaxSegment> PaxSegmentList { get; set; }
    [XmlArray(ElementName = "PriceClassList")]
    public List<PriceClass> PriceClassList { get; set; }
    [XmlArray(ElementName = "ServiceDefinitionList")]
    public List<ServiceDefinition> ServiceDefinitionList { get; set; }
    [XmlArray(ElementName = "ValidatingPartyList")]
    public List<ValidatingParty> ValidatingPartyList { get; set; }
    [XmlArray(ElementName = "PaxSegmentRemarkList")]
    public List<PaxSegmentRemark> PaxSegmentRemarkList { get; set; }
    [XmlArray(ElementName = "PenaltyList")]
    public List<Penalty> PenaltyList { get; set; }
}

public class ContactInfo
{
    public ContactInfo()
    {
    }

    [XmlElement(ElementName = "ContactInfoID")]
    public string ContactInfoID { get; set; }
    [XmlElement(ElementName = "EmailAddress")]
    public EmailAddress EmailAddress { get; set; }
    [XmlElement(ElementName = "OtherAddress")]
    public OtherAddress OtherAddress { get; set; }
    [XmlElement(ElementName = "Phone")]
    public List<Phone> Phones { get; set; }
}