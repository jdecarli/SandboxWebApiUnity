using System.Web.Http;

namespace WebAPIpoc2
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            IoC.Container.InitializeIoC();
        }
    }
}
