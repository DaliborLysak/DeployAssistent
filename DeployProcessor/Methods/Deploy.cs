using System;
using System.Collections.Generic;
using System.Text;

namespace DeployProcessor.Methods
{
    public class Deploy : Method
    {
        protected override void Process(Project project)
        {
            base.Process(project);

            //var sourceInfo = new DirectoryInfo(sourceDir);
            //var sourceFiles = sourceInfo.GetFiles("*", SearchOption.AllDirectories);
            ////sourceFiles.

            //FileManipulationProvider.Process(new CopyFileData());
        }
    }
}
