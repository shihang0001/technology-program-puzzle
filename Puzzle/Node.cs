using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    /// <summary>
    /// 搜索时的状态。
    /// </summary>
   public class Node
    {
       /// <summary>
       /// 格子。
       /// </summary>
       public Cell cell
       {
           get;
           set;
       }

       /// <summary>
       /// 从哪儿来。
       /// </summary>
       public Node Parent
       {
           get;
           set;
       }

       /// <summary>
       /// 从起始点到这里，经过了几步。
       /// </summary>
       public int Depth
       {
           get;
           set;
       }

       /// <summary>
       /// 可能的后续。
       /// </summary>
       public List<Node> Children
       {
           get;
           set;
       }
       public Node (Cell pcell)
       {
           cell = pcell;
           Children = new List<Node>();
       }

       /// <summary>
       ///
       /// </summary>
       /// <param name="obj"></param>
       /// <returns></returns>
       public override bool Equals(object obj)
       {
           Node n = (Node)obj;
           if (this.cell .Equals (n.cell )) return true ;
           else return  false;               
       }
       /// <summary>
       ///  格子的hash
       /// </summary>
       /// <returns></returns>
       public override int GetHashCode()
       {
           return this.cell.GetHashCode();
       }


       /// <summary>
       /// 是否为某节点的祖先。
       /// </summary>
       /// <param name="offspring"></param>
       /// <returns></returns>
       public bool IsParentOf(Node offspring)
       {
           Node curr = offspring;
           while (curr.Parent != null)
           {
               if (this.Equals(curr.Parent)) return true;
               curr = curr.Parent;
           }
           return false;
       }

       /// <summary>
       /// 已经选择了某节点next后，将其在数据结构中进行安置。
       /// Open 必须为双向链表。
       /// Open2 是为了定位效率。
       /// </summary>
       /// <param name="next"></param>
       /// <param name="Open"></param>
       /// <param name="Open2"></param>
       /// <param name="Close"></param>
       public void Conduct(Node next,LinkedList<Node>Open,HashSet <Node >Open2,HashSet <Node>Close)
       {
           if (!Open2.Contains(next) && !Close.Contains(next))
           {
               Open.AddLast(next);
               Open2.Add(next);
               this.Children.Add(next);
               next.Parent = this;
           }        
       }

       /// <summary>
       /// 在深度优先时的处理方法。
       /// </summary>
       /// <param name="next"></param>
       /// <param name="Open"></param>
       /// <param name="Open2"></param>
       /// <param name="Close"></param>
       public void ConductDF(Node next,LinkedList<Node>Open,HashSet <Node >Open2,HashSet <Node>Close)
       {
           if (!Open2.Contains(next) && !Close.Contains(next))
           {
               next.Depth = this.Depth + 1;
               Open.AddFirst(next);
               Open2.Add(next);
               this.Children.Add(next);
               next.Parent = this;
           }    
       }

       /// <summary>
       /// 对当前节点进行展开。
       /// </summary>
       /// <param name="Open"></param>
       /// <param name="Open2"></param>
       /// <param name="Close"></param>
       public void Expand(LinkedList<Node> Open, HashSet<Node> Open2, HashSet<Node> Close)
       {
           Node curr = this;
           if (curr.cell.UpStatus == WallStatus.open&&curr .cell .upNei !=null)
           {               
               Node next = new Node(curr.cell.upNei);
               curr.Conduct(next, Open, Open2, Close);
           }
           if (curr.cell.DownStatus == WallStatus.open && curr.cell.downNei != null)
           {
               Node next = new Node(curr.cell.downNei);
               curr.Conduct(next, Open, Open2, Close);
           }
           if (curr.cell.LeftStatus == WallStatus.open && curr.cell.leftNei != null)
           {
               Node next = new Node(curr.cell.leftNei);
               curr.Conduct(next, Open, Open2, Close);
           }
           if (curr.cell.RightStatus == WallStatus.open && curr.cell.rightNei != null)
           {
               Node next = new Node(curr.cell.rightNei);
               curr.Conduct(next, Open, Open2, Close);
           }
       }

       /// <summary>
       /// 对当前节点进行展开，使用深度优先。
       /// </summary>
       /// <param name="Open"></param>
       /// <param name="Open2"></param>
       /// <param name="Close"></param>
       public void ExpandDF(LinkedList<Node> Open, HashSet<Node> Open2, HashSet<Node> Close)
       {
           Node curr = this;
           if (curr.cell.UpStatus == WallStatus.open && curr.cell.upNei != null)
           {
               Node next = new Node(curr.cell.upNei);
               curr.ConductDF(next, Open, Open2, Close);
           }
           if (curr.cell.DownStatus == WallStatus.open && curr.cell.downNei != null)
           {
               Node next = new Node(curr.cell.downNei);
               curr.ConductDF(next, Open, Open2, Close);
           }
           if (curr.cell.LeftStatus == WallStatus.open && curr.cell.leftNei != null)
           {
               Node next = new Node(curr.cell.leftNei);
               curr.ConductDF(next, Open, Open2, Close);
           }
           if (curr.cell.RightStatus == WallStatus.open && curr.cell.rightNei != null)
           {
               Node next = new Node(curr.cell.rightNei);
               curr.ConductDF(next, Open, Open2, Close);
           }
       }
       public override string ToString()
       {
           return cell.ToString();
       }
             

    }
}
