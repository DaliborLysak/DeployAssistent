using Core.Providers;
using CoreIO.Data;
using System.Runtime.Serialization.Json;

namespace DeployProcessor.Methods
{
    public class Load : Method
    {
        protected override void Process(Project project)
        {
            base.Process(project);

            var data = Processor?.FileManipulationProvider?.Process<LoadStreamData>(new LoadStreamData()
            {
                DialogProvider = Processor?.DialogProvider,
                Extension = ProviderTypes.ExtensionType.Json
            });
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Project));
            using (var stream = (data as LoadStreamData)?.Stream)
            {
                Project = (Project)serializer.ReadObject(stream);
            }
        }
    }
}
