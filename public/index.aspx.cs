using System;
using System.Reflection;
using System.Web;

namespace freeway
{

    public partial class index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string controller;
            string action;

            if(freeway.Request.path() == "/about")
            {
                controller = "IndexController";
                action = "about";
            } else {
                controller = "IndexController";
                action = "index";
            }

            Type type = Type.GetType(controller);
            Object obj = Activator.CreateInstance(type);
            MethodInfo method = type.GetMethod(action);
            method.Invoke(obj, null);
        }

    }

}