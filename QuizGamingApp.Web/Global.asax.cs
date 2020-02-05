using QuizGamingApp.Core.DAL;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace QuizGamingApp.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
       
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            QuizGamingAppDBRepository.CreateDocumentClient();
            new ClientProfileRepository().Initialize();
            new PlayerProfileRepository().Initialize();
            new QuizGameRepository().Initialize();
            new QuizQuestionRepository().Initialize();
            new QuestionAnswerRepository().Initialize();
            new QuizGameAnswerRepository().Initialize();
        }
    }
}
