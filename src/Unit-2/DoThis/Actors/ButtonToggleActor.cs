using System.Windows.Forms;
using Akka.Actor;

namespace ChartApp.Actors
{
    public class ButtonToggleActor : UntypedActor
    {
        private readonly IActorRef _coordinatorActor;
        private readonly Button _myButton;

        private readonly CounterType _myCounterType;
        private bool _isToggledOn;

        public ButtonToggleActor(IActorRef coordinatorActor, Button myButton, CounterType myCounterType,
            bool isToggledOn)
        {
            _myCounterType = myCounterType;
            _isToggledOn = isToggledOn;
            _myButton = myButton;
            _coordinatorActor = coordinatorActor;
        }

        protected override void OnReceive(object message)
        {
            if (message is Toggle && _isToggledOn)
            {
                _coordinatorActor.Tell(new PerformanceCounterCoordinatorActor.Unwatch(_myCounterType));
                FlipToggle();
            }
            else if (message is Toggle && !_isToggledOn)
            {
                _coordinatorActor.Tell(new PerformanceCounterCoordinatorActor.Watch(_myCounterType));

                FlipToggle();
            }
            else
            {
                Unhandled(message);
            }
        }

        private void FlipToggle()
        {
            _isToggledOn = !_isToggledOn;

            _myButton.Text = $"{_myCounterType.ToString().ToUpperInvariant()} ({(_isToggledOn ? "ON" : "OFF")})";
        }

        #region Message Types

        public class Toggle
        {
        }

        #endregion
    }
}