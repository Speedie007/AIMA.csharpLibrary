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
            lbltest = new Label();
            btnTestBtn = new Button();
            txtOne = new TextBox();
            gbVacuumCleanerEnviromentView = new GroupBox();
            splitContainer1 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)mainLayoutSplitContainer).BeginInit();
            mainLayoutSplitContainer.Panel1.SuspendLayout();
            mainLayoutSplitContainer.Panel2.SuspendLayout();
            mainLayoutSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            gbVacuumCleanerEnviromentView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.SuspendLayout();
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
            splitContainer2.Panel1.Controls.Add(lbltest);
            splitContainer2.Panel1.Controls.Add(btnTestBtn);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(txtOne);
            splitContainer2.Size = new Size(250, 450);
            splitContainer2.SplitterDistance = 83;
            splitContainer2.TabIndex = 0;
            // 
            // lbltest
            // 
            lbltest.AutoSize = true;
            lbltest.Location = new Point(179, 34);
            lbltest.Name = "lbltest";
            lbltest.Size = new Size(38, 15);
            lbltest.TabIndex = 1;
            lbltest.Text = "label1";
            // 
            // btnTestBtn
            // 
            btnTestBtn.Location = new Point(73, 24);
            btnTestBtn.Name = "btnTestBtn";
            btnTestBtn.Size = new Size(75, 23);
            btnTestBtn.TabIndex = 0;
            btnTestBtn.Text = "button1";
            btnTestBtn.UseVisualStyleBackColor = true;
            btnTestBtn.Click += btnTestBtn_Click;
            // 
            // txtOne
            // 
            txtOne.Dock = DockStyle.Fill;
            txtOne.Location = new Point(0, 0);
            txtOne.Multiline = true;
            txtOne.Name = "txtOne";
            txtOne.Size = new Size(250, 363);
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
            gbVacuumCleanerEnviromentView.Text = "Default Enviroment View";
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
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 19);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            splitContainer3.Size = new Size(540, 428);
            splitContainer3.SplitterDistance = 84;
            splitContainer3.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainLayoutSplitContainer);
            Name = "BaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BaseForm";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += BaseForm_Load;
            mainLayoutSplitContainer.Panel1.ResumeLayout(false);
            mainLayoutSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainLayoutSplitContainer).EndInit();
            mainLayoutSplitContainer.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            gbVacuumCleanerEnviromentView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public SplitContainer mainLayoutSplitContainer;
        public SplitContainer splitContainer1;
       
        public SplitContainer splitContainer2;
        public GroupBox gbVacuumCleanerEnviromentView;
        public Button btnTestBtn;
        public Label lbltest;
        public TextBox txtOne;
        private SplitContainer splitContainer3;
        private ContextMenuStrip contextMenuStrip1;
    }
}