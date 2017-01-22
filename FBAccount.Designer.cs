namespace IPageFollowing
{
    partial class FBAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBAccount));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Email_text = new ns1.BunifuMetroTextbox();
            this.pass_text = new ns1.BunifuMetroTextbox();
            this.token_text = new ns1.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_btn = new ns1.BunifuFlatButton();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reg_btn);
            this.groupBox1.Controls.Add(this.token_text);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pass_text);
            this.groupBox1.Controls.Add(this.Email_text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // Email_text
            // 
            this.Email_text.BorderColorFocused = System.Drawing.Color.Blue;
            this.Email_text.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email_text.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Email_text.BorderThickness = 3;
            this.Email_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Email_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email_text.isPassword = false;
            this.Email_text.Location = new System.Drawing.Point(34, 33);
            this.Email_text.Margin = new System.Windows.Forms.Padding(4);
            this.Email_text.Name = "Email_text";
            this.Email_text.Size = new System.Drawing.Size(291, 37);
            this.Email_text.TabIndex = 2;
            this.Email_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pass_text
            // 
            this.pass_text.BorderColorFocused = System.Drawing.Color.Blue;
            this.pass_text.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pass_text.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.pass_text.BorderThickness = 3;
            this.pass_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pass_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pass_text.isPassword = true;
            this.pass_text.Location = new System.Drawing.Point(34, 95);
            this.pass_text.Margin = new System.Windows.Forms.Padding(4);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(291, 37);
            this.pass_text.TabIndex = 3;
            this.pass_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // token_text
            // 
            this.token_text.BorderColorFocused = System.Drawing.Color.Blue;
            this.token_text.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.token_text.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.token_text.BorderThickness = 3;
            this.token_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.token_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.token_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.token_text.isPassword = true;
            this.token_text.Location = new System.Drawing.Point(34, 154);
            this.token_text.Margin = new System.Windows.Forms.Padding(4);
            this.token_text.Name = "token_text";
            this.token_text.Size = new System.Drawing.Size(291, 37);
            this.token_text.TabIndex = 5;
            this.token_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Token";
            // 
            // reg_btn
            // 
            this.reg_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reg_btn.BackColor = System.Drawing.Color.Green;
            this.reg_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reg_btn.BorderRadius = 0;
            this.reg_btn.ButtonText = "Register New Account";
            this.reg_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg_btn.DisabledColor = System.Drawing.Color.Gray;
            this.reg_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.reg_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("reg_btn.Iconimage")));
            this.reg_btn.Iconimage_right = null;
            this.reg_btn.Iconimage_right_Selected = null;
            this.reg_btn.Iconimage_Selected = null;
            this.reg_btn.IconMarginLeft = 0;
            this.reg_btn.IconMarginRight = 0;
            this.reg_btn.IconRightVisible = true;
            this.reg_btn.IconRightZoom = 0D;
            this.reg_btn.IconVisible = true;
            this.reg_btn.IconZoom = 90D;
            this.reg_btn.IsTab = false;
            this.reg_btn.Location = new System.Drawing.Point(60, 202);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reg_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.reg_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.reg_btn.selected = false;
            this.reg_btn.Size = new System.Drawing.Size(241, 48);
            this.reg_btn.TabIndex = 6;
            this.reg_btn.Text = "Register New Account";
            this.reg_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reg_btn.Textcolor = System.Drawing.Color.White;
            this.reg_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 284);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(53, 44);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // FBAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 336);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FBAccount";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creat New Facebook Account";
            this.Load += new System.EventHandler(this.FBAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ns1.BunifuFlatButton reg_btn;
        private ns1.BunifuMetroTextbox token_text;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuMetroTextbox pass_text;
        private ns1.BunifuMetroTextbox Email_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuImageButton bunifuImageButton1;

    }
}