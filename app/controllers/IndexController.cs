using freeway.freeway;

public class IndexController
{

    public void index()
    {
        Response.write("<h1>Home</h1>\n");
        Response.write(Request.host() + "<br />");
        Response.write(Request.path() + "<br />");
        Response.write(Request.port() + "<br />");
        Response.write(Request.protocol() + "<br />");
        Response.write(Request.url() + "<br />");
        Response.write(App.dotNetVersion() + "<br />");
        Response.write(Route.method() + "<br />");
    }

    public void about()
    {
        Response.write("<h1>About</h1>\n");
    }

}