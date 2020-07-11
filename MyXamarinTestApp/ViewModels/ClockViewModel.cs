using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyXamarinTestApp.ViewModels
{
    public class ClockViewModel : INotifyPropertyChanged
    {
        DateTime dateTime = DateTime.Now;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ClockViewModel()
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(15), OnTimerTick);
        }

        bool OnTimerTick()
        {
            MyDateTime = DateTime.Now;
            return true;
        }

        public DateTime MyDateTime
        {
            private set
            {
                if (dateTime != value)
                {
                    dateTime = value;
                    // Fire the event.
                    RaisePropertyChanged(nameof(MyDateTime));
                }
            }
            get
            {
                return dateTime;
            }
        }

    }
}
