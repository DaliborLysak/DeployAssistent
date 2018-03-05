using System;
using System.IO;
using System.Linq;

namespace DeployProcessor.Methods
{
    public class Analyze : Method
    {
        protected override void Process(Project project)
        {
            base.Process(project);

            var sourceAnalysis = $"Deploying: {Environment.NewLine}{GetFileList(new DirectoryInfo(Project.SourcePath))}";
            var targetAnalysis = $"Files for deleting: {Environment.NewLine}{GetFileList(new DirectoryInfo(Project.TargetPath))}";
            var analysis =
                $"Analysis{Environment.NewLine}" +
                $"Source: {Project.SourcePath}{Environment.NewLine}{sourceAnalysis}{Environment.NewLine}" +
                $"Target: {Project.TargetPath}{Environment.NewLine}{targetAnalysis}{Environment.NewLine}";

            Project.Report = analysis;
        }

        private string GetFileList(DirectoryInfo directoryInfo)
        {
            var files = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
            return files.Count() > 0 ? files.Select(fi => fi.FullName).Aggregate((fn1, fn2) => $"{fn1}{Environment.NewLine}{fn2}") : files.Count() == 1 ? files[0].FullName : String.Empty;
        }
    }
}
