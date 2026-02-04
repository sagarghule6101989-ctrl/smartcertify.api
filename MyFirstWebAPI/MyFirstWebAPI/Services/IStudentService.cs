using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        void AddStudent(Student student);
    }
}
