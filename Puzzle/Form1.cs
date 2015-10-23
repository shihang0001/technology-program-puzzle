using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        int scale;
        int MaxScale;
        int depth;
        Puzzle p;
        int margin;
        int width;
        int height;
        Cell CurrentMouseCell;
        Path path;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            scale = 9;
            MaxScale = 20;
            depth = 5;
            margin = 50;
            width = this.Width;
            height = this.Height;
            g = CreateGraphics();this.Refresh();
            p = new Puzzle(scale, g, margin, width, height);  
        }

        private void DestroyWall(object sender, MouseEventArgs e)
        {          
            p.ChangeACellNearTo(e.X, e.Y,WallStatus.open);

        }
        private void BuildWall(object sender, MouseEventArgs e)
        {
            p.ChangeACellNearTo(e.X, e.Y, WallStatus.close );
        }
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string str = this.toolStripTextBox1.Text.Trim();
            int newscale = 0;
            try
            {
                newscale = System.Convert.ToInt32(str);
                if (newscale > MaxScale) return;
                scale = newscale;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message + " please input a valid scale!");
            }
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (p != null) p.UnDraw();
            if (path != null) path.UnDraw();
            p = new Puzzle(scale, g, margin, width, height);          
        }      

        private void 拆墙ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {           
            this.MouseClick -= this.BuildWall;
            this.MouseClick += this.DestroyWall;
            this.Cursor = Cursors.Hand;
        }

        private void 筑墙ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MouseClick -= this.DestroyWall;
            this.MouseClick += this.BuildWall;
            this.Cursor = Cursors.Cross;
        }

        private void 设为起点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentMouseCell != null)
                p.SetStart(CurrentMouseCell);                           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentMouseCell = p.CheckMouse(e.X, e.Y);
        }

        private void 设为终点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentMouseCell != null)
                p.SetEnd(CurrentMouseCell);            
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(CurrentMouseCell.UpStatus.ToString());
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            p.ReDraw();
        }

        private void 施工结束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MouseClick -= this.DestroyWall;
            this.MouseClick -= this.BuildWall;
            this.Cursor = Cursors.Default;
        }

        

        private void 广度优先ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (p.Start  == null)
            {
                MessageBox.Show("请输入起点");
                return;
            }
            if (p.End == null)
            {
                MessageBox.Show("请输入终点");
                return;
            }
            BDF bdf = new BDF(p);
            path= bdf.resolve();
            if (path.cells .Count >0)
                path.Draw();
            else MessageBox.Show("无法到达");
        }

        private void 随机拆墙ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int num = r.Next(scale * scale);
            for(int i=0;i<num;i++)
            {
                int x = r.Next(scale);
                int y = r.Next(scale);
                Cell cell = p.Cells[x, y];
                int dir = r.Next(4);
                switch (dir)
                {
                    case 0:
                        cell.ChangeStatusofAWall(Direction.up, WallStatus.open);
                        break;
                    case 1:
                        cell.ChangeStatusofAWall(Direction.down, WallStatus.open);
                        break;
                    case 2:
                        cell.ChangeStatusofAWall(Direction.left, WallStatus.open);
                        break;
                    case 3:
                        cell.ChangeStatusofAWall(Direction.right, WallStatus.open);
                        break;
                }

            }
        }

        private void 完全修复toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            p = new Puzzle(scale, g, margin, width, height);        
        }

        private void 深度优先ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (p.Start == null)
            {
                MessageBox.Show("请输入起点");
                return;
            }
            if (p.End == null)
            {
                MessageBox.Show("请输入终点");
                return;
            }
            DF df = new DF(p);
            path = df.resolve(depth);
            if (path.cells.Count > 0)
                path.Draw();
            else MessageBox.Show("无法到达");

        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            string str = this.toolStripTextBox2.Text.Trim();
            int newdepth = 0;

            try
            {
                newdepth = System.Convert.ToInt32(str);

                depth = newdepth;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message + " please input a valid depth!");
            }
        }

        

      
    }
}