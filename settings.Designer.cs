
namespace NetTXTEZ
{
    partial class settings
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
            this.t_maxtry = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.b_savesettings = new System.Windows.Forms.Button();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.tog_filewrite = new MetroFramework.Controls.MetroToggle();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // t_maxtry
            // 
            this.t_maxtry.BackColor = System.Drawing.Color.Transparent;
            this.t_maxtry.DownBack = null;
            this.t_maxtry.Icon = null;
            this.t_maxtry.IconIsButton = false;
            this.t_maxtry.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.t_maxtry.IsPasswordChat = '\0';
            this.t_maxtry.IsSystemPasswordChar = false;
            this.t_maxtry.Lines = new string[] {
        "5"};
            this.t_maxtry.Location = new System.Drawing.Point(153, 66);
            this.t_maxtry.Margin = new System.Windows.Forms.Padding(0);
            this.t_maxtry.MaxLength = 32767;
            this.t_maxtry.MinimumSize = new System.Drawing.Size(28, 28);
            this.t_maxtry.MouseBack = null;
            this.t_maxtry.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.t_maxtry.Multiline = false;
            this.t_maxtry.Name = "t_maxtry";
            this.t_maxtry.NormlBack = null;
            this.t_maxtry.Padding = new System.Windows.Forms.Padding(5);
            this.t_maxtry.ReadOnly = false;
            this.t_maxtry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t_maxtry.Size = new System.Drawing.Size(113, 28);
            // 
            // 
            // 
            this.t_maxtry.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_maxtry.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_maxtry.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.t_maxtry.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.t_maxtry.SkinTxt.Name = "BaseText";
            this.t_maxtry.SkinTxt.Size = new System.Drawing.Size(103, 18);
            this.t_maxtry.SkinTxt.TabIndex = 0;
            this.t_maxtry.SkinTxt.Text = "5";
            this.t_maxtry.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.t_maxtry.SkinTxt.WaterText = "";
            this.t_maxtry.TabIndex = 0;
            this.t_maxtry.Text = "5";
            this.t_maxtry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.t_maxtry.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.t_maxtry.WaterText = "";
            this.t_maxtry.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(36, 77);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(104, 17);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "错误最大尝试次数";
            // 
            // b_savesettings
            // 
            this.b_savesettings.Location = new System.Drawing.Point(39, 256);
            this.b_savesettings.Name = "b_savesettings";
            this.b_savesettings.Size = new System.Drawing.Size(227, 23);
            this.b_savesettings.TabIndex = 2;
            this.b_savesettings.Text = "保存";
            this.b_savesettings.UseVisualStyleBackColor = true;
            this.b_savesettings.Click += new System.EventHandler(this.b_savesettings_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(36, 139);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(80, 17);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "文件续写模式";
            // 
            // tog_filewrite
            // 
            this.tog_filewrite.Appearance = System.Windows.Forms.Appearance.Button;
            this.tog_filewrite.AutoSize = true;
            this.tog_filewrite.Location = new System.Drawing.Point(153, 134);
            this.tog_filewrite.Name = "tog_filewrite";
            this.tog_filewrite.Size = new System.Drawing.Size(80, 22);
            this.tog_filewrite.TabIndex = 3;
            this.tog_filewrite.Text = "Off";
            this.tog_filewrite.UseSelectable = true;
            this.tog_filewrite.CheckedChanged += new System.EventHandler(this.tog_filewrite_CheckedChanged);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(36, 156);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(80, 17);
            this.skinLabel3.TabIndex = 1;
            this.skinLabel3.Text = "文件续写模式";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 418);
            this.Controls.Add(this.tog_filewrite);
            this.Controls.Add(this.b_savesettings);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.t_maxtry);
            this.Name = "settings";
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox t_maxtry;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.Button b_savesettings;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private MetroFramework.Controls.MetroToggle tog_filewrite;
        private CCWin.SkinControl.SkinLabel skinLabel3;
    }
}