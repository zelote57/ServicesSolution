namespace WebServiceExample.BusinessMessage
{
    public class StudentServiceRequest
    {
        public Student Student { get; set; }

        public StudentServiceRequest()
        {
            Student = new Student();
        }
    }
}