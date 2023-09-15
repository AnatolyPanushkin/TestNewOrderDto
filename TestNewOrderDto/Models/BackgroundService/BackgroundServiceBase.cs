using Microsoft.Extensions.Hosting;

namespace Contracts.Background;
public abstract class BackgroundServiceBase : BackgroundService
{
    readonly IHostApplicationLifetime _lifetime;
    ILoggerManager _logger;

    /// <summary>
    /// Время старта работы службы
    /// </summary>
    TimeOnly _startTime;

    /// <summary>
    /// Интервал повторения работы службы в миллисекундах
    /// </summary>
    TimeSpan _repeat;

    /// <summary>
    /// Логгер
    /// </summary>
    public ILoggerManager Logger
    {
        get => _logger;
        set => _logger = value;
    }

    /// <summary>
    /// Интервал повторения работы службы в миллисекундах
    /// </summary>
    public TimeSpan Repeat
    {
        get => _repeat;
    }

    /// <summary>
    /// Раз в 24 часа
    /// </summary>
    public static TimeSpan EveryDay
    {
        get => TimeSpan.FromDays(1);
    }

    /// <summary>
    /// Раз в час
    /// </summary>
    public static TimeSpan EveryHour
    {
        get => TimeSpan.FromHours(1);
    }

    /// <summary>
    /// Раз в пол-часа
    /// </summary>
    public static TimeSpan EveryHalfHour
    {
        get => TimeSpan.FromMinutes(30);
    }

    /// <summary>
    /// Раз в минуту
    /// </summary>
    public static TimeSpan EveryMinute
    {
        get => TimeSpan.FromMinutes(1);
    }

    /// <summary>
    /// Раз в пол минуты
    /// </summary>
    public static TimeSpan EveryHalfMinute
    {
        get => TimeSpan.FromSeconds(30);
    }

    /// <summary>
    /// Раз в сукунду
    /// </summary>
    public static TimeSpan EverySecond
    {
        get => TimeSpan.FromSeconds(1);
    }

    /// <summary>
    /// Представляет 00:00
    /// </summary>
    public static TimeOnly Midnight
    {
        get => new TimeOnly(0, 0);
    }

    /// <summary>
    /// Представляет 08:00
    /// </summary>
    public static TimeOnly WorkDayBeginning
    {
        get => new TimeOnly(8, 0);
    }

    /// <summary>
    /// Представляет 12:00
    /// </summary>
    public static TimeOnly LunchTime
    {
        get => new TimeOnly(12, 0);
    }

    /// <summary>
    /// Представляет 18:00
    /// </summary>
    public static TimeOnly WorkDayEnding
    {
        get => new TimeOnly(18, 0);
    }

    protected BackgroundServiceBase(IHostApplicationLifetime lifetime, ILoggerManager logger)
    {
        _lifetime = lifetime;
        _logger = logger;
        _startTime = TimeOnly.FromDateTime(DateTime.Now).Add(TimeSpan.FromSeconds(20));
        _repeat = EveryDay;
    }
    protected BackgroundServiceBase(IHostApplicationLifetime lifetime, ILoggerManager logger, TimeOnly start)
    {
        _lifetime = lifetime;
        _logger = logger;
        _startTime = start;
        _repeat = EveryDay;
    }
    protected BackgroundServiceBase(IHostApplicationLifetime lifetime, ILoggerManager logger, TimeSpan repeat)
    {
        _lifetime = lifetime;
        _logger = logger;
        _startTime = TimeOnly.FromDateTime(DateTime.Now).Add(TimeSpan.FromSeconds(10));
        _repeat = repeat;
    }
    protected BackgroundServiceBase(IHostApplicationLifetime lifetime, ILoggerManager logger, TimeOnly start, TimeSpan repeat)
    {
        _lifetime = lifetime;
        _logger = logger;
        _startTime = start;
        _repeat = repeat;
    }

    static async Task<bool> WaitForAppStartup(IHostApplicationLifetime lifetime, CancellationToken stoppingToken)
    {
        // Создаём TaskCompletionSource для ApplicationStarted
        var startedSource = new TaskCompletionSource();
        using var reg1 = lifetime.ApplicationStarted.Register(() => startedSource.SetResult());

        // Создаём TaskCompletionSource для stoppingToken
        var cancelledSource = new TaskCompletionSource();
        using var reg2 = stoppingToken.Register(() => cancelledSource.SetResult());

        // Ожидаем любое из событий запуска или запроса на остановку
        Task completedTask = await Task.WhenAny(startedSource.Task, cancelledSource.Task).ConfigureAwait(false);

        // Если завершилась задача ApplicationStarted, возвращаем true, иначе false
        return completedTask == startedSource.Task;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (!await WaitForAppStartup(_lifetime, stoppingToken))
            return;

        // Приложение запущено и готово к обработке запросов
        var span = _startTime - TimeOnly.FromDateTime(DateTime.Now);
        await Task.Delay(span > TimeSpan.FromSeconds(0) ? span : TimeSpan.FromSeconds(0));
        while (!stoppingToken.IsCancellationRequested)
        {

            try
            {
                await ToDo();
            }
            catch (System.Exception e)
            {
                Logger.LogError(e.Message + e.StackTrace);
                Logger.LogFile(e.Message + e.StackTrace, "txt", this.GetType().Name, "ErrorBackground");
            }
            await Task.Delay(_repeat);
        }

    }

    /// <summary>
    /// Функция, выполнение которой производится с указанным периодом <see cref="Repeat"/>
    /// </summary>
    /// <returns></returns>
    public abstract Task ToDo();

    /// <summary>
    /// Устанавливает интервал повторения
    /// </summary>
    /// <param name="value">Значение в миллисекундах</param>
    /// <returns></returns>
    public BackgroundServiceBase SetRepeat(TimeSpan value)
    {
        this._repeat = value;
        return this;
    }

    /// <summary>
    /// Устанавливает время старта выполнения первой операции <see cref="ToDo"/>
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public BackgroundServiceBase SetStart(TimeOnly value)
    {
        this._startTime = value;
        return this;
    }
}