namespace QuestionMe.Model.Alert
{
    public class AlertModel
    {
        public string Message { get; set; } = "";
        public AlertType Type { get; set; }
        public ControlProperty<bool> IsVisible { get; set; } = new ControlProperty<bool>(false);
    }
}