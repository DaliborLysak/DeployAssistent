using Core.Providers;
using CoreIO;
using DeployProcessor.Methods;

namespace DeployProcessor
{
    public class Processor : IProcessor
    {
        public Processor(IDialogProvider dialogProvider)
        {
            DialogProvider = dialogProvider;
        }

        public IDialogProvider DialogProvider;
        public IFileManipulationProvider FileManipulationProvider = new FileManipulationProvider();

        public Project Execute<T>(Project project) where T : IMethod, new()
        {
            T method = new T();
            (method as Method).Processor = this;
            return method?.Execute(project);
        }
    }
}
