namespace ordering_system_app
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.labelpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.txtAbout = new System.Windows.Forms.Label();
            this.btnsignup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.labelpassword);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.labelusername);
            this.groupBox1.Location = new System.Drawing.Point(300, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 177);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SINGIN";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtpassword.Location = new System.Drawing.Point(120, 81);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 22);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnlogin.Location = new System.Drawing.Point(58, 120);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(137, 32);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "LogIn";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(38, 81);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(68, 16);
            this.labelpassword.TabIndex = 1;
            this.labelpassword.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtusername.Location = new System.Drawing.Point(120, 38);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 22);
            this.txtusername.TabIndex = 0;
            this.txtusername.Text = "Your Name";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(32, 38);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(74, 16);
            this.labelusername.TabIndex = 1;
            this.labelusername.Text = "UserName";
            // 
            // txtAbout
            // 
            this.txtAbout.AutoSize = true;
            this.txtAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbout.Location = new System.Drawing.Point(309, 270);
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(130, 16);
            this.txtAbout.TabIndex = 7;
            this.txtAbout.Text = "Don\'t have Account?";
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnsignup.Location = new System.Drawing.Point(445, 265);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(92, 27);
            this.btnsignup.TabIndex = 8;
            this.btnsignup.Text = "SignUp";
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 230);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(609, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAbout);
            this.Controls.Add(this.btnsignup);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label txtAbout;
        private System.Windows.Forms.Button btnsignup;
    }
}