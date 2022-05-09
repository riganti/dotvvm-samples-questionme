using QuestionMe.Model.Alert;

namespace QuestionMe.Pages
{
    public class MasterPageViewModel : ViewModelBase
    {
        public AlertModel Alert { get; set; } = new AlertModel();
        public object Errors { get; set; } = new object();       
    }
}