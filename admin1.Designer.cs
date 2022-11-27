
namespace KeepingAccounts
{
    partial class admin1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看学生列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.队伍列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看队伍列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生列表ToolStripMenuItem,
            this.队伍列表ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生列表ToolStripMenuItem
            // 
            this.学生列表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看学生列表ToolStripMenuItem});
            this.学生列表ToolStripMenuItem.Name = "学生列表ToolStripMenuItem";
            this.学生列表ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学生列表ToolStripMenuItem.Text = "学生列表";
            // 
            // 查看学生列表ToolStripMenuItem
            // 
            this.查看学生列表ToolStripMenuItem.Name = "查看学生列表ToolStripMenuItem";
            this.查看学生列表ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查看学生列表ToolStripMenuItem.Text = "查看学生列表";
            this.查看学生列表ToolStripMenuItem.Click += new System.EventHandler(this.查看学生列表ToolStripMenuItem_Click);
            // 
            // 队伍列表ToolStripMenuItem
            // 
            this.队伍列表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看队伍列表ToolStripMenuItem});
            this.队伍列表ToolStripMenuItem.Name = "队伍列表ToolStripMenuItem";
            this.队伍列表ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.队伍列表ToolStripMenuItem.Text = "队伍列表";
            // 
            // 查看队伍列表ToolStripMenuItem
            // 
            this.查看队伍列表ToolStripMenuItem.Name = "查看队伍列表ToolStripMenuItem";
            this.查看队伍列表ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查看队伍列表ToolStripMenuItem.Text = "查看队伍列表";
            this.查看队伍列表ToolStripMenuItem.Click += new System.EventHandler(this.查看队伍列表ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(180, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎管理员登录";
            // 
            // admin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "admin1";
            this.Text = "管理员主页面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看学生列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 队伍列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看队伍列表ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
    }
}