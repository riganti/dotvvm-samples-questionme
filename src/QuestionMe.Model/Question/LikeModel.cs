namespace QuestionMe.Model.Question
{
    public record LikeModel
    {
        public UserModel User { get; init; }

        public LikeModel(UserModel user)
        {
            User = user;
        }
    }
}
