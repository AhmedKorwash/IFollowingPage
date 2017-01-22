namespace IPageFollowing
{
    partial class EditeFBAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditeFBAccount));
            this.list_of_accounts = new ns1.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reg_btn = new ns1.BunifuFlatButton();
            this.token_text = new ns1.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.pass_text = new ns1.BunifuMetroTextbox();
            this.Email_text = new ns1.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.list_of_pages = new ns1.BunifuDropdown();
            this.setPageOwner = new ns1.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.list_of_accounts_to_page = new ns1.BunifuDropdown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_of_accounts
            // 
            this.list_of_accounts.BackColor = System.Drawing.Color.Transparent;
            this.list_of_accounts.BorderRadius = 3;
            this.list_of_accounts.ForeColor = System.Drawing.Color.White;
            this.list_of_accounts.Items = new string[0];
            this.list_of_accounts.Location = new System.Drawing.Point(107, 18);
            this.list_of_accounts.Name = "list_of_accounts";
            this.list_of_accounts.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.list_of_accounts.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.list_of_accounts.selectedIndex = -1;
            this.list_of_accounts.Size = new System.Drawing.Size(254, 35);
            this.list_of_accounts.TabIndex = 0;
            this.list_of_accounts.onItemSelected += new System.EventHandler(this.list_of_accounts_onItemSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Account";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reg_btn);
            this.groupBox1.Controls.Add(this.token_text);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pass_text);
            this.groupBox1.Controls.Add(this.Email_text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 266);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // reg_btn
            // 
            this.reg_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reg_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reg_btn.BorderRadius = 0;
            this.reg_btn.ButtonText = "Update Facebook Account";
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
            this.reg_btn.Text = "Update Facebook Account";
            this.reg_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reg_btn.Textcolor = System.Drawing.Color.White;
            this.reg_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // token_text
            // 
            this.token_text.BorderColorFocused = System.Drawing.Color.DarkOliveGreen;
            this.token_text.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.token_text.BorderColorMouseHover = System.Drawing.Color.CadetBlue;
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
            // pass_text
            // 
            this.pass_text.BorderColorFocused = System.Drawing.Color.DarkOliveGreen;
            this.pass_text.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pass_text.BorderColorMouseHover = System.Drawing.Color.CadetBlue;
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
            // Email_text
            // 
            this.Email_text.BorderColorFocused = System.Drawing.Color.DarkOliveGreen;
            this.Email_text.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email_text.BorderColorMouseHover = System.Drawing.Color.CadetBlue;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.list_of_accounts);
            this.groupBox2.Location = new System.Drawing.Point(10, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 346);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edite Facebook Account";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.list_of_accounts_to_page);
            this.groupBox3.Location = new System.Drawing.Point(400, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 231);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edite Page";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.list_of_pages);
            this.groupBox4.Controls.Add(this.setPageOwner);
            this.groupBox4.Location = new System.Drawing.Point(13, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 150);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select Page";
            // 
            // list_of_pages
            // 
            this.list_of_pages.BackColor = System.Drawing.Color.Transparent;
            this.list_of_pages.BorderRadius = 3;
            this.list_of_pages.ForeColor = System.Drawing.Color.White;
            this.list_of_pages.Items = new string[0];
            this.list_of_pages.Location = new System.Drawing.Point(94, 19);
            this.list_of_pages.Name = "list_of_pages";
            this.list_of_pages.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.list_of_pages.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.list_of_pages.selectedIndex = -1;
            this.list_of_pages.Size = new System.Drawing.Size(249, 35);
            this.list_of_pages.TabIndex = 7;
            this.list_of_pages.onItemSelected += new System.EventHandler(this.list_of_pages_onItemSelected);
            // 
            // setPageOwner
            // 
            this.setPageOwner.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.setPageOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.setPageOwner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setPageOwner.BorderRadius = 0;
            this.setPageOwner.ButtonText = "Update Facebook Account";
            this.setPageOwner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setPageOwner.DisabledColor = System.Drawing.Color.Gray;
            this.setPageOwner.Iconcolor = System.Drawing.Color.Transparent;
            this.setPageOwner.Iconimage = ((System.Drawing.Image)(resources.GetObject("setPageOwner.Iconimage")));
            this.setPageOwner.Iconimage_right = null;
            this.setPageOwner.Iconimage_right_Selected = null;
            this.setPageOwner.Iconimage_Selected = null;
            this.setPageOwner.IconMarginLeft = 0;
            this.setPageOwner.IconMarginRight = 0;
            this.setPageOwner.IconRightVisible = true;
            this.setPageOwner.IconRightZoom = 0D;
            this.setPageOwner.IconVisible = true;
            this.setPageOwner.IconZoom = 90D;
            this.setPageOwner.IsTab = false;
            this.setPageOwner.Location = new System.Drawing.Point(68, 78);
            this.setPageOwner.Name = "setPageOwner";
            this.setPageOwner.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.setPageOwner.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.setPageOwner.OnHoverTextColor = System.Drawing.Color.White;
            this.setPageOwner.selected = false;
            this.setPageOwner.Size = new System.Drawing.Size(241, 48);
            this.setPageOwner.TabIndex = 6;
            this.setPageOwner.Text = "Update Facebook Account";
            this.setPageOwner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setPageOwner.Textcolor = System.Drawing.Color.White;
            this.setPageOwner.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPageOwner.Click += new System.EventHandler(this.setPageOwner_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Select Account";
            // 
            // list_of_accounts_to_page
            // 
            this.list_of_accounts_to_page.BackColor = System.Drawing.Color.Transparent;
            this.list_of_accounts_to_page.BorderRadius = 3;
            this.list_of_accounts_to_page.ForeColor = System.Drawing.Color.White;
            this.list_of_accounts_to_page.Items = new string[0];
            this.list_of_accounts_to_page.Location = new System.Drawing.Point(107, 18);
            this.list_of_accounts_to_page.Name = "list_of_accounts_to_page";
            this.list_of_accounts_to_page.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.list_of_accounts_to_page.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.list_of_accounts_to_page.selectedIndex = -1;
            this.list_of_accounts_to_page.Size = new System.Drawing.Size(249, 35);
            this.list_of_accounts_to_page.TabIndex = 0;
            this.list_of_accounts_to_page.onItemSelected += new System.EventHandler(this.list_of_accounts_to_page_onItemSelected);
            // 
            // EditeFBAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 364);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditeFBAccount";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edite System";
            this.Load += new System.EventHandler(this.EditeFBAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuDropdown list_of_accounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ns1.BunifuFlatButton reg_btn;
        private ns1.BunifuMetroTextbox token_text;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuMetroTextbox pass_text;
        private ns1.BunifuMetroTextbox Email_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private ns1.BunifuFlatButton setPageOwner;
        private System.Windows.Forms.Label label8;
        private ns1.BunifuDropdown list_of_accounts_to_page;
        private System.Windows.Forms.Label label5;
        private ns1.BunifuDropdown list_of_pages;
    }
}