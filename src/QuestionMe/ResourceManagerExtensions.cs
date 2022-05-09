using DotVVM.Framework.ResourceManagement;

namespace QuestionMe
{
    public static class ResourceManagerExtensions
    {
        public static void TryAddRequiredResource(this ResourceManager resourceManager, string moduleCssResourceName)
        {
            bool ResourceExist(string resourceName)
            {
                try
                {
                    resourceManager.FindResource(resourceName);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            if (ResourceExist(moduleCssResourceName))
            {
                resourceManager.AddRequiredResource(moduleCssResourceName);
            }
        }
    }
}
