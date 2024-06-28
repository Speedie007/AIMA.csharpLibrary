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
            btnStartStepping = new Button();
            btnStopStepping = new Button();
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
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            groupBoxEvnironmentOptions.SuspendLayout();
            groupBox2.SuspendLayout();
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
            splitContainer2.SplitterDistance = 337;
            // 
            // gbVacuumCleanerEnviromentView
            // 
            gbVacuumCleanerEnviromentView.Size = new Size(797, 578);
            // 
            // txtOne
            // 
            txtOne.Size = new Size(252, 215);
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
            // groupBoxEvnironmentOptions
            // 
            groupBoxEvnironmentOptions.Controls.Add(btnStopStepping);
            groupBoxEvnironmentOptions.Controls.Add(btnStartStepping);
            groupBoxEvnironmentOptions.Size = new Size(791, 70);
            // 
            // gbVacuumCleanerEnvironmentView
            // 
            gbVacuumCleanerEnvironmentView.Size = new Size(791, 482);
            // 
            // groupBox2
            // 
            groupBox2.Size = new Size(258, 337);
            // 
            // txtPerformanceMeasure
            // 
            txtPerformanceMeasure.Size = new Size(252, 315);
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
            // btnStartStepping
            // 
            btnStartStepping.Location = new Point(19, 22);
            btnStartStepping.Name = "btnStartStepping";
            btnStartStepping.Size = new Size(139, 37);
            btnStartStepping.TabIndex = 0;
            btnStartStepping.Text = "Step Continuously";
            btnStartStepping.UseVisualStyleBackColor = true;
            btnStartStepping.Click += btnStartStepping_Click;
            // 
            // btnStopStepping
            // 
            btnStopStepping.Location = new Point(164, 22);
            btnStopStepping.Name = "btnStopStepping";
            btnStopStepping.Size = new Size(113, 37);
            btnStopStepping.TabIndex = 1;
            btnStopStepping.Text = "Stop";
            btnStopStepping.UseVisualStyleBackColor = true;
            btnStopStepping.Click += btnStopStepping_Click;
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
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            gbVacuumCleanerEnviromentView.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            groupBoxEvnironmentOptions.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnStopStepping;
        private Button btnStartStepping;
    }
}