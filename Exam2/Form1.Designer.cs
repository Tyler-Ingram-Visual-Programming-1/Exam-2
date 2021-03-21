namespace Exam2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patientListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.displayPatientStatusButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AVG Systolic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AVG Diastolic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "STATUS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Physician";
            // 
            // patientListBox
            // 
            this.patientListBox.FormattingEnabled = true;
            this.patientListBox.Location = new System.Drawing.Point(15, 87);
            this.patientListBox.Name = "patientListBox";
            this.patientListBox.Size = new System.Drawing.Size(435, 95);
            this.patientListBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(141, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Blood Pressure Monitor";
            // 
            // displayPatientStatusButton
            // 
            this.displayPatientStatusButton.Location = new System.Drawing.Point(15, 237);
            this.displayPatientStatusButton.Name = "displayPatientStatusButton";
            this.displayPatientStatusButton.Size = new System.Drawing.Size(86, 47);
            this.displayPatientStatusButton.TabIndex = 7;
            this.displayPatientStatusButton.Text = "DISPLAY PATIENT STATUS";
            this.displayPatientStatusButton.UseVisualStyleBackColor = true;
            this.displayPatientStatusButton.Click += new System.EventHandler(this.displayPatientStatusButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(184, 237);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(79, 47);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "CLEAR MONITOR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(358, 237);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 47);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "EXIT SYSTEM";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 290);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.displayPatientStatusButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.patientListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox patientListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button displayPatientStatusButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}