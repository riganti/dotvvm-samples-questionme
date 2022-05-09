using DotVVM.Framework.Hosting;
using DotVVM.Framework.ViewModel;
using QuestionMe.UiServices;

namespace QuestionMe.Pages.Default
{
    public class DefaultUiService : UiServiceBase
    {
        public DefaultUiService(IDotvvmRequestContext dotvvmRequestContext)
            : base(dotvvmRequestContext)
        {
        }

        [AllowStaticCommand]
        public void CreateDashboard()
        {
            Context.RedirectToRoute("Dashboard", new { dashboardId = Guid.NewGuid() });
        }
    }
}
