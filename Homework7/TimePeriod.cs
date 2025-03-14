using System;
class Program {
    class TimePeriod {
        private int totalSeconds;
        public string FormattedTime {
            get {
                int h = this.totalSeconds / 3600;
                int m = (this.totalSeconds - h * 3600) / 60;
                int s = this.totalSeconds - h * 3600 - m * 60;
              
                return $"{h} hours, {m} minutes, {s} seconds";
            }
        }
        
        public TimePeriod (int seconds){
            totalSeconds = seconds;
        }
    }
    
    static void Main() {
        TimePeriod T = new TimePeriod(66);
        Console.WriteLine(T.FormattedTime);
    }
}
