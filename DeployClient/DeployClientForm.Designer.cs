namespace DeployClient
{
    partial class DeployClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeployClientForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLoadTarget = new System.Windows.Forms.Button();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanelSource = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLoadSource = new System.Windows.Forms.Button();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLoadProject = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveProject = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAnalyze = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeploy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveOldVersion = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.richTextBoxAnalysis = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelSource.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelSource, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxAnalysis, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 369);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.buttonLoadTarget);
            this.flowLayoutPanel1.Controls.Add(this.textBoxTarget);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(747, 29);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // buttonLoadTarget
            // 
            this.buttonLoadTarget.Image = global::DeployClient.Properties.Resources.Folder;
            this.buttonLoadTarget.Location = new System.Drawing.Point(3, 3);
            this.buttonLoadTarget.Name = "buttonLoadTarget";
            this.buttonLoadTarget.Size = new System.Drawing.Size(23, 23);
            this.buttonLoadTarget.TabIndex = 1;
            this.buttonLoadTarget.UseVisualStyleBackColor = true;
            this.buttonLoadTarget.Click += new System.EventHandler(this.buttonLoadTarget_Click);
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(32, 3);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.ReadOnly = true;
            this.textBoxTarget.Size = new System.Drawing.Size(704, 20);
            this.textBoxTarget.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target";
            // 
            // flowLayoutPanelSource
            // 
            this.flowLayoutPanelSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelSource.Controls.Add(this.buttonLoadSource);
            this.flowLayoutPanelSource.Controls.Add(this.textBoxSource);
            this.flowLayoutPanelSource.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanelSource.Name = "flowLayoutPanelSource";
            this.flowLayoutPanelSource.Size = new System.Drawing.Size(747, 29);
            this.flowLayoutPanelSource.TabIndex = 2;
            // 
            // buttonLoadSource
            // 
            this.buttonLoadSource.Image = global::DeployClient.Properties.Resources.Folder;
            this.buttonLoadSource.Location = new System.Drawing.Point(3, 3);
            this.buttonLoadSource.Name = "buttonLoadSource";
            this.buttonLoadSource.Size = new System.Drawing.Size(23, 23);
            this.buttonLoadSource.TabIndex = 0;
            this.buttonLoadSource.UseVisualStyleBackColor = true;
            this.buttonLoadSource.Click += new System.EventHandler(this.buttonLoadSource_Click);
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(32, 3);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ReadOnly = true;
            this.textBoxSource.Size = new System.Drawing.Size(704, 20);
            this.textBoxSource.TabIndex = 1;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLoadProject,
            this.toolStripButtonSaveProject,
            this.toolStripButtonAnalyze,
            this.toolStripButtonDeploy,
            this.toolStripButtonSaveOldVersion,
            this.toolStripProgressBar1});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(752, 38);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "Load project";
            // 
            // toolStripButtonLoadProject
            // 
            this.toolStripButtonLoadProject.Image = global::DeployClient.Properties.Resources.Basket;
            this.toolStripButtonLoadProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadProject.Name = "toolStripButtonLoadProject";
            this.toolStripButtonLoadProject.Size = new System.Drawing.Size(77, 35);
            this.toolStripButtonLoadProject.Text = "Load Project";
            this.toolStripButtonLoadProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonLoadProject.Click += new System.EventHandler(this.toolStripButtonLoadProject_Click);
            // 
            // toolStripButtonSaveProject
            // 
            this.toolStripButtonSaveProject.Image = global::DeployClient.Properties.Resources.Save;
            this.toolStripButtonSaveProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveProject.Name = "toolStripButtonSaveProject";
            this.toolStripButtonSaveProject.Size = new System.Drawing.Size(75, 35);
            this.toolStripButtonSaveProject.Text = "Save Project";
            this.toolStripButtonSaveProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonSaveProject.Click += new System.EventHandler(this.toolStripButtonSaveProject_Click);
            // 
            // toolStripButtonAnalyze
            // 
            this.toolStripButtonAnalyze.Image = global::DeployClient.Properties.Resources.Search;
            this.toolStripButtonAnalyze.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnalyze.Name = "toolStripButtonAnalyze";
            this.toolStripButtonAnalyze.Size = new System.Drawing.Size(52, 35);
            this.toolStripButtonAnalyze.Text = "Analyze";
            this.toolStripButtonAnalyze.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAnalyze.Click += new System.EventHandler(this.toolStripButtonAnalyze_Click);
            // 
            // toolStripButtonDeploy
            // 
            this.toolStripButtonDeploy.Image = global::DeployClient.Properties.Resources.Arrow_Right;
            this.toolStripButtonDeploy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeploy.Name = "toolStripButtonDeploy";
            this.toolStripButtonDeploy.Size = new System.Drawing.Size(48, 35);
            this.toolStripButtonDeploy.Text = "Deploy";
            this.toolStripButtonDeploy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonDeploy.Click += new System.EventHandler(this.toolStripButtonDeploy_Click);
            // 
            // toolStripButtonSaveOldVersion
            // 
            this.toolStripButtonSaveOldVersion.Checked = true;
            this.toolStripButtonSaveOldVersion.CheckOnClick = true;
            this.toolStripButtonSaveOldVersion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonSaveOldVersion.Image = global::DeployClient.Properties.Resources.Security;
            this.toolStripButtonSaveOldVersion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveOldVersion.Name = "toolStripButtonSaveOldVersion";
            this.toolStripButtonSaveOldVersion.Size = new System.Drawing.Size(98, 35);
            this.toolStripButtonSaveOldVersion.Text = "Save Old Version";
            this.toolStripButtonSaveOldVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonSaveOldVersion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 35);
            // 
            // richTextBoxAnalysis
            // 
            this.richTextBoxAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxAnalysis.Location = new System.Drawing.Point(3, 103);
            this.richTextBoxAnalysis.Name = "richTextBoxAnalysis";
            this.richTextBoxAnalysis.ReadOnly = true;
            this.richTextBoxAnalysis.Size = new System.Drawing.Size(747, 263);
            this.richTextBoxAnalysis.TabIndex = 4;
            this.richTextBoxAnalysis.Text = "";
            // 
            // DeployClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 412);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeployClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deploy Assistent";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanelSource.ResumeLayout(false);
            this.flowLayoutPanelSource.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadProject;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnalyze;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeploy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSource;
        private System.Windows.Forms.Button buttonLoadTarget;
        private System.Windows.Forms.Button buttonLoadSource;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveProject;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveOldVersion;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.RichTextBox richTextBoxAnalysis;
    }
}

