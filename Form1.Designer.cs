
namespace NetTXTEZ
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.t_input = new CCWin.SkinControl.SkinTextBox();
            this.t_first = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.b_opensettings = new System.Windows.Forms.Button();
            this.picbox = new CCWin.SkinControl.SkinPictureBox();
            this.t_output = new System.Windows.Forms.TextBox();
            this.b_stop = new System.Windows.Forms.Button();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(6, 150);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(276, 34);
            this.b_start.TabIndex = 3;
            this.b_start.Text = "开始";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "已获取";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(629, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "文本以线性的形式下载并写入，意味着写入的文本将会从起始章节一直写道最后章节（或手动停止，或直到遇到错误）";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(103, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 12);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "笔趣阁";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "本程序针对网站";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "进行开发，仅供学习研究，请勿用于非法或商业用途！";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "此处填入起始章节的链接";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "4小时速写，架构很拉，有时间优化";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(275, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(371, 14);
            this.label11.TabIndex = 4;
            this.label11.Text = "Copyright © 2021 PopcornBoom137 All rights reserved.";
            // 
            // t_input
            // 
            this.t_input.BackColor = System.Drawing.Color.Transparent;
            this.t_input.DownBack = null;
            this.t_input.Icon = null;
            this.t_input.IconIsButton = false;
            this.t_input.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.t_input.IsPasswordChat = '\0';
            this.t_input.IsSystemPasswordChar = false;
            this.t_input.Lines = new string[0];
            this.t_input.Location = new System.Drawing.Point(200, 87);
            this.t_input.Margin = new System.Windows.Forms.Padding(0);
            this.t_input.MaxLength = 32767;
            this.t_input.MinimumSize = new System.Drawing.Size(28, 28);
            this.t_input.MouseBack = null;
            this.t_input.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.t_input.Multiline = false;
            this.t_input.Name = "t_input";
            this.t_input.NormlBack = null;
            this.t_input.Padding = new System.Windows.Forms.Padding(5);
            this.t_input.ReadOnly = false;
            this.t_input.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t_input.Size = new System.Drawing.Size(82, 28);
            // 
            // 
            // 
            this.t_input.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_input.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_input.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.t_input.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.t_input.SkinTxt.Name = "BaseText";
            this.t_input.SkinTxt.Size = new System.Drawing.Size(72, 18);
            this.t_input.SkinTxt.TabIndex = 0;
            this.t_input.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.t_input.SkinTxt.WaterText = "";
            this.t_input.TabIndex = 1;
            this.t_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.t_input.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.t_input.WaterText = "";
            this.t_input.WordWrap = true;
            // 
            // t_first
            // 
            this.t_first.BackColor = System.Drawing.Color.Transparent;
            this.t_first.DownBack = null;
            this.t_first.Icon = null;
            this.t_first.IconIsButton = false;
            this.t_first.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.t_first.IsPasswordChat = '\0';
            this.t_first.IsSystemPasswordChar = false;
            this.t_first.Lines = new string[0];
            this.t_first.Location = new System.Drawing.Point(301, 87);
            this.t_first.Margin = new System.Windows.Forms.Padding(0);
            this.t_first.MaxLength = 32767;
            this.t_first.MinimumSize = new System.Drawing.Size(28, 28);
            this.t_first.MouseBack = null;
            this.t_first.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.t_first.Multiline = false;
            this.t_first.Name = "t_first";
            this.t_first.NormlBack = null;
            this.t_first.Padding = new System.Windows.Forms.Padding(5);
            this.t_first.ReadOnly = false;
            this.t_first.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t_first.Size = new System.Drawing.Size(82, 28);
            // 
            // 
            // 
            this.t_first.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_first.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_first.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.t_first.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.t_first.SkinTxt.Name = "BaseText";
            this.t_first.SkinTxt.Size = new System.Drawing.Size(72, 18);
            this.t_first.SkinTxt.TabIndex = 0;
            this.t_first.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.t_first.SkinTxt.WaterText = "";
            this.t_first.TabIndex = 2;
            this.t_first.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.t_first.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.t_first.WaterText = "";
            this.t_first.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(3, 94);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(194, 17);
            this.skinLabel1.TabIndex = 7;
            this.skinLabel1.Text = "https://www.extree.cn/xiaoshuo/";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(285, 94);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(13, 17);
            this.skinLabel2.TabIndex = 7;
            this.skinLabel2.Text = "/";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(386, 94);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(36, 17);
            this.skinLabel3.TabIndex = 7;
            this.skinLabel3.Text = ".html";
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Linen;
            this.skinPanel1.Controls.Add(this.label1);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.b_start);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.label9);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.label2);
            this.skinPanel1.Controls.Add(this.t_first);
            this.skinPanel1.Controls.Add(this.t_input);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(26, 120);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(446, 200);
            this.skinPanel1.TabIndex = 8;
            // 
            // b_opensettings
            // 
            this.b_opensettings.Location = new System.Drawing.Point(571, 12);
            this.b_opensettings.Name = "b_opensettings";
            this.b_opensettings.Size = new System.Drawing.Size(75, 23);
            this.b_opensettings.TabIndex = 5;
            this.b_opensettings.Text = "设置";
            this.b_opensettings.UseVisualStyleBackColor = true;
            this.b_opensettings.Click += new System.EventHandler(this.b_opensettings_Click);
            // 
            // picbox
            // 
            this.picbox.BackColor = System.Drawing.Color.Transparent;
            this.picbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox.BackgroundImage")));
            this.picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picbox.ErrorImage")));
            this.picbox.Location = new System.Drawing.Point(478, 120);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(150, 200);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 8;
            this.picbox.TabStop = false;
            // 
            // t_output
            // 
            this.t_output.Location = new System.Drawing.Point(26, 326);
            this.t_output.Name = "t_output";
            this.t_output.ReadOnly = true;
            this.t_output.Size = new System.Drawing.Size(602, 21);
            this.t_output.TabIndex = 0;
            this.t_output.TabStop = false;
            // 
            // b_stop
            // 
            this.b_stop.Location = new System.Drawing.Point(314, 270);
            this.b_stop.Name = "b_stop";
            this.b_stop.Size = new System.Drawing.Size(140, 34);
            this.b_stop.TabIndex = 4;
            this.b_stop.Text = "停止";
            this.b_stop.UseVisualStyleBackColor = true;
            this.b_stop.Click += new System.EventHandler(this.b_stop_Click);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.skinLabel4.Location = new System.Drawing.Point(197, 115);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(147, 17);
            this.skinLabel4.TabIndex = 7;
            this.skinLabel4.Text = "例如：97729   62326522";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 392);
            this.Controls.Add(this.t_output);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.b_stop);
            this.Controls.Add(this.b_opensettings);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(674, 431);
            this.MinimumSize = new System.Drawing.Size(674, 431);
            this.Name = "Form1";
            this.Text = "NetTXTEZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private CCWin.SkinControl.SkinTextBox t_input;
        private CCWin.SkinControl.SkinTextBox t_first;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private System.Windows.Forms.Button b_opensettings;
        private CCWin.SkinControl.SkinPictureBox picbox;
        private System.Windows.Forms.TextBox t_output;
        private System.Windows.Forms.Button b_stop;
        private CCWin.SkinControl.SkinLabel skinLabel4;
    }
}

