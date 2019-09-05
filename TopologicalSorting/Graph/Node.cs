using System.Collections.Generic;
using System.Xml.Serialization;

namespace Graphs
{
    public class Node
    {
        public int Id = 0;                          // for inspection in xml file
        public int[] SuccessorIds = new int[0];     // successors

        [XmlIgnore]
        public IEnumerable<Node> Successors = new List<Node>();
    }
}
