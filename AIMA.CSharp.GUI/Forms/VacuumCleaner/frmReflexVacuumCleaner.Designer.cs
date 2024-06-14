namespace AIMA.CSharp.GUI.Forms.VacuumCleaner
{
    partial class frmReflexVacuumCleaner
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
            ((System.ComponentModel.ISupportInitialize)mainLayoutSplitContainer).BeginInit();
            mainLayoutSplitContainer.Panel1.SuspendLayout();
            mainLayoutSplitContainer.Panel2.SuspendLayout();
            mainLayoutSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayoutSplitContainer
            // 
            mainLayoutSplitContainer.Size = new Size(1059, 578);
            mainLayoutSplitContainer.SplitterDistance = 330;
            // 
            // splitContainer2
            // 
            splitContainer2.Size = new Size(330, 578);
            splitContainer2.SplitterDistance = 286;
            // 
            // gbVacuumCleanerEnviromentView
            // 
            gbVacuumCleanerEnviromentView.Size = new Size(725, 578);
            // 
            // txtOne
            // 
            txtOne.Size = new Size(330, 288);
            // 
            // frmReflexVacuumCleaner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 578);
            Name = "frmReflexVacuumCleaner";
            Text = "frmReflexVacuumCleaner";
            Load += frmReflexVacuumCleaner_Load;
            Shown += frmReflexVacuumCleaner_Shown;
            mainLayoutSplitContainer.Panel1.ResumeLayout(false);
            mainLayoutSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainLayoutSplitContainer).EndInit();
            mainLayoutSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}