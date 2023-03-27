using AutoMapper;
using School.Infrastructure.BusinessObjects;
//using CourseBO = FirstDemo.Infrastructure.BusinessObjects.Course;
//using CourseEO = FirstDemo.Infrastructure.Entities.Course;
using StudentBO =  School.Infrastructure.BusinessObjects.Student;
using StudentEO = School.Infrastructure.Entities.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Infrastructure.UnitOfWorks;

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

        public async Task CreateStudent(StudentBO student)
        {
            var count = _applicationUnitOfWork.Students.GetCount(x => x.ID == student.ID);

            if (count > 0)
                throw new Exception("Student already exists");

            //course.SetProperClassStartDate();

            StudentEO studentEntity = _mapper.Map<StudentEO>(student);

            _applicationUnitOfWork.Students.Add(studentEntity);
            _applicationUnitOfWork.Save();
        }

        public async Task DeleteStudent(Guid id)
        {
            _applicationUnitOfWork.Students.Remove(id);
            _applicationUnitOfWork.Save();
        }

        public async Task<StudentBO> GetStudentById(Guid id)
        {
            StudentEO studentEO =  _applicationUnitOfWork.Students.GetById(id);
            StudentBO studentBO = _mapper.Map<StudentBO>(studentEO);
            return studentBO;
        }

        public async Task<IList<StudentBO>> GetStudents()
        {
            IList<StudentEO> students =  _applicationUnitOfWork.Students.GetAll();
            //return students != null ? _mapper.Map<List<StudentBO>>(students) : null;

            List<StudentBO> studentBOs = new List<StudentBO>();
            foreach (var student in students)
            {
                studentBOs.Add(_mapper.Map<StudentBO>(student));
            }
            return studentBOs;
        }

        public async Task UpdateStudent(Student student)
        {
            var studentEo = _applicationUnitOfWork.Students.GetById(student.ID);
            if (studentEo != null)
            {
                studentEo = _mapper.Map(student, studentEo);

                _applicationUnitOfWork.Save();
            }
            else
                throw new InvalidOperationException("Course was not found");
        }
    }
}
