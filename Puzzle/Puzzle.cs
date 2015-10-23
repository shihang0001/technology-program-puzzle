using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Puzzle
{
    /// <summary>
    /// 表示一个迷宫
    /// </summary>
  public  class Puzzle
    {
      /// <summary>
      /// 正方形迷宫。边长最大20；
      /// </summary>
      public int scale
      {
          get;
          private set;
      }

      /// <summary>
      /// 格子数组
      /// </summary>
      public Cell[,] Cells
      {
          get;
          private set;
      }
      public Graphics g
      {
          get;
          private set;
      }

      public Pen blackPen
      {
          get;
          private set;
      }
      public Pen whitePen
      {
          get;
          private set;
      }
      public Pen bluePen
      {
          get;
          private set;
      }

      public Pen greenPen
      {
          get;
          private set;
      }

      /// <summary>
      /// 屏幕上的高和宽。
      /// </summary>
      int width, height;
      public int lenth
      {
          get;
          private set;
      }

      /// <summary>
      /// 屏幕的边沿宽度。
      /// </summary>
      public int margin
      {
          get;
          private set;
      }

      /// <summary>
      /// 起始点。
      /// </summary>
      public Cell Start
      {
          get;
          private set;
      }

      /// <summary>
      /// 目的地
      /// </summary>
      public Cell End
      {
          get;
          private set;
      }
      

     public  Puzzle(int pscale,Graphics pg,int pmargin,int pwidth,int pheight)
      {
          g = pg;
          scale = pscale;
          blackPen = new Pen(Color.Black);
          whitePen = new Pen(Color.White);
          bluePen = new Pen(Color.Blue);
          greenPen = new Pen(Color.Green);
          width = pwidth;
          height = pheight;
          margin = pmargin;
          lenth = Math.Min(width, height);
          lenth /= scale;
          Cells = new Cell[scale, scale];
          for(int i=0;i<scale ;i++)
          {
              for (int j = 0; j < scale; j++)
                  Cells[i, j] = new Cell(i, j,this,g);              
          }
          for (int i = 0; i < scale;i++ )
          {
             for (int j = 0; j < scale; j++)
                 Cells[i, j].setNeighbours();
          }
         
      }

      /// <summary>
      /// 根据当前鼠标位置，找到最近的格子。
      /// </summary>
      /// <param name="X"></param>
      /// <param name="Y"></param>
      /// <returns></returns>
      public Cell CheckMouse(int X, int Y)
      {
          int x = (X - margin) / lenth;
          int y = (Y - margin) / lenth;
          if (x > scale - 1) return null;
          if (y > scale - 1) return null;
            
          return Cells[(X-margin)  / lenth, (Y-margin ) / lenth ];
      }

      /// <summary>
      /// 修改当前鼠标最近的格子的状态。（哪边墙，开还是关）
      /// </summary>
      /// <param name="X"></param>
      /// <param name="Y"></param>
      /// <param name="status"></param>
      public void ChangeACellNearTo(int X, int Y,WallStatus status)
      {
          Cell cell = CheckMouse(X, Y);
          if (cell == null) return;
          Direction dir = cell.checkDir(X, Y);
          cell.ChangeStatusofAWall(dir, status);
      }

      /// <summary>
      /// 设置起点
      /// </summary>
      /// <param name="c"></param>
      public void SetStart(Cell c)
      {
          if (this.Start != null)
              Start.Start = false;
          Start = c;
          Start.Start = true;
      }

      /// <summary>
      /// 设置终点
      /// </summary>
      /// <param name="c"></param>
      public void SetEnd(Cell c)
      {
          if (this.End != null)
              End.End = false; 
          End = c;
          End.End = true;
      }

      /// <summary>
      /// 在屏幕重绘整个迷宫。
      /// </summary>
      public void ReDraw()
      {
          for (int i = 0; i < scale; i++)
              for (int j = 0; j < scale; j++)
                  Cells[i, j].Redraw();
      }

      /// <summary>
      /// 在屏幕抹掉整个迷宫
      /// </summary>
      public void UnDraw()
      {
          for (int i = 0; i < scale; i++)
              for (int j = 0; j < scale; j++)
                  Cells[i, j].UnDraw();

      }
     
      
  }
}
