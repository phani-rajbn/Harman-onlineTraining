using System;
using System.Threading;
namespace SampleConApp
{
    delegate void RaiseAlarm();
    class AlarmClock
    {
        private DateTime _alarmTime;
        public event RaiseAlarm OnAlarmRaise;//All events are instances of delegates
        public AlarmClock(DateTime time)
        {
            _alarmTime = time;
        }
        public void DisplayClock()
        {
            while (true)
            {
                Console.WriteLine(DateTime.Now.ToLongTimeString());
                //Console.Beep(1234, 1000);
                Thread.Sleep(1000);//Makes the thread pause for a second...
                Console.Clear();
                if(_alarmTime.ToShortTimeString() == DateTime.Now.ToShortTimeString())
                {
                    if(OnAlarmRaise != null)
                        OnAlarmRaise();//Raising the event....
                }
            }
        }
    }
    class EventsDemo
    {
        static void Main(string[] args)
        {
            AlarmClock clock = new AlarmClock(DateTime.Now.AddMinutes(1));
            //clock.OnAlarmRaise += Clock_OnAlarmRaise;
            clock.DisplayClock();
        }

        private static void Clock_OnAlarmRaise()
        {
            Console.WriteLine("Time for Dinner!!!!!");
        }
    }
}
