namespace IPageFollowing
{
    partial class Tasks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectedPostRange = new ns1.BunifuMetroTextbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SelectRange = new System.Windows.Forms.RadioButton();
            this.FullRange = new System.Windows.Forms.RadioButton();
            this.play_task = new ns1.BunifuFlatButton();
            this.slect_task = new ns1.BunifuDropdown();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CommentFILEContainer = new ns1.BunifuDropdown();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.PostContainer = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PageContainer = new ns1.BunifuDropdown();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.NumberOfPost = new ns1.BunifuMetroTextbox();
            this.UserContainer = new ns1.BunifuDropdown();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.PlayerCommenter = new ns1.BunifuImageButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DesplayDelay = new System.Windows.Forms.Label();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.delay_setting = new ns1.BunifuSlider();
            this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCommenter)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectedPostRange);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.play_task);
            this.groupBox1.Controls.Add(this.slect_task);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Player";
            // 
            // SelectedPostRange
            // 
            this.SelectedPostRange.BorderColorFocused = System.Drawing.Color.Blue;
            this.SelectedPostRange.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SelectedPostRange.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.SelectedPostRange.BorderThickness = 3;
            this.SelectedPostRange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SelectedPostRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SelectedPostRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SelectedPostRange.isPassword = false;
            this.SelectedPostRange.Location = new System.Drawing.Point(259, 68);
            this.SelectedPostRange.Margin = new System.Windows.Forms.Padding(4);
            this.SelectedPostRange.Name = "SelectedPostRange";
            this.SelectedPostRange.Size = new System.Drawing.Size(66, 44);
            this.SelectedPostRange.TabIndex = 1;
            this.SelectedPostRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectRange);
            this.groupBox2.Controls.Add(this.FullRange);
            this.groupBox2.Location = new System.Drawing.Point(59, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 45);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // SelectRange
            // 
            this.SelectRange.AutoSize = true;
            this.SelectRange.Location = new System.Drawing.Point(127, 15);
            this.SelectRange.Name = "SelectRange";
            this.SelectRange.Size = new System.Drawing.Size(57, 17);
            this.SelectRange.TabIndex = 12;
            this.SelectRange.Text = "Range";
            this.SelectRange.UseVisualStyleBackColor = true;
            this.SelectRange.CheckedChanged += new System.EventHandler(this.SelectRange_CheckedChanged);
            // 
            // FullRange
            // 
            this.FullRange.AutoSize = true;
            this.FullRange.Checked = true;
            this.FullRange.Location = new System.Drawing.Point(8, 15);
            this.FullRange.Name = "FullRange";
            this.FullRange.Size = new System.Drawing.Size(41, 17);
            this.FullRange.TabIndex = 11;
            this.FullRange.TabStop = true;
            this.FullRange.Text = "Full";
            this.FullRange.UseVisualStyleBackColor = true;
            this.FullRange.CheckedChanged += new System.EventHandler(this.FullRange_CheckedChanged);
            // 
            // play_task
            // 
            this.play_task.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.play_task.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.play_task.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play_task.BorderRadius = 0;
            this.play_task.ButtonText = "Play Task";
            this.play_task.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_task.DisabledColor = System.Drawing.Color.Gray;
            this.play_task.Iconcolor = System.Drawing.Color.Transparent;
            this.play_task.Iconimage = ((System.Drawing.Image)(resources.GetObject("play_task.Iconimage")));
            this.play_task.Iconimage_right = null;
            this.play_task.Iconimage_right_Selected = null;
            this.play_task.Iconimage_Selected = null;
            this.play_task.IconMarginLeft = 0;
            this.play_task.IconMarginRight = 0;
            this.play_task.IconRightVisible = true;
            this.play_task.IconRightZoom = 0D;
            this.play_task.IconVisible = true;
            this.play_task.IconZoom = 90D;
            this.play_task.IsTab = false;
            this.play_task.Location = new System.Drawing.Point(67, 130);
            this.play_task.Name = "play_task";
            this.play_task.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.play_task.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.play_task.OnHoverTextColor = System.Drawing.Color.White;
            this.play_task.selected = false;
            this.play_task.Size = new System.Drawing.Size(204, 39);
            this.play_task.TabIndex = 10;
            this.play_task.Text = "Play Task";
            this.play_task.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.play_task.Textcolor = System.Drawing.Color.White;
            this.play_task.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_task.Click += new System.EventHandler(this.play_task_Click);
            // 
            // slect_task
            // 
            this.slect_task.BackColor = System.Drawing.Color.Transparent;
            this.slect_task.BorderRadius = 3;
            this.slect_task.ForeColor = System.Drawing.Color.White;
            this.slect_task.Items = new string[0];
            this.slect_task.Location = new System.Drawing.Point(101, 19);
            this.slect_task.Name = "slect_task";
            this.slect_task.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.slect_task.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.slect_task.selectedIndex = -1;
            this.slect_task.Size = new System.Drawing.Size(224, 33);
            this.slect_task.TabIndex = 4;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(15, 28);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(64, 13);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Select Task";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CommentFILEContainer);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox3.Controls.Add(this.PostContainer);
            this.groupBox3.Controls.Add(this.PageContainer);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox3.Controls.Add(this.NumberOfPost);
            this.groupBox3.Controls.Add(this.UserContainer);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox3.Location = new System.Drawing.Point(376, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 261);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Posts Commenter";
            // 
            // CommentFILEContainer
            // 
            this.CommentFILEContainer.BackColor = System.Drawing.Color.Transparent;
            this.CommentFILEContainer.BorderRadius = 3;
            this.CommentFILEContainer.ForeColor = System.Drawing.Color.White;
            this.CommentFILEContainer.Items = new string[0];
            this.CommentFILEContainer.Location = new System.Drawing.Point(92, 221);
            this.CommentFILEContainer.Name = "CommentFILEContainer";
            this.CommentFILEContainer.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.CommentFILEContainer.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.CommentFILEContainer.selectedIndex = -1;
            this.CommentFILEContainer.Size = new System.Drawing.Size(224, 33);
            this.CommentFILEContainer.TabIndex = 14;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(6, 231);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(70, 13);
            this.bunifuCustomLabel5.TabIndex = 13;
            this.bunifuCustomLabel5.Text = "Comment File";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(6, 106);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel4.TabIndex = 12;
            this.bunifuCustomLabel4.Text = "Select Posts";
            // 
            // PostContainer
            // 
            this.PostContainer.ContextMenuStrip = this.contextMenuStrip1;
            this.PostContainer.FormattingEnabled = true;
            this.PostContainer.HorizontalScrollbar = true;
            this.PostContainer.Location = new System.Drawing.Point(92, 106);
            this.PostContainer.MultiColumn = true;
            this.PostContainer.Name = "PostContainer";
            this.PostContainer.ScrollAlwaysVisible = true;
            this.PostContainer.Size = new System.Drawing.Size(319, 109);
            this.PostContainer.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 48);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = global::IPageFollowing.Properties.Resources.click_bf589278d479;
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = global::IPageFollowing.Properties.Resources.delete_big;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // PageContainer
            // 
            this.PageContainer.BackColor = System.Drawing.Color.Transparent;
            this.PageContainer.BorderRadius = 3;
            this.PageContainer.ForeColor = System.Drawing.Color.White;
            this.PageContainer.Items = new string[0];
            this.PageContainer.Location = new System.Drawing.Point(92, 67);
            this.PageContainer.Name = "PageContainer";
            this.PageContainer.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.PageContainer.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.PageContainer.selectedIndex = -1;
            this.PageContainer.Size = new System.Drawing.Size(224, 33);
            this.PageContainer.TabIndex = 9;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(6, 76);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(65, 13);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Select Page";
            // 
            // NumberOfPost
            // 
            this.NumberOfPost.BorderColorFocused = System.Drawing.Color.Blue;
            this.NumberOfPost.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumberOfPost.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.NumberOfPost.BorderThickness = 3;
            this.NumberOfPost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberOfPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NumberOfPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumberOfPost.isPassword = false;
            this.NumberOfPost.Location = new System.Drawing.Point(345, 21);
            this.NumberOfPost.Margin = new System.Windows.Forms.Padding(4);
            this.NumberOfPost.Name = "NumberOfPost";
            this.NumberOfPost.Size = new System.Drawing.Size(66, 44);
            this.NumberOfPost.TabIndex = 5;
            this.NumberOfPost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserContainer
            // 
            this.UserContainer.BackColor = System.Drawing.Color.Transparent;
            this.UserContainer.BorderRadius = 3;
            this.UserContainer.ForeColor = System.Drawing.Color.White;
            this.UserContainer.Items = new string[0];
            this.UserContainer.Location = new System.Drawing.Point(92, 28);
            this.UserContainer.Name = "UserContainer";
            this.UserContainer.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.UserContainer.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.UserContainer.selectedIndex = -1;
            this.UserContainer.Size = new System.Drawing.Size(224, 33);
            this.UserContainer.TabIndex = 7;
            this.UserContainer.onItemSelected += new System.EventHandler(this.UserContainer_onItemSelected);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(6, 37);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(62, 13);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Select User";
            // 
            // PlayerCommenter
            // 
            this.PlayerCommenter.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCommenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayerCommenter.Image = ((System.Drawing.Image)(resources.GetObject("PlayerCommenter.Image")));
            this.PlayerCommenter.ImageActive = null;
            this.PlayerCommenter.Location = new System.Drawing.Point(738, 290);
            this.PlayerCommenter.Name = "PlayerCommenter";
            this.PlayerCommenter.Size = new System.Drawing.Size(59, 47);
            this.PlayerCommenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerCommenter.TabIndex = 11;
            this.PlayerCommenter.TabStop = false;
            this.PlayerCommenter.Zoom = 20;
            this.PlayerCommenter.Click += new System.EventHandler(this.PlayerCommenter_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DesplayDelay);
            this.groupBox4.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox4.Controls.Add(this.delay_setting);
            this.groupBox4.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox4.Location = new System.Drawing.Point(376, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 64);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delay Commenter";
            // 
            // DesplayDelay
            // 
            this.DesplayDelay.AutoSize = true;
            this.DesplayDelay.Location = new System.Drawing.Point(313, 29);
            this.DesplayDelay.Name = "DesplayDelay";
            this.DesplayDelay.Size = new System.Drawing.Size(13, 13);
            this.DesplayDelay.TabIndex = 10;
            this.DesplayDelay.Text = "2";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(57, 31);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(30, 13);
            this.bunifuCustomLabel6.TabIndex = 9;
            this.bunifuCustomLabel6.Text = "(Min)";
            // 
            // delay_setting
            // 
            this.delay_setting.BackColor = System.Drawing.Color.Transparent;
            this.delay_setting.BackgroudColor = System.Drawing.Color.DarkGray;
            this.delay_setting.BorderRadius = 0;
            this.delay_setting.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.delay_setting.Location = new System.Drawing.Point(110, 24);
            this.delay_setting.MaximumValue = 5;
            this.delay_setting.Name = "delay_setting";
            this.delay_setting.Size = new System.Drawing.Size(196, 30);
            this.delay_setting.TabIndex = 7;
            this.delay_setting.Value = 2;
            this.delay_setting.ValueChanged += new System.EventHandler(this.delay_setting_ValueChanged);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(24, 30);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(34, 13);
            this.bunifuCustomLabel7.TabIndex = 8;
            this.bunifuCustomLabel7.Text = "Delay";
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(838, 351);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.PlayerCommenter);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tasks";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.Tasks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCommenter)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ns1.BunifuDropdown slect_task;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuFlatButton play_task;
        private ns1.BunifuMetroTextbox SelectedPostRange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton SelectRange;
        private System.Windows.Forms.RadioButton FullRange;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox PostContainer;
        private ns1.BunifuDropdown PageContainer;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuMetroTextbox NumberOfPost;
        private ns1.BunifuDropdown UserContainer;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuDropdown CommentFILEContainer;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuImageButton PlayerCommenter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label DesplayDelay;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuSlider delay_setting;
        private ns1.BunifuCustomLabel bunifuCustomLabel7;
    }
}