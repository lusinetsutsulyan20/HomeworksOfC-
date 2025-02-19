namespace WeatherForecast
{
    public class WeatherReport{
        public float temperature;

        public float humidity;
        public string weatherCondition;

        public WeatherReport(float temp, float hum, string cond){
            temperature = temp;
            humidity = hum;
            weatherCondition = cond;
        }
    }
    internal class BookLibrary{
        static void Main(string[] args){
            WeatherReport[] weathers = new WeatherReport[2];

            for (int i = 0; i < weathers.Length; i++){
                float temp = float.Parse(Console.ReadLine() ?? "");
                float humidity = float.Parse(Console.ReadLine() ?? "");
                string condition = Console.ReadLine() ?? "";

                weathers[i] = new WeatherReport(temp, humidity, condition);
            }

            for (int i = 0; i < weathers.Length; i++){
                Console.WriteLine($"Temperature : {weathers[i].temperature}");
                Console.WriteLine($"Humidity : {weathers[i].humidity}");
                Console.WriteLine($"Weather Condition : {weathers[i].weatherCondition}");
            }
        }
    }
}
