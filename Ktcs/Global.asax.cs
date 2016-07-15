using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ktcs.Datamodel;

namespace Ktcs
{
  public class MvcApplication : System.Web.HttpApplication
  {
    readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    protected void Application_Start()
    {
      _logger.Info("Application Started");
      AreaRegistration.RegisterAllAreas();
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);
      Database.SetInitializer(new NullDatabaseInitializer<KtcsDbContext>());


    }

    
  }
}
