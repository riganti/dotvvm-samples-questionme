using DotVVM.Framework.Hosting;

namespace QuestionMe.UiServices
{

    public class UiServiceBase : IUiService
    {
        public IDotvvmRequestContext Context { get; }

        public UiServiceBase(IDotvvmRequestContext dotvvmRequestContext)
        {
            Context = dotvvmRequestContext;
        }
    }
}
