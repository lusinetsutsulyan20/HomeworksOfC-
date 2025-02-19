namespace CourseEnrollment
{
    public class Course{
        public string courseName;
        public string instructor;
        public int maxStudents;

        public Course(string courseName, string instructor, int maxStudents){
            this.courseName = courseName;
            this.instructor = instructor;
            this.maxStudents = maxStudents;
        }
        public void ShowCourseDetails(){
            Console.WriteLine($"The course name is {name}: the insructor is {instructor}: the students' max count is {maxStudents}");
        }
    }

    internal class CourseEnrollment{
        static void Main(string[] args){
            Course C = new Course("kurs", "anun", 25);
            C.ShowCourseDetails();
        }
    }


}
