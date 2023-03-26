using Autofac;
using AutoMapper;
using Microsoft.AspNetCore.Cors.Infrastructure;
using School.Infrastructure.BusinessObjects;
using School.Infrastructure.Entities;
using School.Infrastructure.Services;

namespace School.Api.DTOs
{
    public class StudentDTO
    {
        private IStudentService? _studentService;
        private IMapper _mapper;
        public Guid ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public double CGPA { get; set; }

        public StudentDTO() { }

        public StudentDTO(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        public void ResolveDependency(ILifetimeScope scope)
        {
            _studentService = scope.Resolve<IStudentService>();
            _mapper = scope.Resolve<IMapper>();
        }

        internal void DeleteStudent(Guid id)
        { 
            _studentService?.DeleteStudent(id);
        }

        internal async Task<List<StudentDTO>> GetAllStudentAsync()
        {
            var students =  await _studentService?.GetStudents();
            //var studentDTOs = _mapper.Map<List<StudentDTO>>(students);

            List<StudentDTO> studentDTOs1 = new List<StudentDTO>();
            foreach (var student in students)
            {
                studentDTOs1.Add(_mapper.Map<StudentDTO>(student));
            }
            //_mapper.Map<List<StudentDTO>>(students);

            return studentDTOs1;
        }

        internal void CreateStudent()
        {
            Infrastructure.BusinessObjects.Student student = _mapper.Map<Infrastructure.BusinessObjects.Student>(this);

            _studentService.CreateStudent(student);
        }
        internal void UpdateStudent()
        {
            Infrastructure.BusinessObjects.Student student = _mapper.Map<Infrastructure.BusinessObjects.Student>(this);

            _studentService.UpdateStudent(student);
        }
    }
}
