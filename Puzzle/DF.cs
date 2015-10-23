using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    public class DF
    {
        public DF(Puzzle pp)
        {
            p = pp;
        }
        public Puzzle p
        {
            get;
            set;
        }
        public Path resolve(int pdepth)
        {
            Path path = new Path();

            Node start = new Node(p.Start);
            start.Depth = 0;
            LinkedList<Node> Open = new LinkedList<Node>();
            HashSet<Node> Open2 = new HashSet<Node>();
            HashSet<Node> Close = new HashSet<Node>();
            Open.AddFirst(start);
            Open2.Add(start);
            bool flag = false;
            Node curr = null;
            while (Open.Count > 0)
            {
                curr = Open.First();
                Open.RemoveFirst();
                Open2.Remove(curr);
                Close.Add(curr);
                if (curr.cell.End)
                {
                    flag = true;
                    break;
                }
                if(curr.Depth < pdepth )
                curr.ExpandDF(Open, Open2, Close);
            }
            if (flag)
            {
                while (curr.Parent != null)
                {
                    path.cells.Add(curr.cell);
                    curr = curr.Parent;
                }
                path.cells.Add(curr.cell);
            }
            else
                ;

            return path;
        }



    }
}
