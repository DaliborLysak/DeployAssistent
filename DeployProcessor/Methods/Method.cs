using System;
using System.Collections.Generic;
using System.Text;
using DeployProcessor;

namespace DeployProcessor.Methods
{
    public class Method: IMethod
    {
        public Processor Processor { get; set; }
        protected Project Project { get; set; }

        public Project Execute(Project project)
        {
            Process(project);
            return Project;
        }

        protected virtual void Process(Project project)
        {
            Project = project;
        }
    }
}
