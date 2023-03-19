using AutoMapper;
using School.Infrastructure.BusinessObjects;
using School.Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Services
{
    public class StudentService : IStudentService
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        private readonly IMapper _mapper;

        public StudentService(IMapper mapper, IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
            _mapper = mapper;
        }

        public async Task CreateStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteStudent(Guid id)
        {
            _applicationUnitOfWork.Students.Remove(id);
            _applicationUnitOfWork.Save();
        }

        public async Task<Student> GetStudentById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Student>> GetStudents()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
