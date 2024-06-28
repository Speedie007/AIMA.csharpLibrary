namespace AIMA.CSharp.GUI.Forms.Base
{
    partial class BaseForm
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
            components = new System.ComponentModel.Container();
            mainLayoutSplitContainer = new SplitContainer();
            splitContainer2 = new SplitContainer();
            groupBox1 = new GroupBox();
            txtOne = new TextBox();
            gbVacuumCleanerEnviromentView = new GroupBox();
            splitContainer3 = new SplitContainer();
            groupBoxEvnironmentOptions = new GroupBox();
            gbVacuumCleanerEnvironmentView = new GroupBox();
            splitContainer1 = new SplitContainer();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox2 = new GroupBox();
            txtPerformanceMeasure = new TextBox();
            ((System.ComponentModel.ISupportInitialize)mainLayoutSplitContainer).BeginInit();
            mainLayoutSplitContainer.Panel1.SuspendLayout();
            mainLayoutSplitContainer.Panel2.SuspendLayout();
            mainLayoutSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox1.SuspendLayout();
            gbVacuumCleanerEnviromentView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayoutSplitContainer
            // 
            mainLayoutSplitContainer.Dock = DockStyle.Fill;
            mainLayoutSplitContainer.Location = new Point(0, 0);
            mainLayoutSplitContainer.Name = "mainLayoutSplitContainer";
            // 
            // mainLayoutSplitContainer.Panel1
            // 
            mainLayoutSplitContainer.Panel1.Controls.Add(splitContainer2);
            mainLayoutSplitContainer.Panel1MinSize = 250;
            // 
            // mainLayoutSplitContainer.Panel2
            // 
            mainLayoutSplitContainer.Panel2.Controls.Add(gbVacuumCleanerEnviromentView);
            mainLayoutSplitContainer.Size = new Size(800, 450);
            mainLayoutSplitContainer.SplitterDistance = 250;
            mainLayoutSplitContainer.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(groupBox1);
            splitContainer2.Size = new Size(250, 450);
            splitContainer2.SplitterDistance = 83;
            splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtOne);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 363);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "AgentEnviroment Feed-Back";
            // 
            // txtOne
            // 
            txtOne.Dock = DockStyle.Fill;
            txtOne.Location = new Point(3, 19);
            txtOne.Margin = new Padding(5);
            txtOne.Multiline = true;
            txtOne.Name = "txtOne";
            txtOne.Size = new Size(244, 341);
            txtOne.TabIndex = 2;
            // 
            // gbVacuumCleanerEnviromentView
            // 
            gbVacuumCleanerEnviromentView.Controls.Add(splitContainer3);
            gbVacuumCleanerEnviromentView.Dock = DockStyle.Fill;
            gbVacuumCleanerEnviromentView.Location = new Point(0, 0);
            gbVacuumCleanerEnviromentView.Name = "gbVacuumCleanerEnviromentView";
            gbVacuumCleanerEnviromentView.Size = new Size(546, 450);
            gbVacuumCleanerEnviromentView.TabIndex = 0;
            gbVacuumCleanerEnviromentView.TabStop = false;
            gbVacuumCleanerEnviromentView.Text = "Default AgentEnviroment View";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 19);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(groupBoxEvnironmentOptions);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(gbVacuumCleanerEnvironmentView);
            splitContainer3.Size = new Size(540, 428);
            splitContainer3.SplitterDistance = 66;
            splitContainer3.TabIndex = 0;
            // 
            // groupBoxEvnironmentOptions
            // 
            groupBoxEvnironmentOptions.Dock = DockStyle.Fill;
            groupBoxEvnironmentOptions.Location = new Point(0, 0);
            groupBoxEvnironmentOptions.Name = "groupBoxEvnironmentOptions";
            groupBoxEvnironmentOptions.Size = new Size(540, 66);
            groupBoxEvnironmentOptions.TabIndex = 0;
            groupBoxEvnironmentOptions.TabStop = false;
            groupBoxEvnironmentOptions.Text = "Agent Environment Configuration Options";
            // 
            // gbVacuumCleanerEnvironmentView
            // 
            gbVacuumCleanerEnvironmentView.Dock = DockStyle.Fill;
            gbVacuumCleanerEnvironmentView.Location = new Point(0, 0);
            gbVacuumCleanerEnvironmentView.Name = "gbVacuumCleanerEnvironmentView";
            gbVacuumCleanerEnvironmentView.Size = new Size(540, 358);
            gbVacuumCleanerEnvironmentView.TabIndex = 0;
            gbVacuumCleanerEnvironmentView.TabStop = false;
            gbVacuumCleanerEnvironmentView.Text = "Vacuum Cleaner Environment View";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            splitContainer1.Size = new Size(250, 450);
            splitContainer1.SplitterDistance = 114;
            splitContainer1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPerformanceMeasure);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 83);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agent Performance Measures";
            // 
            // txtPerformanceMeasure
            // 
            txtPerformanceMeasure.Dock = DockStyle.Fill;
            txtPerformanceMeasure.Location = new Point(3, 19);
            txtPerformanceMeasure.Multiline = true;
            txtPerformanceMeasure.Name = "txtPerformanceMeasure";
            txtPerformanceMeasure.Size = new Size(244, 61);
            txtPerformanceMeasure.TabIndex = 0;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainLayoutSplitContainer);
            Name = "BaseForm";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "BaseForm";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += BaseForm_Load;
            mainLayoutSplitContainer.Panel1.ResumeLayout(false);
            mainLayoutSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainLayoutSplitContainer).EndInit();
            mainLayoutSplitContainer.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbVacuumCleanerEnviromentView.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        public SplitContainer mainLayoutSplitContainer;
        /// <summary>
        /// 
        /// </summary>
        public SplitContainer splitContainer1;
       /// <summary>
       /// 
       /// </summary>
        public SplitContainer splitContainer2;
        /// <summary>
        /// 
        /// </summary>
        public GroupBox gbVacuumCleanerEnviromentView;
        /// <summary>
        /// 
        /// </summary>
        public TextBox txtOne;
        /// <summary>
        /// 
        /// </summary>
        public SplitContainer splitContainer3;
        /// <summary>
        /// 
        /// </summary>
        public ContextMenuStrip contextMenuStrip1;
        /// <summary>
        /// 
        /// </summary>
        private GroupBox groupBox1;
        /// <summary>
        /// 
        /// </summary>
        public GroupBox groupBoxEvnironmentOptions;
        public GroupBox gbVacuumCleanerEnvironmentView;
        public GroupBox groupBox2;
        public TextBox txtPerformanceMeasure;
    }
}