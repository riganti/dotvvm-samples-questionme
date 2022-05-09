using System.Collections.Generic;

namespace QuestionMe.Model.Question
{
    public record UserInfoModel
    {
        public List<string> Names { get; init; } = new();
        public long Count { get; init; }
    }
}