namespace AIMA.CSharp.GUI.VacuumCleaner
{
    partial class frmVacuumCleanerMain
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            crtlTestControl1 = new crtlTestControl();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(crtlTestControl1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 387);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Demo Selection";
            // 
            // button2
            // 
            button2.Location = new Point(6, 71);
            button2.Name = "button2";
            button2.Size = new Size(243, 43);
            button2.TabIndex = 1;
            button2.Text = "Table Driven Vacuum Cleaner";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(243, 43);
            button1.TabIndex = 0;
            button1.Text = "Simple Reflex Vacuum Cleaner";
            button1.UseVisualStyleBackColor = true;
            // 
            // crtlTestControl1
            // 
            crtlTestControl1.Location = new Point(17, 134);
            crtlTestControl1.Name = "crtlTestControl1";
            crtlTestControl1.Size = new Size(94, 45);
            crtlTestControl1.TabIndex = 2;
            crtlTestControl1.Text = "crtlTestControl1";
            crtlTestControl1.UseVisualStyleBackColor = true;
            // 
            // frmVacuumCleanerMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 406);
            Controls.Add(groupBox1);
            Name = "frmVacuumCleanerMain";
            Text = "Vacuum Cleaner Main";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private crtlTestControl crtlTestControl1;
    }
}