using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Puzzle
{

  public enum WallStatus
    {
        close,open
    }
  public enum Direction
    {
        up,down,left,right
    }

  public  class Cell
    {
      
        /// <summary>
        /// 在迷宫中的坐标，最小值为0，最大为19.  原点在左上角。
        /// </summary>
        public int x
        {
            get;
            private set;
        }
        /// <summary>
        /// 最小值为0.
        /// </summary>
        public int y
        {
            get;
            private set;
        }
        Graphics g; 
       /// <summary>
       /// 四面墙状态。
       /// </summary>
        WallStatus upStatus;       
        WallStatus downStatus;
        WallStatus leftStatus;
        WallStatus rightStatus;
       
      /// <summary>
      /// 四个邻居
      /// </summary>
       public Cell upNei
        {
            get;
            private set;
        }
        public Cell downNei
        {
            get;
            private set;
        }
        public Cell leftNei
        {
            get;
            private set;
        }
        public Cell rightNei
        {
            get;
            private set;
        }
        /// <summary>
        /// 反指向迷宫，借此可以访问其他格子。
        /// </summary>
        Puzzle p;
        public Cell(int px,int py, Puzzle pp, Graphics pg)
        {
            x = px;
            y = py;
            g = pg; 
            p = pp;
            UpStatus = WallStatus.close;
            DownStatus = WallStatus.close;
            LeftStatus = WallStatus.close;
            RightStatus = WallStatus.close;           
        }

      
      /// <summary>
      /// 读取或设置上墙的状态。
      /// </summary>
      public WallStatus UpStatus
        {
            get
            {
                return upStatus;
            }
            set
            {
                upStatus =value ;
                if (value == WallStatus.close)               
                    Draw(blackPen, Direction.up);
                else
                    HalfDraw(whitePen, Direction.up);                    
            }
        }

      public WallStatus DownStatus
      {
          get
          {
              return downStatus;
          }
          set
          {
              downStatus = value;
              if (value  == WallStatus.close)
                  Draw(blackPen, Direction.down );
              else
                  HalfDraw(whitePen, Direction.down);
          }
      }

      public WallStatus LeftStatus
      {
          get
          {
              return leftStatus;
          }
          set
          {
              leftStatus = value;
              if (value == WallStatus.close)
                  Draw(blackPen, Direction.left);
              else
                  HalfDraw(whitePen, Direction.left);
          }
      }

      public WallStatus RightStatus
      {
          get
          {
              return rightStatus;
          }
          set
          {
              rightStatus = value;
              if (value == WallStatus.close)
                  Draw(blackPen, Direction.right);
              else
                  HalfDraw(whitePen, Direction.right);
          }
      }

      Pen blackPen
      {
          get
          { return p.blackPen; }
      }
      Pen whitePen
      {
          get
          {return p.whitePen ;}
      }
      Pen bluePen
      { 
          get { return p.blackPen; } 
      }

      Pen greenPen
      {
          get { return p.greenPen; }
      }

      /// <summary>
      /// 初始化邻居
      /// </summary>
      public void setNeighbours()
        {
            if (this.y > 0)
                this.upNei = p.Cells[this.x, this.y - 1];
            if (this.x > 0)
                this.leftNei = p.Cells[this.x - 1, this.y];
            if (this.y < this.Scale - 1)
                this.downNei = p.Cells[this.x, this.y + 1];
            if (this.x < this.Scale - 1)
                this.rightNei = p.Cells[this.x + 1, this.y];
        }

      /// <summary>
      /// 迷宫的规模。
      /// </summary>
      int Scale
        {
          get
            {
                return p.scale;
            }
        }

      int margin
      {
          get{return p.margin ;}
      }
      int length
      {
          get{return p.lenth ;}
      }

      /// <summary>
      /// 屏幕坐标。
      /// </summary>
      int UP
      {
          get { return margin + y * length;}
      }
      int DOWN
      {
          get
          { return margin + (y + 1) * length; }
      }
      int LEFT
      {
          get
          { return margin + x * length; }
      }
      int RIGHT
      {
          get
          { return margin + (x+1) * length; }
      }

      int CenterX
      {
          get
          {
              return (LEFT + RIGHT) / 2;
          }
      }
      int CenterY
      {
          get
          { return (UP + DOWN) / 2; }
      }
      /// <summary>
      /// 是否为起始点，终点
      /// </summary>
      bool start;
      bool end;
      public   bool Start
      {
          get
          {
              return start;
          }
           set
          {
              if (value == true)
              {
                  start = true;
                  this.DrawCircle(greenPen);
              }
              else
              {
                  start = false;
                  this.DrawCircle(whitePen);
              }
          }
      }

      /// <summary>
      /// 读取或设置该格子是否为终点。
      /// </summary>
      public bool End
      {
          get
          {
              return end;
          }
          set
          {
              if (value == true)
              {
                  end = true;
                  this.DrawRectangle(greenPen);
              }
              else
              {
                  end = false;
                  this.DrawRectangle(whitePen);
              }
          }
      }


      /// <summary>
      /// 画墙
      /// </summary>
      /// <param name="pen"></param>
      /// <param name="dir"></param>
      void Draw(Pen pen, Direction dir)
      {
          switch (dir)
          {
              case Direction.up:
                  g.DrawLine(pen, LEFT, UP, RIGHT, UP);
                  break;
              case Direction.down:
                  g.DrawLine(pen, LEFT, DOWN, RIGHT, DOWN);
                  break;
              case Direction.left:
                  g.DrawLine(pen, LEFT, UP, LEFT, DOWN);
                  break;
              case Direction.right:
                  g.DrawLine(pen, RIGHT, UP, RIGHT, DOWN);
                  break;
          }
      }

      /// <summary>
      /// 半画墙。即开门。
      /// </summary>
      /// <param name="pen"></param>
      /// <param name="direction"></param>
      public void HalfDraw(Pen pen,Direction direction)
      {          
          switch (direction )
          {
              case  Direction.up :
                  g.DrawLine(pen, LEFT + length / 4, UP, RIGHT - length / 4, UP);
                  break;
              case  Direction.down :
                  g.DrawLine(pen, LEFT + length / 4, DOWN, RIGHT - length / 4, DOWN);
                  break;
              case  Direction.left :
                  g.DrawLine(pen, LEFT, UP + length / 4, LEFT, DOWN - length / 4);
                  break;
              case   Direction.right :
                  g.DrawLine(pen, RIGHT, UP + length / 4, RIGHT, DOWN - length / 4);
                  break;
          }
      }
    
      public void DrawCircle(Pen pen)
      {
          g.DrawEllipse(pen, LEFT+length /4, UP+length /4, length / 2, length / 2);
      }

      public void DrawRectangle(Pen pen)
      {
          g.DrawRectangle(pen, LEFT + length / 4, UP + length / 4, length / 2, length / 2);
      }

      /// <summary>
      /// 改变一面墙的状态，注意，会导致其邻居的相应状态被改变。
      /// </summary>
      /// <param name="dir"></param>
      /// <param name="status"></param>
     public  void ChangeStatusofAWall(Direction  dir, WallStatus status)
      {
          switch (dir)
          {
              case  Direction.up :
                  if (status == WallStatus.open)
                  {
                      UpStatus = WallStatus.open;
                      if (this.upNei != null) upNei.DownStatus = WallStatus.open;
                  }
                  else
                  {
                      UpStatus = WallStatus.close;
                      if (this.upNei != null) upNei.DownStatus = WallStatus.close;
                  }
                  break;
              case  Direction.down :
                  if (status == WallStatus.open)
                  {
                      DownStatus = WallStatus.open;
                      if (this.downNei != null) downNei.UpStatus = WallStatus.open;
                  }
                  else
                  {
                      DownStatus = WallStatus.close;
                      if (this.downNei != null) downNei.UpStatus = WallStatus.close;
                  }
                  break;
              case Direction.left :
                  if(status ==WallStatus .open )
                  {
                      LeftStatus = WallStatus.open;
                      if(this.leftNei !=null )leftNei.RightStatus=WallStatus.open ;
                  }
                  else
                  {
                      LeftStatus = WallStatus.close;
                      if (this.leftNei != null) leftNei.RightStatus = WallStatus.close;
                  }
                  break;
              case  Direction.right :
                  if (status == WallStatus.open)
                  {
                      RightStatus = WallStatus.open;
                      if (this.rightNei != null) rightNei.LeftStatus = WallStatus.open;
                  }
                  else
                  {
                      RightStatus = WallStatus.close;
                      if (this.rightNei != null) rightNei.LeftStatus = WallStatus.close;
                  }
                  break;
          }
      }

      /// <summary>
      /// 鼠标在格子内时，找到其离哪个墙最近。
      /// </summary>
      /// <param name="px"></param>
      /// <param name="py"></param>
      /// <returns></returns>
     public Direction checkDir(int px, int py)
          {   
              int up = py - UP;            
              int down = DOWN - py;
              int left = px - LEFT;
              int right = RIGHT - px;
              int minimum = up;
              Direction dir = Direction.up;
              if (down < minimum)
              {
                  dir = Direction.down;
                  minimum = down;
              }
              if (left < minimum)
              {
                  dir = Direction.left;
                  minimum = left;
              }
              if (right < minimum)
              {
                  dir = Direction.right;
                  minimum = right;
              }
              changeWallStatusAfterOpenAWall(dir);
              return dir;
          }

      /// <summary>
      /// 打开一堵墙，并改变墙的状态，以及邻居的墙状态。
      /// </summary>
      /// <param name="dir"></param>
     public void changeWallStatusAfterOpenAWall(Direction dir)
     {
         switch (dir)
         {
             case Direction.up:
                 this.upStatus = WallStatus.open;
                 if (this.y > 0) this.upNei.downStatus = WallStatus.open;
                 break;
             case Direction.down:
                 this.downStatus = WallStatus.open;
                 if (this.y < Scale - 1) this.downNei.upStatus = WallStatus.open;
                 break;
             case Direction.right:
                 this.rightStatus = WallStatus.open;
                 if (this.x < Scale - 1) this.rightNei.leftStatus = WallStatus.open;
                 break;
             case Direction.left:
                 this.leftStatus = WallStatus.open;
                 if (this.x > 0) this.leftNei.rightStatus = WallStatus.open;
                 break;
         }
     }

      /// <summary>
      /// 在（相邻的）两个格子之间画线。
      /// </summary>
      /// <param name="cell"></param>
      public void Connect2(Cell cell)
     {
         g.DrawLine(bluePen, this.CenterX, this.CenterY, cell.CenterX, cell.CenterY);
     }
      /// <summary>
      /// 在（相邻的）两个格子之间取消画线。
      /// </summary>
      /// <param name="cell"></param>
      public void UnConnect2(Cell cell)
      {
          g.DrawLine(whitePen, this.CenterX, this.CenterY, cell.CenterX, cell.CenterY);
      }

      /// <summary>
      /// 重绘该格子。注意墙的状态。
      /// </summary>
      public void Redraw()
     {
         this.Draw(blackPen, Direction.up);
         this.Draw(blackPen, Direction.down);
         this.Draw(blackPen, Direction.left );
         this.Draw(blackPen, Direction.right );
         if(upStatus==WallStatus.open )  HalfDraw (whitePen, Direction.up );
         if (downStatus == WallStatus.open) HalfDraw(whitePen, Direction.down);
         if (leftStatus == WallStatus.open) HalfDraw(whitePen, Direction.left);
         if (rightStatus == WallStatus.open) HalfDraw(whitePen, Direction.right);
         if (Start) this.Start = true;
         if (End ) this.End = true;        
     }

      /// <summary>
      /// 屏幕上抹掉该格子。
      /// </summary>
      public void UnDraw()
      {
          this.Draw(whitePen, Direction.up);
          this.Draw(whitePen, Direction.down);
          this.Draw(whitePen, Direction.left);
          this.Draw(whitePen, Direction.right);
          this.End = false;
          this.Start = false;
      }

     public override string ToString()
     {
         string str = "("+this.x.ToString() +","+ this.y.ToString()+")";
         return str;
     }

      
      public override bool Equals(object obj)
      {
          Cell c = (Cell)obj;
          if (this.x == c.x && this.y == c.y) return true;
          else
              return false;
      }

      /// <summary>
      /// 需要加入到hash集合中，因此要求其hash值。这种方法45度对称的两个格子会冲突。
      /// </summary>
      /// <returns></returns>
      public override int GetHashCode()
      {
          int h=this.x.GetHashCode();
          h^=this.y.GetHashCode ();
          return h;
      }
  
  }

}