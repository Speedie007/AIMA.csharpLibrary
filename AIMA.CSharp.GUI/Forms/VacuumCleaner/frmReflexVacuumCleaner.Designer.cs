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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)mainLayoutSplitContainer).BeginInit();
            mainLayoutSplitContainer.Panel1.SuspendLayout();
            mainLayoutSplitContainer.Panel2.SuspendLayout();
            mainLayoutSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            gbVacuumCleanerEnviromentView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.SuspendLayout();
            groupBoxEvniromentOptions.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayoutSplitContainer
            // 
            mainLayoutSplitContainer.Size = new Size(1059, 578);
            mainLayoutSplitContainer.SplitterDistance = 258;
            // 
            // splitContainer2
            // 
            splitContainer2.Size = new Size(258, 578);
            splitContainer2.SplitterDistance = 160;
            // 
            // gbVacuumCleanerEnvironmentView
            // 
            gbVacuumCleanerEnviromentView.Size = new Size(797, 578);
            // 
            // txtOne
            // 
            txtOne.Size = new Size(252, 392);
            // 
            // splitContainer3
            // 
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(button1);
            splitContainer3.Size = new Size(791, 556);
            splitContainer3.SplitterDistance = 70;
            // 
            // groupBoxEnvironmentOptions
            // 
            groupBoxEvniromentOptions.Controls.Add(button3);
            groupBoxEvniromentOptions.Controls.Add(button2);
            groupBoxEvniromentOptions.Size = new Size(791, 70);
            // 
            // button1
            // 
            button1.Location = new Point(19, 15);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(44, 31);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(149, 37);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
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
            Controls.SetChildIndex(mainLayoutSplitContainer, 0);
            mainLayoutSplitContainer.Panel1.ResumeLayout(false);
            mainLayoutSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainLayoutSplitContainer).EndInit();
            mainLayoutSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            gbVacuumCleanerEnviromentView.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            groupBoxEvniromentOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}