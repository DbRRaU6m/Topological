using System.Linq;

namespace Graphs
{
    public class Graph
    {
        public Node[] Nodes = new Node[0];

        public void PrepareSuccessors()
        {
            foreach (var iNode in Nodes)
            {
                iNode.Successors
                    = iNode.SuccessorIds.Select(Id => Nodes.First(jNode => jNode.Id == Id));
            }
        }
    }
}
