using CoreIO;
using CoreIO.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DeployProcessor.Methods
{
    public class Deploy : Method
    {
        protected override void Process(Project project)
        {
            base.Process(project);

            var sourceInfo = new DirectoryInfo(Project.SourcePath);
            var sourceFiles = sourceInfo.GetFiles("*", SearchOption.AllDirectories);
            var fromTo = new List<Tuple<string, string>>();
            sourceFiles.ToList().ForEach(f => fromTo.Add(new Tuple<string, string>(f.FullName, f.FullName.Replace(Project.SourcePath, Project.TargetPath))));

            Processor.FileManipulationProvider.Process<CopyFileData>(new CopyFileData() { FromTo = fromTo });
        }
    }
}
