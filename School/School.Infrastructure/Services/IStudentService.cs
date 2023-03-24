using School.Infrastructure.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentBO = School.Infrastructure.BusinessObjects.Student;
namespace School.Infrastructure.Services
{
    public interface IStudentService
    {
        Task CreateStudent(StudentBO student);

        Task UpdateStudent(StudentBO student);

        Task DeleteStudent(Guid id);

        Task<IList<StudentBO>> GetStudents();

        Task<StudentBO> GetStudentById(Guid id);
    }
}
