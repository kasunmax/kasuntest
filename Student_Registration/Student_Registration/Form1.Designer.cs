namespace Student_Registration
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
            this.btnNew_Registration = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNew_Registration
            // 
            this.btnNew_Registration.Location = new System.Drawing.Point(86, 47);
            this.btnNew_Registration.Name = "btnNew_Registration";
            this.btnNew_Registration.Size = new System.Drawing.Size(112, 56);
            this.btnNew_Registration.TabIndex = 0;
            this.btnNew_Registration.Text = "New Registration";
            this.btnNew_Registration.UseVisualStyleBackColor = true;
            this.btnNew_Registration.Click += new System.EventHandler(this.btnNew_Registration_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(86, 147);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 48);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew_Registration);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew_Registration;
        private System.Windows.Forms.Button btnExit;
    }
}

