using System.Collections.Generic;
using WebServiceExample.BusinessMessage;

namespace WebServiceExample.BusinessAction
{
    public static class StudentManager
    {
        public static StudentServiceResponse GetAllStudents()
        {
            var students = GetStudents();

            return new StudentServiceResponse
            {
                ActionSuccess = true,
                Students = students
            };
        }

        public static StudentServiceResponse SaveStudent(StudentServiceRequest studentRequest)
        {
            var response = new StudentServiceResponse();

            if (studentRequest == null)
            {
                response.ActionSuccess = false;
                response.ErrorDescription = "Debe proporcionar un estudiante";
                return response;
            }

            if (string.IsNullOrEmpty(studentRequest.Student.FirstName))
            {
                response.ActionSuccess = false;
                response.ErrorDescription = "Debe proporcionar un nombre de estudiante";
                return response;
            }

            if (string.IsNullOrEmpty(studentRequest.Student.LastName))
            {
                response.ActionSuccess = false;
                response.ErrorDescription = "Debe proporcionar un apellido de estudiante";
                return response;
            }

            var students = GetStudents();

            students.Add(studentRequest.Student);

            response.Students = students;
            response.ActionSuccess = true;
            return response;
        }

        private static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student()
                {
                    FirstName = "Daniel",
                    LastName = "Olivo"
                },
                new Student()
                {
                    FirstName = "Carlos",
                    LastName = "Dimitrakis"
                },
                new Student()
                {
                    FirstName = "Betsabe",
                    LastName = "Correa"
                },
                new Student()
                {
                    FirstName = "Moises",
                    LastName = "Chavez"
                },
                new Student()
                {
                    FirstName = "Joshua",
                    LastName = "González"
                },
                new Student()
                {
                    FirstName = "David",
                    LastName = "Sanchez"
                },
                new Student()
                {
                    FirstName = "Edwin",
                    LastName = "Falcones"
                }
            };
        }

    }
}