namespace task2
{
    public class Student
    {
        public string name;
        public int age;
        public int grade;

        public Student(string n, int a, int g)
        {
            name = n;
            age = a;
            grade = g;
        }

        void DisplayDetails()
        {
            Console.WriteLine($"Name - {name}:  age - {age}:  grade - {grade}");
        }
    }

    internal class StudentManagment
    {
        static void Main(string[] args)
        {
            Student[] S = new Student[5];

            for (int i = 0; i < S.Length; i++)
            {
                string name = Console.ReadLine() ?? "";
                int age = int.Parse(Console.ReadLine() ?? "");
                int grade = int.Parse(Console.ReadLine() ?? "");

                S[i] = new Student(name, age, grade);
            }
            for (int i = 0; i < S.Length; i++)
            {
                S[i].DisplayDetails();
            }
        }

    }
}
}
