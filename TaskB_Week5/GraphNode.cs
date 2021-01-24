using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskB_Week5
{
    public class GraphNode<T>
    {

        //members
        private T id;
        private LinkedList<T> adjList;

        public GraphNode(T id)
        {
            this.id = id;
            adjList = new LinkedList<T>();

        }
        //properties
        public T ID
        {
            set { id = value; }
            get { return id; }

        }

        //mehtods
        public void AddEdge(GraphNode<T> to)
        {
            adjList.AddLast(to.ID);

        }

        public LinkedList<T> GetAdjList()
        {
            return adjList;
        }
    }
}
