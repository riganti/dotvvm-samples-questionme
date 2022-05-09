using DotVVM.Framework.Binding;
using DotVVM.Framework.Controls;
using DotVVM.Framework.Hosting;
using QuestionMe.Model.Alert;

namespace QuestionMe.Controls.Alert
{
    public class Alert : DotvvmMarkupControlBase
    {
        [MarkupOptions(AllowBinding = true)]
        public string Message
        {
            get { return (string?)GetValue(MessageProperty) ?? ""; }
            set { SetValue(MessageProperty, value); }
        }
        public static readonly DotvvmProperty MessageProperty
            = DotvvmProperty.Register<string, Alert>(c => c.Message, "");

        [MarkupOptions(AllowBinding = true)]
        public ControlProperty<bool> IsVisible
        {
            get { return (ControlProperty<bool>?)GetValue(IsVisibleProperty) ?? new ControlProperty<bool>(false); }
            set { SetValue(IsVisibleProperty, value); }
        }
        public static readonly DotvvmProperty IsVisibleProperty
            = DotvvmProperty.Register<ControlProperty<bool>, Alert>(c => c.IsVisible, new ControlProperty<bool>(false));

        public AlertType Type
        {
            get { return (AlertType?)GetValue(TypeProperty) ?? AlertType.Info; }
            set { SetValue(TypeProperty, value); }
        }
        public static readonly DotvvmProperty TypeProperty
            = DotvvmProperty.Register<AlertType, Alert>(c => c.Type, AlertType.Info);
    }
}