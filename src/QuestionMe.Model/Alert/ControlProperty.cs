namespace QuestionMe.Model.Alert
{
    public class ControlProperty<T>
    {
        public ControlProperty(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
    }
}
