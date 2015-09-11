using Akka.Actor;

namespace ChartApp.Actors
{

    #region Reporting

    public class GatherMetrics
    {
    }

    public class Metric
    {
        public Metric(string series, float counterValue)
        {
            CounterValue = counterValue;
            Series = series;
        }

        public float CounterValue { get; private set; }

        public string Series { get; private set; }
    }

    #endregion

    #region Performance Counter Management

    public enum CounterType
    {
        Cpu,
        Memory,
        Disk
    }

    public class SubscribeCounter
    {
        public SubscribeCounter(CounterType counter, IActorRef subscriber)
        {
            Subscriber = subscriber;
            Counter = counter;
        }

        public CounterType Counter { get; set; }

        public IActorRef Subscriber { get; set; }
    }

    public class UnsubscribeCounter
    {
        public UnsubscribeCounter(CounterType counter, IActorRef subscriber)
        {
            Subscriber = subscriber;
            Counter = counter;
        }

        public CounterType Counter { get; set; }

        public IActorRef Subscriber { get; set; }
    }

    #endregion
}