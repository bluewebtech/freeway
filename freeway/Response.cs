using System.Web;

namespace freeway.freeway
{

    public class Response
    {

        public static void write(string value)
        {
            HttpContext.Current.Response.Write(value + "\n");
        }

    }

}