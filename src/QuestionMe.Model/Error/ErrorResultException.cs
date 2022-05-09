namespace QuestionMe.Model.Error
{
    public abstract class ErrorResultException : Exception
    {
        protected ErrorResultException(string message) : base(message)
        {
        }
    }
}
