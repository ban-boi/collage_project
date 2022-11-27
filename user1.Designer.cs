
namespace KeepingAccounts
{
    partial class user1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.创建队伍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加入已有队伍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的队伍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(121, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 75);
            this.label1.TabIndex = 2;
            this.label1.Text = "已登录组队记账系统";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建队伍ToolStripMenuItem,
            this.加入已有队伍ToolStripMenuItem,
            this.我的队伍ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 创建队伍ToolStripMenuItem
            // 
            this.创建队伍ToolStripMenuItem.Name = "创建队伍ToolStripMenuItem";
            this.创建队伍ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.创建队伍ToolStripMenuItem.Text = "创建队伍";
            this.创建队伍ToolStripMenuItem.Click += new System.EventHandler(this.创建队伍ToolStripMenuItem_Click);
            // 
            // 加入已有队伍ToolStripMenuItem
            // 
            this.加入已有队伍ToolStripMenuItem.Name = "加入已有队伍ToolStripMenuItem";
            this.加入已有队伍ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.加入已有队伍ToolStripMenuItem.Text = "加入已有队伍";
            this.加入已有队伍ToolStripMenuItem.Click += new System.EventHandler(this.加入已有队伍ToolStripMenuItem_Click);
            // 
            // 我的队伍ToolStripMenuItem
            // 
            this.我的队伍ToolStripMenuItem.Name = "我的队伍ToolStripMenuItem";
            this.我的队伍ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.我的队伍ToolStripMenuItem.Text = "我的队伍";
            this.我的队伍ToolStripMenuItem.Click += new System.EventHandler(this.我的队伍ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(183, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 75);
            this.label2.TabIndex = 4;
            this.label2.Text = "欢迎你";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(416, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 75);
            this.label3.TabIndex = 5;
            this.label3.Text = "NULL";
            // 
            // user1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "user1";
            this.Text = "用户使用界面";
            this.Load += new System.EventHandler(this.user1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 创建队伍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加入已有队伍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的队伍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}