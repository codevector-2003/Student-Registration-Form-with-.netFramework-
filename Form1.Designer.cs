namespace Vector_International
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vector International";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.passwordtxt);
            this.panel1.Controls.Add(this.usertxt);
            this.panel1.Controls.Add(this.loginbtn);
            this.panel1.Controls.Add(this.clearbtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(114, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 265);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(67, 204);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(122, 42);
            this.clearbtn.TabIndex = 3;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.SystemColors.Control;
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(311, 204);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(122, 42);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.exitbtn.Location = new System.Drawing.Point(12, 563);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(122, 39);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.TabStop = false;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.SystemColors.Info;
            this.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.Location = new System.Drawing.Point(182, 68);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(270, 34);
            this.usertxt.TabIndex = 0;
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.SystemColors.Info;
            this.passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(182, 125);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(270, 34);
            this.passwordtxt.TabIndex = 1;
            this.passwordtxt.TextChanged += new System.EventHandler(this.passwordtxt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vector_International.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(44, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 250);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(717, 614);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login- Vector International";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

