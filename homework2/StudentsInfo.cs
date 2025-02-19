namespace StudentManagment
{
    public class Student{
        public string name;
        public int studentID;
        public float gradeLevel;

        public Student(string name, int id, float grade){
            this.name = name;
            studentID = id;
            gradeLevel = grade;
        }
        public void ShoeStudentInfo(){
            Console.WriteLine($"Student's name is {name}, id is {studentID}, grade is {gradeLevel}");
        }
    }


   internal class BookLibrary{
        static void Main(string[] args){
            Student[] studs = Student[2];

            for (int i = 0; i < studs.Length; i++){
                string name = Console.ReadLine() ?? "";
                int id = int.Parse(Console.ReadLine() ?? "");
                float grade = float.Parse(Console.ReadLine() ?? "");
                studs[i] = new Student(name, id, grade);
            }
            studs[0].ShoeStudentInfo();
            studs[1].ShoeStudentInfo();
        }
   }
}
