using DeployProcessor.Methods;

namespace DeployProcessor
{
    public interface IProcessor
    {
        Project Execute<T>(Project project) where T : IMethod, new();
    }
}
