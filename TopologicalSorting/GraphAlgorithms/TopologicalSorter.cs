using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphAlgorithms
{
    public static class TopologicalSorter
    {
        public static IEnumerable<T> Sort<T>(IEnumerable<T> Nodes,
                                             Func<T, IEnumerable<T>> Successors,
                                             out bool HasCycle)
        {
            var VisitedNodes = new HashSet<T>();
            var Result = new List<T>();
            HasCycle = false;
            foreach (var iNode in Nodes.Where(iNode => false == VisitedNodes.Contains(iNode)))
            {
                Visit(iNode, Successors, VisitedNodes, Result, ref HasCycle);
                if (HasCycle)
                {
                    break;
                }
            }
            return HasCycle ? null : Result;
        }

        private static void Visit<T>(T iNode,
                                     Func<T, IEnumerable<T>> Successors,
                                     HashSet<T> VisitedNodes,
                                     List<T> iList,
                                     ref bool HasCycle)
        {
            if (false == VisitedNodes.Contains(iNode))
            {
                VisitedNodes.Add(iNode);
                foreach (var jNode in Successors(iNode))
                {
                    Visit(jNode, Successors, VisitedNodes, iList, ref HasCycle);
                }
                iList.Insert(0, iNode);
            }
            HasCycle |= false == iList.Contains(iNode);
        }
    }
}
