using System.Collections.Generic;

namespace WebServiceExample.BusinessMessage
{
    public class StudentServiceResponse : BusinessActionResponse
    {
        public List<Student> Students { get; set; }
    }
}