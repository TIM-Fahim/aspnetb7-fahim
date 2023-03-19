using School.Infrastructure.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Services
{
    public interface IStudentService
    {
        Task CreateStudent(Student student);

        Task UpdateStudent(Student student);

        Task DeleteStudent(Guid id);

        Task<IList<Student>> GetStudents();

        Task<Student> GetStudentById(Guid id);
    }
}
