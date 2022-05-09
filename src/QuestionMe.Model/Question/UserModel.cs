namespace QuestionMe.Model.Question
{
    public record UserModel
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = "";
    }
}
