namespace ClassDemo
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.butMakeEmailAddress = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(133, 84);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(140, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // butMakeEmailAddress
            // 
            this.butMakeEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMakeEmailAddress.Location = new System.Drawing.Point(133, 129);
            this.butMakeEmailAddress.Name = "butMakeEmailAddress";
            this.butMakeEmailAddress.Size = new System.Drawing.Size(140, 37);
            this.butMakeEmailAddress.TabIndex = 1;
            this.butMakeEmailAddress.Text = "Make Email";
            this.butMakeEmailAddress.UseVisualStyleBackColor = true;
            this.butMakeEmailAddress.Click += new System.EventHandler(this.button1_Click);
            this.butMakeEmailAddress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butMakeEmailAddress_MouseClick);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(133, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.butMakeEmailAddress);
            this.Controls.Add(this.txtUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button butMakeEmailAddress;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

