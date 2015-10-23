namespace Puzzle
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.迷宫设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拆墙ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.筑墙ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.随机拆墙ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.完全修复toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.施工结束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.算法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.广度优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.深度优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.迭代加深ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最优优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.设为起点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设为终点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.迷宫设置ToolStripMenuItem,
            this.功能ToolStripMenuItem,
            this.算法ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 迷宫设置ToolStripMenuItem
            // 
            this.迷宫设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.设置ToolStripMenuItem});
            this.迷宫设置ToolStripMenuItem.Name = "迷宫设置ToolStripMenuItem";
            this.迷宫设置ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.迷宫设置ToolStripMenuItem.Text = "迷宫设置";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 功能ToolStripMenuItem
            // 
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.拆墙ToolStripMenuItem,
            this.筑墙ToolStripMenuItem,
            this.随机拆墙ToolStripMenuItem,
            this.完全修复toolStripMenuItem1,
            this.施工结束ToolStripMenuItem});
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.功能ToolStripMenuItem.Text = "功能";
            // 
            // 拆墙ToolStripMenuItem
            // 
            this.拆墙ToolStripMenuItem.Name = "拆墙ToolStripMenuItem";
            this.拆墙ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.拆墙ToolStripMenuItem.Text = "拆墙";
            this.拆墙ToolStripMenuItem.Click += new System.EventHandler(this.拆墙ToolStripMenuItem_Click_1);
            // 
            // 筑墙ToolStripMenuItem
            // 
            this.筑墙ToolStripMenuItem.Name = "筑墙ToolStripMenuItem";
            this.筑墙ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.筑墙ToolStripMenuItem.Text = "筑墙";
            this.筑墙ToolStripMenuItem.Click += new System.EventHandler(this.筑墙ToolStripMenuItem_Click);
            // 
            // 随机拆墙ToolStripMenuItem
            // 
            this.随机拆墙ToolStripMenuItem.Name = "随机拆墙ToolStripMenuItem";
            this.随机拆墙ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.随机拆墙ToolStripMenuItem.Text = "随机拆墙";
            this.随机拆墙ToolStripMenuItem.Click += new System.EventHandler(this.随机拆墙ToolStripMenuItem_Click);
            // 
            // 完全修复toolStripMenuItem1
            // 
            this.完全修复toolStripMenuItem1.Name = "完全修复toolStripMenuItem1";
            this.完全修复toolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.完全修复toolStripMenuItem1.Text = "完全修复";
            this.完全修复toolStripMenuItem1.Click += new System.EventHandler(this.完全修复toolStripMenuItem1_Click);
            // 
            // 施工结束ToolStripMenuItem
            // 
            this.施工结束ToolStripMenuItem.Name = "施工结束ToolStripMenuItem";
            this.施工结束ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.施工结束ToolStripMenuItem.Text = "施工结束";
            this.施工结束ToolStripMenuItem.Click += new System.EventHandler(this.施工结束ToolStripMenuItem_Click);
            // 
            // 算法ToolStripMenuItem
            // 
            this.算法ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.广度优先ToolStripMenuItem,
            this.toolStripTextBox2,
            this.深度优先ToolStripMenuItem,
            this.迭代加深ToolStripMenuItem,
            this.最优优先ToolStripMenuItem,
            this.iDAToolStripMenuItem});
            this.算法ToolStripMenuItem.Name = "算法ToolStripMenuItem";
            this.算法ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.算法ToolStripMenuItem.Text = "算法";
            // 
            // 广度优先ToolStripMenuItem
            // 
            this.广度优先ToolStripMenuItem.Name = "广度优先ToolStripMenuItem";
            this.广度优先ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.广度优先ToolStripMenuItem.Text = "广度优先";
            this.广度优先ToolStripMenuItem.Click += new System.EventHandler(this.广度优先ToolStripMenuItem_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox2_TextChanged);
            // 
            // 深度优先ToolStripMenuItem
            // 
            this.深度优先ToolStripMenuItem.Name = "深度优先ToolStripMenuItem";
            this.深度优先ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.深度优先ToolStripMenuItem.Text = "深度优先";
            this.深度优先ToolStripMenuItem.Click += new System.EventHandler(this.深度优先ToolStripMenuItem_Click);
            // 
            // 迭代加深ToolStripMenuItem
            // 
            this.迭代加深ToolStripMenuItem.Name = "迭代加深ToolStripMenuItem";
            this.迭代加深ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.迭代加深ToolStripMenuItem.Text = "迭代加深";
            // 
            // 最优优先ToolStripMenuItem
            // 
            this.最优优先ToolStripMenuItem.Name = "最优优先ToolStripMenuItem";
            this.最优优先ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.最优优先ToolStripMenuItem.Text = "最优优先";
            // 
            // iDAToolStripMenuItem
            // 
            this.iDAToolStripMenuItem.Name = "iDAToolStripMenuItem";
            this.iDAToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.iDAToolStripMenuItem.Text = "IDA*";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 602);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(871, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设为起点ToolStripMenuItem,
            this.设为终点ToolStripMenuItem,
            this.测试ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            // 
            // 设为起点ToolStripMenuItem
            // 
            this.设为起点ToolStripMenuItem.Name = "设为起点ToolStripMenuItem";
            this.设为起点ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.设为起点ToolStripMenuItem.Text = "设为起点";
            this.设为起点ToolStripMenuItem.Click += new System.EventHandler(this.设为起点ToolStripMenuItem_Click);
            // 
            // 设为终点ToolStripMenuItem
            // 
            this.设为终点ToolStripMenuItem.Name = "设为终点ToolStripMenuItem";
            this.设为终点ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.设为终点ToolStripMenuItem.Text = "设为终点";
            this.设为终点ToolStripMenuItem.Click += new System.EventHandler(this.设为终点ToolStripMenuItem_Click);
            // 
            // 测试ToolStripMenuItem
            // 
            this.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem";
            this.测试ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.测试ToolStripMenuItem.Text = "测试";
            this.测试ToolStripMenuItem.Click += new System.EventHandler(this.测试ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(871, 624);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 迷宫设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem 算法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拆墙ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 筑墙ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 随机拆墙ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设为起点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设为终点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 施工结束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 广度优先ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 深度优先ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 迭代加深ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最优优先ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完全修复toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;

    }
}

