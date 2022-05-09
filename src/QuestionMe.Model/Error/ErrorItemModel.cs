namespace QuestionMe.Model.Error
{
    public class ErrorItemModel
    {
        public string Message { get; set; }
        public string? TargetPath { get; set; }
        public ErrorItemModel(string message, string? targetPath)
        {
            Message = message;
            TargetPath = targetPath;
        }

    }
}
