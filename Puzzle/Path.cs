using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    /// <summary>
    /// 迷宫的路径
    /// </summary>
  public  class Path
    {
      public Path()
      {
          cells = new List<Cell>();
      }
      public List<Cell> cells
      {
          get;
          set;
      }
      public void Draw()
      {
          for(int i=0;i<cells.Count-1 ;i++)
          {
              cells[i].Connect2(cells[i + 1]);
          }
      }
      public void UnDraw()
      {
          for (int i = 0; i < cells.Count - 1; i++)
          {
              cells[i].UnConnect2(cells[i + 1]);
          }

      }
    }
}
