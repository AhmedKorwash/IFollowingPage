namespace IPageFollowing
{
    partial class FacebookPages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookPages));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reg_btn = new ns1.BunifuFlatButton();
            this.id_link_text = new ns1.BunifuMetroTextbox();
            this.id_link_selector = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.page_link_select = new System.Windows.Forms.RadioButton();
            this.page_id_select = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reg_btn);
            this.groupBox1.Controls.Add(this.id_link_text);
            this.groupBox1.Controls.Add(this.id_link_selector);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // reg_btn
            // 
            this.reg_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reg_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reg_btn.BorderRadius = 0;
            this.reg_btn.ButtonText = "Save New Page";
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
            this.reg_btn.Location = new System.Drawing.Point(49, 132);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reg_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.reg_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.reg_btn.selected = false;
            this.reg_btn.Size = new System.Drawing.Size(241, 48);
            this.reg_btn.TabIndex = 7;
            this.reg_btn.Text = "Save New Page";
            this.reg_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reg_btn.Textcolor = System.Drawing.Color.White;
            this.reg_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // id_link_text
            // 
            this.id_link_text.BorderColorFocused = System.Drawing.Color.Blue;
            this.id_link_text.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id_link_text.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.id_link_text.BorderThickness = 3;
            this.id_link_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_link_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.id_link_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id_link_text.isPassword = false;
            this.id_link_text.Location = new System.Drawing.Point(24, 77);
            this.id_link_text.Margin = new System.Windows.Forms.Padding(4);
            this.id_link_text.Name = "id_link_text";
            this.id_link_text.Size = new System.Drawing.Size(291, 37);
            this.id_link_text.TabIndex = 4;
            this.id_link_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // id_link_selector
            // 
            this.id_link_selector.AutoSize = true;
            this.id_link_selector.Location = new System.Drawing.Point(26, 60);
            this.id_link_selector.Name = "id_link_selector";
            this.id_link_selector.Size = new System.Drawing.Size(18, 13);
            this.id_link_selector.TabIndex = 3;
            this.id_link_selector.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.page_link_select);
            this.groupBox2.Controls.Add(this.page_id_select);
            this.groupBox2.Location = new System.Drawing.Point(29, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 37);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // page_link_select
            // 
            this.page_link_select.AutoSize = true;
            this.page_link_select.Location = new System.Drawing.Point(216, 14);
            this.page_link_select.Name = "page_link_select";
            this.page_link_select.Size = new System.Drawing.Size(45, 17);
            this.page_link_select.TabIndex = 1;
            this.page_link_select.Text = "Link";
            this.page_link_select.UseVisualStyleBackColor = true;
            this.page_link_select.CheckedChanged += new System.EventHandler(this.page_link_select_CheckedChanged);
            // 
            // page_id_select
            // 
            this.page_id_select.AutoSize = true;
            this.page_id_select.Checked = true;
            this.page_id_select.Location = new System.Drawing.Point(6, 12);
            this.page_id_select.Name = "page_id_select";
            this.page_id_select.Size = new System.Drawing.Size(36, 17);
            this.page_id_select.TabIndex = 0;
            this.page_id_select.TabStop = true;
            this.page_id_select.Text = "ID";
            this.page_id_select.UseVisualStyleBackColor = true;
            this.page_id_select.CheckedChanged += new System.EventHandler(this.page_id_select_CheckedChanged);
            // 
            // FacebookPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 234);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacebookPages";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Pages";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton page_link_select;
        private System.Windows.Forms.RadioButton page_id_select;
        private ns1.BunifuMetroTextbox id_link_text;
        private System.Windows.Forms.Label id_link_selector;
        private ns1.BunifuFlatButton reg_btn;
    }
}