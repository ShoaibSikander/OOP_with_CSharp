using System;

namespace Stopwatch
{
    class Function_Stopwatch
    {
        private DateTime _startWatch;
        private DateTime _stopWatch;
        private TimeSpan _durationWatch;
        private string startWatchString;
        private string stopWatchString;

        public string Start()
        {
            try
            {
                _startWatch = DateTime.Now;
                startWatchString = Convert.ToString(_startWatch);
                return startWatchString;
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("e == " + e);
            }
            return String.Empty;
        }

        public string Stop()
        {
            try
            {
                _stopWatch = DateTime.Now;
                stopWatchString = Convert.ToString(_stopWatch);
                return stopWatchString;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("e == " + e);
            }
            return String.Empty;
        }

        public TimeSpan Duration()
        {
            var _timeStart = new TimeSpan(_startWatch.Hour, _startWatch.Minute, _startWatch.Second);
            var _timeStop = new TimeSpan(_stopWatch.Hour, _stopWatch.Minute, _stopWatch.Second);

            _durationWatch = _timeStart - _timeStop;

            return _durationWatch;
        }
    }
}
