// See https://aka.ms/new-console-template for more information
using Assignment01;
using System.Text.Json;

Course course = new Course();
course.Title = "Asp.net";
course.Fees = 30000;
//Teacher
course.Teacher = new Instructor();
course.Teacher.Name = "Jalal Uddin";
course.Teacher.Email = "jalalboss@devksill.com";
course.Teacher.PresentAddress = new ();
course.Teacher.PresentAddress.City = "Dhaka";
course.Teacher.PresentAddress.Street = "Begum Rokeya Sarani";
course.Teacher.PresentAddress.Country = "Bangladesh";

course.Teacher.PermanentAddress = new();
course.Teacher.PermanentAddress.City = "New York";
course.Teacher.PermanentAddress.Street = "Boardway";
course.Teacher.PermanentAddress.Country = "USA";
course.Teacher.PhoneNumbers = new List<Phone>();
//Phones List
Phone number1 = new Phone { Number = "1777818008", Extension = "0",CountryCode = "+880"};
Phone number2 = new Phone { Number = "364962655", Extension = "1", CountryCode = "+760" };
course.Teacher.PhoneNumbers.Add(number1);
course.Teacher.PhoneNumbers.Add(number2);
//Topics List
Session session1 = new Session {DurationInHour = 2, LearningObjective = "Class 1" };
Session session2 = new Session { DurationInHour = 2, LearningObjective = "Class 2" };
Session session3 = new Session { DurationInHour = 2, LearningObjective = "Class 3" };
Session session4 = new Session { DurationInHour = 2, LearningObjective = "Class 4" };

List<Session> sList1 = new();
sList1.Add(session1);
sList1.Add(session2);
List<Session> sList2 = new();
sList1.Add(session3);
sList1.Add(session4);

course.Topics = new List<Topic>();
Topic topic1 = new Topic {Title = "Events & Deligates",Description = "Discussion", Sessions = sList1 };
Topic topic2 = new Topic { Title = "Reflections", Description = "Discussion", Sessions = sList2 };
course.Topics = new List<Topic>();
course.Topics.Add(topic1);
course.Topics.Add(topic2);

//Admission Test

course.Tests = new List<AdmissionTest>();
AdmissionTest aT1 = new AdmissionTest { StartDateTime = DateTime.MinValue, EndDateTime = DateTime.Now, TestFees = 100};
AdmissionTest aT2 = new AdmissionTest { StartDateTime = DateTime.Now, EndDateTime = DateTime.MaxValue, TestFees = 100 };
course.Tests.Add(aT1);
course.Tests.Add(aT2);
// all other fields set here.

//string json = JsonFormatter.Convert(course);

Console.WriteLine(JsonSerializer.Serialize(course));

