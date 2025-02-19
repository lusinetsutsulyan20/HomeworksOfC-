namespace task2
{
    public class Employee{
        public string name;
        public string position;
        public int salaryPerHour;
        public float hoursWorked;
        public Employee(string n, string p, int s, float h){
            name = n;
            position = p;
            salaryPerHour = s;
            hoursWorked = h;
        }
        public float CalculateSalary(){
            float res = (float)salaryPerHour * hoursWorked;
            if (hoursWorked >= 40){
                res *= 1.5f;
            }
            return res;
        }
    }
     internal class BookLibrary{
        static void Main(string[] args){
            Employee[] E = new Employee[3];
            for (int i = 0; i < E.Length; i++){
                string name = Console.ReadLine() ?? "";
                string position = Console.ReadLine() ?? "";
                int salaryPerHour = int.Parse(Console.ReadLine() ?? "");
                float hoursWorked = float.Parse(Console.ReadLine() ?? "");
            }
            for (int i = 0; i < E.Length; i++){
                Console.WriteLine (E[i].CalculateSalary());
            }
        }
     }
}
