using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Providers;
using CoreIO.Data;
using CoreDialogs.Dialogs;
using CoreIO;
using DeployProcessor;
using DeployProcessor.Methods;

namespace DeployClient
{
    public partial class DeployClientForm : Form
    {
        public DeployClientForm()
        {
            InitializeComponent();
            EnableGUI();
            DialogProvider = new DialogProvider();
            DeployProcessor = new Processor(DialogProvider);
        }

        private IDialogProvider DialogProvider;
        private IProcessor DeployProcessor;
        public Project Project;

        private void buttonLoadSource_Click(object sender, EventArgs e)
        {
            textBoxSource.Text = DialogProvider.ShowDialog(new FolderDialog()).Uri;
            EnableGUI();
        }

        private void buttonLoadTarget_Click(object sender, EventArgs e)
        {
            textBoxTarget.Text = DialogProvider.ShowDialog(new FolderDialog()).Uri;
            EnableGUI();
        }

        private IFileManipulationProvider FileManipulationProvider = new FileManipulationProvider();

        private void toolStripButtonLoadProject_Click(object sender, EventArgs e)
        {
            var project = DeployProcessor?.Execute<Load>(new Project());
            textBoxSource.Text = project.SourcePath;
            textBoxTarget.Text = project.TargetPath;
            toolStripButtonSaveOldVersion.Checked = project.SaveOldVersion;
            EnableGUI();
        }

        private void toolStripButtonSaveProject_Click(object sender, EventArgs e)
        {
            var project = new Project()
            {
                SourcePath = textBoxSource.Text,
                TargetPath = textBoxTarget.Text,
                SaveOldVersion = toolStripButtonSaveOldVersion.Checked
            };
            DeployProcessor?.Execute<Save>(project);
        }

        private void EnableGUI()
        {
            var validPaths = !String.IsNullOrEmpty(textBoxSource.Text) && !String.IsNullOrEmpty(textBoxTarget.Text);
            toolStripButtonSaveProject.Enabled = validPaths;
            toolStripButtonDeploy.Enabled = validPaths;
            toolStripButtonAnalyze.Enabled = validPaths;
        }

        private void toolStripButtonAnalyze_Click(object sender, EventArgs e)
        {
            richTextBoxAnalysis.Text = 
                DeployProcessor?.Execute<Analyze>(new Project() { SourcePath = textBoxSource.Text, TargetPath = textBoxTarget.Text })?.Report;
        }

        private void toolStripButtonDeploy_Click(object sender, EventArgs e)
        {
            richTextBoxAnalysis.Text =
                DeployProcessor?.Execute<Deploy>(new Project() { SourcePath = textBoxSource.Text, TargetPath = textBoxTarget.Text })?.Report;
        }
    }
}
