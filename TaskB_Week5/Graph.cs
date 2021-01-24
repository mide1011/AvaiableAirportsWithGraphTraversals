using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskB_Week5
{
    public class Graph<T> where T : IComparable
    {
        public LinkedList<GraphNode<T>> Nodes;

        public Graph()
        {
            Nodes = new LinkedList<GraphNode<T>>();
        }

        public bool ISEmptyGraph()
        {

            return Nodes.Count == 0;

        }

        public int NumNodesGraph()
        {
            int num = 0;
            foreach (GraphNode<T> n in Nodes)
                num++;
            return num;
        }

        public int NumEdgesGraph()
        {
            int sum = 0;
            foreach (GraphNode<T> n in Nodes)
            {
                sum += (n.GetAdjList().Count);
            }
            return sum;
        }

        public void AddNode(T id)
        {

            Nodes.AddLast(new GraphNode<T>(id));
        }

        public bool ContainsGraph(GraphNode<T> node)
        {
            foreach (GraphNode<T> i in Nodes)

                if (i.ID.CompareTo(node) == 0)
                    return true;
            return false;
        }


        public GraphNode<T> GetNodebyID(T id)
        {

            foreach (GraphNode<T> n in Nodes)
                if (n.ID.CompareTo(id) == 0)
                    return n;

            return null;
        }


        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            foreach (GraphNode<T> n in Nodes)

                if (n.ID.CompareTo(from.ID) == 0)
                {
                    bool b = from.GetAdjList().Contains(to.ID);
                    if (b == true) return true;
                }
            return false;

        }

        public void AddEdge(T from, T to)
        {

            GraphNode<T> n1 = GetNodebyID(from);
            GraphNode<T> n2 = GetNodebyID(to);


            if (n1 != null & n2 != null)
                n1.AddEdge(n2);

           

        }

        public void RemoveEdge(T from, T to)
        {

            GraphNode<T> n1 = GetNodebyID(from);
            GraphNode<T> n2 = GetNodebyID(to);


            if (n1.GetAdjList().Contains(n2.ID))
            {
                //remove connection
                //from adjacent list 
                n1.GetAdjList().Remove(n2.ID);
            }

        }

        

        public void DepthFirstTraverse(T startID, ref List<T> visited)
        {
            LinkedList<T> adj;

            Stack<T> toVisit = new Stack<T>();

            GraphNode<T> current = new GraphNode<T>(startID);

            toVisit.Push(startID);

            while (toVisit.Count != 0)
            {
                //get the top toVisit
                current = GetNodebyID(toVisit.Pop());
                //add current to visited list
                visited.Add(current.ID);

                adj = current.GetAdjList();

                foreach (T node in adj) {

                    if (!toVisit.Contains(node) && !visited.Contains(node)) {
                        //push node toVisit
                        toVisit.Push(node);
                    }
                }

                
            }



        }

        public void BreadthFirstTraverse(T startID, ref List<T> visited)
        {
            LinkedList<T> adj;
            Queue<T> toVisit = new Queue<T>();
            GraphNode<T> current = new GraphNode<T>(startID);

            toVisit.Enqueue(startID);

            while (toVisit.Count != 0)
            {
                current = GetNodebyID(toVisit.Dequeue());

                visited.Add(current.ID);

                adj = current.GetAdjList();


                foreach (T node in adj)
                {

                    if (!toVisit.Contains(node) && !visited.Contains(node))
                    {
                        //enqueue node to toVisit queue
                        toVisit.Enqueue(node);
                    }
                }
            }

          


        }


        public List<T> Mothervertex()
        {

            foreach (GraphNode<T> n in Nodes)
            {

                //create empty list for visited 
                //nodes
                List<T> visted = new List<T>();

                //traverse
                DepthFirstTraverse(n.ID, ref visted);

                //if the number of visited == number of nodes
                //then we have visited each node 
                //therefore we have found the mother vertex
                if (Nodes.Count == visted.Count)
                {
                    MessageBox.Show("You can Reach all Airports from: " + visted[0]); 
                }
               
            }

            return null;
        }







    }
}
