using freeway.freeway;

public class IndexController
{

    public void index()
    {
        Response.write(Request.host() + "<br />");
        Response.write(Request.path() + "<br />");
        Response.write(Request.port() + "<br />");
        Response.write(Request.protocol() + "<br />");
        Response.write(Request.url() + "<br />");
        Response.write(App.dotNetVersion() + "<br />");
        Response.write(Route.method() + "<br />");
    }

}