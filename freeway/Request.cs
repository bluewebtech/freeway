using System.Web;

namespace freeway.freeway
{

    public class Request
    {

        public static string host()
        {
            return HttpContext.Current.Request.Url.Host;
        }

        public static string path()
        {
            return HttpContext.Current.Request.Url.PathAndQuery;
        }

        public static int port()
        {
            return HttpContext.Current.Request.Url.Port;
        }

        public static string protocol()
        {
            return HttpContext.Current.Request.Url.Scheme;
        }

        public static string url()
        {
            return Request.protocol() + "://" + Request.host() + ":" + Request.port() + Request.path();
        }

    }

}