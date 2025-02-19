using System.Diagnostics.Contracts;

namespace SchoolSystem
{
    public class Student{
        public string name;
        public int age;
        public float grade;

        public Student(string n, int a, float g){
            name = n;
            age = a;
            grade = g;
        }
        public void Display(){
            Console.WriteLine("The student with the highest grade");
            Console.WriteLine($"the name is {name}: the age is {age}: the grade is {grade}");
        }

    }
    public class Teacher{
        public string name;
        public string subject;
        public int yearsOfExperience;

        public Teacher(string n, string s, int y){
            name = n;
            subject = s;
            yearsOfExperience = y;
        }
    }

    public class School{
        Student[] S = new Student[2];
        Teacher[] T = new Teacher[2];
        public School (Student[] s, Teacher[] t){
            S = s;
            T = t;
        }
        public void HighGrade(){
            int index = 0;
            for (int i = 1; i < S.Length; i++){
                if (S[index].grade < S[i].grade){
                    index = i;
                }
            }
            S[index].Display();
        }
        public void LessExperience(){
            for (int i = 0; i < T.Length; i++){
                if (T[i].yearsOfExperience < 2){
                    Console.WriteLine(T[i].name);
                }
            }
        }
    }

   internal class BookLibrary{
        static void Main(string[] args){
            Student[] studs = new Student[2];
            Teacher[] tech = new Teacher[2];

            for (int i = 0; i < studs.Length; i++){
                string name = Console.ReadLine() ?? "";
                int age = int.Parse(Console.ReadLine() ?? "");
                float grade = float.Parse(Console.ReadLine() ?? "");
                studs[i] = new Student(name, age, grade);
            }
            for (int i = 0; i < tech.Length; i++){
                string name = Console.ReadLine() ?? "";
                string subject = Console.ReadLine() ?? "";
                int year = int.Parse(Console.ReadLine() ?? "");
                tech[i] = new Teacher(name, subject, year);
            }

            School S = new School(studs, tech);
            S.HighGrade();
            S.LessExperience();

        }
    }

}