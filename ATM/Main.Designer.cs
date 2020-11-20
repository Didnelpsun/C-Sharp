
namespace ATM
{
    partial class Main
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

        # region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.login = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelPsw = new System.Windows.Forms.Label();
            this.textBoxPsw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.White;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.Location = new System.Drawing.Point(209, 227);
            this.login.Margin = new System.Windows.Forms.Padding(0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(171, 43);
            this.login.TabIndex = 0;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUser.Location = new System.Drawing.Point(124, 70);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(69, 19);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "用户名";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxUser.Location = new System.Drawing.Point(199, 67);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(229, 29);
            this.textBoxUser.TabIndex = 2;
            // 
            // labelPsw
            // 
            this.labelPsw.AutoSize = true;
            this.labelPsw.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPsw.Location = new System.Drawing.Point(133, 151);
            this.labelPsw.Name = "labelPsw";
            this.labelPsw.Size = new System.Drawing.Size(49, 19);
            this.labelPsw.TabIndex = 3;
            this.labelPsw.Text = "密码";
            // 
            // textBoxPsw
            // 
            this.textBoxPsw.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPsw.Location = new System.Drawing.Point(199, 148);
            this.textBoxPsw.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPsw.Name = "textBoxPsw";
            this.textBoxPsw.Size = new System.Drawing.Size(229, 29);
            this.textBoxPsw.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.textBoxPsw);
            this.Controls.Add(this.labelPsw);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自助存取款系统";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelPsw;
        private System.Windows.Forms.TextBox textBoxPsw;
    }
}

