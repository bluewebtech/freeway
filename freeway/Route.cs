using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace freeway.freeway
{

    public class Route
    {

        public string get(string url, string action)
        {
            return url;
        }

        public string post(string url, string action)
        {
            return url;
        }

        public static string method()
        {
            return HttpContext.Current.Request.RequestType;
        }

        /*
        public string run()
        {
            switch(this.method())
            {
                case "GET":
                    return "GET method";
                break;

                case "POST":
                    return "POST method";
                break;
            }
        }
        */

    }

}