using System.Web.Services;
using WebServiceExample.BusinessAction;
using WebServiceExample.BusinessMessage;

namespace WebServiceExample
{
    /// <summary>
    /// Summary description for WebServiceEstudiantes
    /// </summary>
    [WebService(Namespace = "http://services.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceEstudiantes : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public StudentServiceResponse GetAllStudents()
        {
            return StudentManager.GetAllStudents();
        }

        [WebMethod]
        public StudentServiceResponse SaveStudent(StudentServiceRequest studentServiceRequest)
        {
            return StudentManager.SaveStudent(studentServiceRequest);
        }
    }
}
