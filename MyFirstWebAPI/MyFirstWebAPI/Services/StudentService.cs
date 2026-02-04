using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Services
{
    public class StudentService:IStudentService
    {
        public StudentService() { }
        private static List<Student> _students = new List<Student> {
            new Student { Id=1,Name="Sagar"},
            new Student { Id=2,Name="Rahul" }
        };
        public List<Student> GetStudents() => _students;
        public void AddStudent(Student student)
        {
            student.Id = _students.Count + 1;
            _students.Add(student);
        }
    }
}
