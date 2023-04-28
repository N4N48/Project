namespace Cinephile.Net
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
            this.LogIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.F1Next = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.AgeTB = new System.Windows.Forms.TextBox();
            this.MailTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(234, 267);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(83, 33);
            this.LogIn.TabIndex = 2;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-Mail:";
            // 
            // CreateAccount
            // 
            this.CreateAccount.Location = new System.Drawing.Point(378, 267);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(137, 33);
            this.CreateAccount.TabIndex = 7;
            this.CreateAccount.Text = "Create Account!";
            this.CreateAccount.UseVisualStyleBackColor = true;
            this.CreateAccount.Click += new System.EventHandler(this.button2_Click);
            // 
            // F1Next
            // 
            this.F1Next.Location = new System.Drawing.Point(705, 405);
            this.F1Next.Name = "F1Next";
            this.F1Next.Size = new System.Drawing.Size(83, 33);
            this.F1Next.TabIndex = 8;
            this.F1Next.Text = "Next";
            this.F1Next.UseVisualStyleBackColor = true;
            this.F1Next.Click += new System.EventHandler(this.button3_Click);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(364, 71);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(164, 22);
            this.NameTB.TabIndex = 9;
            // 
            // AgeTB
            // 
            this.AgeTB.Location = new System.Drawing.Point(364, 117);
            this.AgeTB.Name = "AgeTB";
            this.AgeTB.Size = new System.Drawing.Size(164, 22);
            this.AgeTB.TabIndex = 10;
            // 
            // MailTB
            // 
            this.MailTB.Location = new System.Drawing.Point(364, 169);
            this.MailTB.Name = "MailTB";
            this.MailTB.Size = new System.Drawing.Size(164, 22);
            this.MailTB.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password:";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(364, 217);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(164, 22);
            this.PasswordTB.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MailTB);
            this.Controls.Add(this.AgeTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.F1Next);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateAccount;
        private System.Windows.Forms.Button F1Next;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox AgeTB;
        private System.Windows.Forms.TextBox MailTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordTB;
    }
}

