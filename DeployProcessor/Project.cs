using System.Runtime.Serialization;

namespace DeployProcessor
{
    [DataContract]
    public class Project
    {
        [DataMember]
        public string SourcePath { get; set; }

        [DataMember]
        public string TargetPath { get; set; }

        [DataMember]
        public bool SaveOldVersion { get; set; }

        public string Report { get; set; }
    }
}
