using Core.Providers;
using CoreIO.Data;
using System.IO;
using System.Runtime.Serialization.Json;

namespace DeployProcessor.Methods
{
    public class Save : Method
    {
        protected override void Process(Project project)
        {
            base.Process(project);

            var stream = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Project));
            serializer.WriteObject(stream, Project);
            var data = Processor.FileManipulationProvider.Process<SaveMemoryStreamData>(new SaveMemoryStreamData()
            {
                DialogProvider = Processor?.DialogProvider,
                Extension = ProviderTypes.ExtensionType.Json,
                MemoryStream = stream,
            });
        }
    }
}
