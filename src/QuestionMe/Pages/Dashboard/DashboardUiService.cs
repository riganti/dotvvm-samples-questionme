using DotVVM.Framework.Hosting;
using DotVVM.Framework.ViewModel;
using Microsoft.AspNetCore.SignalR;
using QuestionMe.BusinessServices.Services;
using QuestionMe.Model.Question;
using QuestionMe.SignalR;
using QuestionMe.UiServices;

namespace QuestionMe.Pages.Dashboard
{
    public class DashboardUiService : UiServiceBase
    {
        private readonly ActiveUserService userService;
        private readonly QuestionService questionService;
        private readonly IHubContext<QuestionHub> hubContext;

        public DashboardUiService(
            IDotvvmRequestContext dotvvmRequestContext,
            ActiveUserService userService,
            QuestionService questionService,
            IHubContext<QuestionHub> hubContext)
            : base(dotvvmRequestContext)
        {
            this.userService = userService;
            this.questionService = questionService;
            this.hubContext = hubContext;
        }

        [AllowStaticCommand]
        public Guid CreateUserIdentity()
        {
            return Guid.NewGuid();
        }

        [AllowStaticCommand]
        public UserInfoModel GetDashboardUsers(Guid dashboardId)
        {
            return userService.GetUsersInfo(dashboardId);
        }

        [AllowStaticCommand]
        public List<QuestionModel> GetQuestions(Guid dashboardId)
        {
            return questionService.GetQuestions(dashboardId);
        }

        [AllowStaticCommand]
        public void AddQuestions(Guid dashboardId, Guid userId, string text)
        {
            questionService.AddQuestion(dashboardId, userId, text);
            QuestionHub.SendNotification(hubContext, dashboardId, "refreshDashboard");
        }

        [AllowStaticCommand]
        public void RemoveQuestions(Guid dashboardId, Guid questionId, Guid userId)
        {
            questionService.RemoveQuestion(dashboardId, userId, questionId);
            QuestionHub.SendNotification(hubContext, dashboardId, "refreshDashboard");
        }

        [AllowStaticCommand]
        public void ToggleLike(Guid dashboardId, Guid questionId, Guid userId)
        {
            questionService.ToggleLike(dashboardId, userId, questionId);
            QuestionHub.SendNotification(hubContext, dashboardId, "refreshDashboard");
        }
    }
}
