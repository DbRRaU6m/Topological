using System;
using System.Collections.Generic;
using System.Linq;
using GraphAlgorithms;
using Graphs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TopologicalSortingTest
{
    [TestClass]
    public class Test
    {

        private bool IsRightOf<T>(T[] iSequence, T Lhs, T Rhs)
        {
            var i = Array.IndexOf(iSequence, Lhs);
            var j = Array.IndexOf(iSequence, Rhs);
            return i < j;
        }

        private bool IsTopologicalSort<T>(IEnumerable<T> iNodes, Func<T, IEnumerable<T>> Successors)
        {
            var iSequence = iNodes.ToArray();
            var Result
                = iSequence.All(iNode => Successors(iNode).All(jNode => IsRightOf(iSequence, iNode, jNode)));
            return Result;
        }

        [TestMethod]
        public void Instance01Test()
        {
            var iGraph = new Graph();
            iGraph.Nodes = new Node[]
            {
                new Node
                {
                    Id = 1,
                    SuccessorIds = new int[] { 47, 26 }
                },
                new Node
                {
                    Id = 2,
                    SuccessorIds = new int[] { } // lose
                },
                new Node
                {
                    Id = 3,
                    SuccessorIds = new int[] { 7, 30 }
                },
                new Node
                {
                    Id = 4,
                    SuccessorIds = new int[] { 3, 19 }
                },
                new Node
                {
                    Id = 5,
                    SuccessorIds = new int[] {} // win
                },
                new Node
                {
                    Id = 6,
                    SuccessorIds = new int[] { 8, 13 }
                },
                new Node
                {
                    Id = 7,
                    SuccessorIds = new int[] { 10, 21 }
                },
                new Node
                {
                    Id = 8,
                    SuccessorIds = new int[] { 39, 14 }
                },
                new Node
                {
                    Id = 9,
                    SuccessorIds = new int[] { 17, 32 }
                },
                new Node
                {
                    Id = 10,
                    SuccessorIds = new int []{} // lose
                },
                new Node
                {
                    Id = 11,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 12,
                    SuccessorIds = new int[] { 27, 5 }
                },
                new Node
                {
                    Id = 13,
                    SuccessorIds = new int[] { 12, 14 }
                },
                new Node
                {
                    Id = 14,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 15,
                    SuccessorIds = new int[] { 18, 35 }
                },
                new Node
                {
                    Id = 16,
                    SuccessorIds = new int[] { 6, 28 }
                },
                new Node
                {
                    Id = 17,
                    SuccessorIds = new int[] { 8, 13 }
                },
                new Node
                {
                    Id = 18,
                    SuccessorIds = new int[] { 7, 30 }
                },
                new Node
                {
                    Id = 19,
                    SuccessorIds = new int[] { 7, 30 }
                },
                new Node
                {
                    Id = 20,
                    SuccessorIds = new int[] { 53, 43 }
                },
                new Node
                {
                    Id = 21,
                    SuccessorIds = new int[] { 27 }
                },
                new Node
                {
                    Id = 22,
                    SuccessorIds = new int[] { 45, 20 }
                },
                new Node
                {
                    Id = 23,
                    SuccessorIds = new int[] { 24, 33 }
                },
                new Node
                {
                    Id = 24,
                    SuccessorIds = new int[] { 22, 40 }
                },
                new Node
                {
                    Id = 25,
                    SuccessorIds = new int[] { 41, 50 }
                },
                new Node
                {
                    Id = 26,
                    SuccessorIds = new int[]{ 37, 44 }
                },
                new Node
                {
                    Id = 27,
                    SuccessorIds = new int[] {} // win
                },
                new Node
                {
                    Id = 28,
                    SuccessorIds = new int[] { 8, 13 }
                },
                new Node
                {
                    Id = 29,
                    SuccessorIds = new int[] { 18, 35 }
                },
                new Node
                {
                    Id = 30,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 31,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 32,
                    SuccessorIds = new int[] { 30, 13 }
                },
                new Node
                {
                    Id = 33,
                    SuccessorIds = new int[] { 22, 40 }
                },
                new Node
                {
                    Id = 34,
                    SuccessorIds = new int[] { 25, 52 }
                },
                new Node
                {
                    Id = 35,
                    SuccessorIds = new int[] { 7, 30 }
                },
                new Node
                {
                    Id = 36,
                    SuccessorIds = new int[] { 45, 20 }
                },
                new Node
                {
                    Id = 37,
                    SuccessorIds = new int[] { 51, 31 }
                },
                new Node
                {
                    Id = 38,
                    SuccessorIds = new int[] { 25, 52 }
                },
                new Node
                {
                    Id = 39,
                    SuccessorIds = new int[] { 5, 11 }
                },
                new Node
                {
                    Id = 40,
                    SuccessorIds = new int[] { 41, 50 }
                },
                new Node
                {
                    Id = 41,
                    SuccessorIds = new int[] { 2, 9 }
                },
                new Node
                {
                    Id = 42,
                    SuccessorIds = new int[] { 20, 45 }
                },
                new Node
                {
                    Id = 43,
                    SuccessorIds = new int[] { 17, 32 }
                },
                new Node
                {
                    Id = 44,
                    SuccessorIds = new int[] { 34, 55 }
                },
                new Node
                {
                    Id = 45,
                    SuccessorIds = new int[] { 48, 15 }
                },
                new Node
                {
                    Id = 46,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 47,
                    SuccessorIds = new int[] { 49, 23 }
                },
                new Node
                {
                    Id = 48,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 49,
                    SuccessorIds = new int[] { 38, 46 }
                },
                new Node
                {
                    Id = 50,
                    SuccessorIds = new int[] { 16, 54 }
                },
                new Node
                {
                    Id = 51,
                    SuccessorIds = new int[] { 42, 36 }
                },
                new Node
                {
                    Id = 52,
                    SuccessorIds = new int[] { 41, 56 }
                },
                new Node
                {
                    Id = 53,
                    SuccessorIds = new int[] { 3, 19 }
                },
                new Node
                {
                    Id = 54,
                    SuccessorIds = new int[]{ 6, 28 }
                },
                new Node
                {
                    Id = 55,
                    SuccessorIds = new int[] { 42, 36 }
                },
                new Node
                {
                    Id = 56,
                    SuccessorIds = new int[] { 29, 4 }
                }
            };

            iGraph.PrepareSuccessors();
            var HasCycle = false;
            var Result = TopologicalSorter.Sort(iGraph.Nodes, iNode => iNode.Successors, out HasCycle);

            //  1, 26, 44, 55, 34, 37, 31, 51, 36, 42,
            // 47, 23, 33, 24, 40, 22, 20, 43, 53, 45,
            // 15, 48, 49, 46, 38, 52, 56,  4, 19,  3,
            // 29, 35, 18,  7, 21, 10, 25, 50, 54, 16,
            // 28,  6, 41,  9, 32, 30, 17, 13, 12, 27,
            //  8, 14, 39, 11,  5,  2

            Assert.IsTrue(IsTopologicalSort(Result, iNode => iNode.Successors));
        }

        [TestMethod]
        public void Instance02Test()
        {
            var iGraph = new Graph();
            iGraph.Nodes = new Node[]
            {
                new Node
                {
                    Id = 1,
                    SuccessorIds = new int[] { 29, 40 }
                },
                new Node
                {
                    Id = 2,
                    SuccessorIds = new int[] { 19, 26 }
                },
                new Node
                {
                    Id = 3,
                    SuccessorIds = new int[] { 51, 54 }
                },
                new Node
                {
                    Id = 4,
                    SuccessorIds = new int[] { 9, 16 }
                },
                new Node
                {
                    Id = 5,
                    SuccessorIds = new int[] { 38, 42 }
                },
                new Node
                {
                    Id = 6,
                    SuccessorIds = new int[] { 18, 32 }
                },
                new Node
                {
                    Id = 7,
                    SuccessorIds = new int[] { 12, 27 }
                },
                new Node
                {
                    Id = 8,
                    SuccessorIds = new int[] { 4, 36 }
                },
                new Node
                {
                    Id = 9,
                    SuccessorIds = new int[] { 14, 30 }
                },
                new Node
                {
                    Id = 10,
                    SuccessorIds = new int[] {} // win
                },
                new Node
                {
                    Id = 11,
                    SuccessorIds = new int[] { 2, 23 }
                },
                new Node
                {
                    Id = 12,
                    SuccessorIds = new int[] { 31, 39 }
                },
                new Node
                {
                    Id = 13,
                    SuccessorIds = new int[] { 19, 26 }
                },
                new Node
                {
                    Id = 14,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 15,
                    SuccessorIds = new int[] { 8, 48 }
                },
                new Node
                {
                    Id = 16,
                    SuccessorIds = new int[] { 11, 53 }
                },
                new Node
                {
                    Id = 17,
                    SuccessorIds = new int[] { 7, 33 }
                },
                new Node
                {
                    Id = 18,
                    SuccessorIds = new int[] { 45, 52 }
                },
                new Node
                {
                    Id = 19,
                    SuccessorIds = new int[]{ 46, 35 }
                },
                new Node
                {
                    Id = 20,
                    SuccessorIds = new int[] { 24, 49 }
                },
                new Node
                {
                    Id = 21,
                    SuccessorIds = new int[] { 26, 27 }
                },
                new Node
                {
                    Id = 22,
                    SuccessorIds = new int[] { 3, 20 }
                },
                new Node
                {
                    Id = 23,
                    SuccessorIds = new int[] { 19, 26 }
                },
                new Node
                {
                    Id = 24,
                    SuccessorIds = new int[] { 38, 42 }
                },
                new Node
                {
                    Id = 25,
                    SuccessorIds = new int[] {} // win
                },
                new Node
                {
                    Id = 26,
                    SuccessorIds = new int[] { 46, 56 }
                },
                new Node
                {
                    Id = 27,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 28,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 29,
                    SuccessorIds = new int[] { 47, 15 }
                },
                new Node
                {
                    Id = 30,
                    SuccessorIds = new int[] { 13, 21 }
                },
                new Node
                {
                    Id = 31,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 32,
                    SuccessorIds = new int[] { 22, 41 }
                },
                new Node
                {
                    Id = 33,
                    SuccessorIds = new int[] { 12, 27 }
                },
                new Node
                {
                    Id = 34,
                    SuccessorIds = new int[] { 28, 55 }
                },
                new Node
                {
                    Id = 35,
                    SuccessorIds = new int[] { 10, 44 }
                },
                new Node
                {
                    Id = 36,
                    SuccessorIds = new int[] { 3, 20 }
                },
                new Node
                {
                    Id = 37,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 38,
                    SuccessorIds = new int[] { 12, 27 }
                },
                new Node
                {
                    Id = 39,
                    SuccessorIds = new int[] { 10 }
                },
                new Node
                {
                    Id = 40,
                    SuccessorIds = new int[] { 6, 34 }
                },
                new Node
                {
                    Id = 41,
                    SuccessorIds = new int[] { 3, 20 }
                },
                new Node
                {
                    Id = 42,
                    SuccessorIds = new int[] { 12, 27 }
                },
                new Node
                {
                    Id = 43,
                    SuccessorIds = new int[] { 5, 17 }
                },
                new Node
                {
                    Id = 44,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 45,
                    SuccessorIds = new int[] { 9, 43 }
                },
                new Node
                {
                    Id = 46,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 47,
                    SuccessorIds = new int[] { 50, 37 }
                },
                new Node
                {
                    Id = 48,
                    SuccessorIds = new int[] { 4, 36 }
                },
                new Node
                {
                    Id = 49,
                    SuccessorIds = new int[] { 13, 21 }
                },
                new Node
                {
                    Id = 50,
                    SuccessorIds = new int[] { 45, 52 }
                },
                new Node
                {
                    Id = 51,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 52,
                    SuccessorIds = new int[] { 9, 16 }
                },
                new Node
                {
                    Id = 53,
                    SuccessorIds = new int[] { 49, 23 }
                },
                new Node
                {
                    Id = 54,
                    SuccessorIds = new int[] { 7, 33 }
                },
                new Node
                {
                    Id = 55,
                    SuccessorIds = new int[] { 22, 41 }
                },
                new Node
                {
                    Id = 56,
                    SuccessorIds = new int[] { 10, 25 }
                }
            };
            iGraph.PrepareSuccessors();
            var HasCycle = false;
            var Result = TopologicalSorter.Sort(iGraph.Nodes, iNode => iNode.Successors, out HasCycle);

            // generated result

            //  1, 40, 34, 55, 28,  6, 32, 41, 22, 18,
            // 29, 15, 48,  8, 36, 20, 24,  3, 54, 51,
            //  4, 47, 37, 50, 52, 16, 53, 49, 11, 23,
            //  2, 45, 43, 17, 33,  7,  5, 42, 38, 12,
            // 39, 31,  9, 30, 21, 27, 13, 26, 56, 25,
            // 19, 35, 44, 10, 46, 14

            Assert.IsTrue(IsTopologicalSort(Result, iNode => iNode.Successors));
        }

        [TestMethod]
        public void Instance03Test()
        {
            var iGraph = new Graph();
            iGraph.Nodes = new Node[]
            {
                new Node
                {
                    Id = 1,
                    SuccessorIds = new int[] { 23, 34 }
                },
                new Node
                {
                    Id = 2,
                    SuccessorIds = new int[] { 43, 26 }
                },
                new Node
                {
                    Id = 3,
                    SuccessorIds = new int[] { 9, 16 }
                },
                new Node
                {
                    Id = 4,
                    SuccessorIds = new int[] { 19, 49 }
                },
                new Node
                {
                    Id = 5,
                    SuccessorIds = new int[] { 21, 52 }
                },
                new Node
                {
                    Id = 6,
                    SuccessorIds = new int[] { 5, 14 }
                },
                new Node
                {
                    Id = 7,
                    SuccessorIds = new int[] { 12, 31 }
                },
                new Node
                {
                    Id = 8,
                    SuccessorIds = new int[] { 47, 54 }
                },
                new Node
                {
                    Id = 9,
                    SuccessorIds = new int[] { 24, 37 }
                },
                new Node
                {
                    Id = 10,
                    SuccessorIds = new int[] { 2, 46 }
                },
                new Node
                {
                    Id = 11,
                    SuccessorIds = new int[] { 3, 25 }
                },
                new Node
                {
                    Id = 12,
                    SuccessorIds = new int[] { 8, 20 }
                },
                new Node
                {
                    Id = 13,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 14,
                    SuccessorIds = new int[] { 21, 52 }
                },
                new Node
                {
                    Id = 15,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 16,
                    SuccessorIds = new int[] { 6, 44 }
                },
                new Node
                {
                    Id = 17,
                    SuccessorIds = new int[] { 35, 40 }
                },
                new Node
                {
                    Id = 18,
                    SuccessorIds = new int[] { 42, 55 }
                },
                new Node
                {
                    Id = 19,
                    SuccessorIds = new int[] { 10, 33 }
                },
                new Node
                {
                    Id = 20,
                    SuccessorIds = new int[] { 13, 54 }
                },
                new Node
                {
                    Id = 21,
                    SuccessorIds = new int[] { 30, 53 }
                },
                new Node
                {
                    Id = 22,
                    SuccessorIds = new int[] { 9, 56 }
                },
                new Node
                {
                    Id = 23,
                    SuccessorIds = new int[] { 4, 41 }
                },
                new Node
                {
                    Id = 24,
                    SuccessorIds = new int[] { 27, 32 }
                },
                new Node
                {
                    Id = 25,
                    SuccessorIds = new int[] { 16, 56 }
                },
                new Node
                {
                    Id = 26,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 27,
                    SuccessorIds = new int[] { 21, 52 }
                },
                new Node
                {
                    Id = 28,
                    SuccessorIds = new int[] { 2, 56 }
                },
                new Node
                {
                    Id = 29,
                    SuccessorIds = new int[] { 11, 51 }
                },
                new Node
                {
                    Id = 30,
                    SuccessorIds = new int[] { 50 }
                },
                new Node
                {
                    Id = 31,
                    SuccessorIds = new int[] { 8, 20 }
                },
                new Node
                {
                    Id = 32,
                    SuccessorIds = new int[] { 21, 52 }
                },
                new Node
                {
                    Id = 33,
                    SuccessorIds = new int[] { 46, 56 }
                },
                new Node
                {
                    Id = 34,
                    SuccessorIds = new int[] { 18, 29 }
                },
                new Node
                {
                    Id = 35,
                    SuccessorIds = new int[] { 8, 20 }
                },
                new Node
                {
                    Id = 36,
                    SuccessorIds = new int[] { 10, 28 }
                },
                new Node
                {
                    Id = 37,
                    SuccessorIds = new int[] { 27, 32 }
                },
                new Node
                {
                    Id = 38,
                    SuccessorIds = new int[] { 12, 31 }
                },
                new Node
                {
                    Id = 39,
                    SuccessorIds = new int[] {} // win
                },
                new Node
                {
                    Id = 40,
                    SuccessorIds = new int[] { 8, 20 }
                },
                new Node
                {
                    Id = 41,
                    SuccessorIds = new int[] { 15, 36 }
                },
                new Node
                {
                    Id = 42,
                    SuccessorIds = new int[] { 22, 56 }
                },
                new Node
                {
                    Id = 43,
                    SuccessorIds = new int[] { 35, 40 }
                },
                new Node
                {
                    Id = 44,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 45,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 46,
                    SuccessorIds = new int[] { 7, 38 }
                },
                new Node
                {
                    Id = 47,
                    SuccessorIds = new int[] { 39, 50 }
                },
                new Node
                {
                    Id = 48,
                    SuccessorIds = new int[] { 5, 14 }
                },
                new Node
                {
                    Id = 49,
                    SuccessorIds = new int[] { 33, 56 }
                },
                new Node
                {
                    Id = 50,
                    SuccessorIds = new int[] {} // win
                },
                new Node
                {
                    Id = 51,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 52,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 53,
                    SuccessorIds = new int[] {} // lose
                },
                new Node
                {
                    Id = 54,
                    SuccessorIds = new int[] { 39, 45 }
                },
                new Node
                {
                    Id = 55,
                    SuccessorIds = new int[] { 22, 3 }
                },
                new Node
                {
                    Id = 56,
                    SuccessorIds = new int[] { 17, 48 }
                }
            };
            iGraph.PrepareSuccessors();
            var HasCycle = false;
            var Result = TopologicalSorter.Sort(iGraph.Nodes, iNode => iNode.Successors, out HasCycle);

            // generated result

            //  1, 34, 29, 51, 11, 25, 18, 55,  3, 16,
            // 44,  6, 42, 22,  9, 37, 24, 32, 27, 23,
            // 41, 36, 28, 15,  4, 49, 19, 33, 56, 48,
            // 14,  5, 52, 21, 53, 30, 17, 10, 46, 38,
            //  7, 31, 12,  2, 26, 43, 40, 35, 20, 13,
            //  8, 54, 45, 47, 50, 39

            Assert.IsTrue(IsTopologicalSort(Result, iNode => iNode.Successors));
        }

        [TestMethod]
        public void Instance04Test()    // aus Sedgewick: Algorithmen, Abb. 32.8, S. 543
        {
            var iGraph = new Graph();
            iGraph.Nodes = new Node[]
            {
                new Node    // A
                {
                    Id = 1,
                    SuccessorIds = new int[] { 6, 2, 3, 7 }
                },
                new Node    // B
                {
                    Id = 2,
                    SuccessorIds = new int[] {}
                },
                new Node    // C
                {
                    Id = 3,
                    SuccessorIds = new int[] {}
                },
                new Node    // D
                {
                    Id = 4,
                    SuccessorIds = new int[] {}
                },
                new Node    // E
                {
                    Id = 5,
                    SuccessorIds = new int[] { 4 }
                },
                new Node    // F
                {
                    Id = 6,
                    SuccessorIds = new int[] { 4, 5 }
                },
                new Node    // G
                {
                    Id = 7,
                    SuccessorIds = new int[] { 3, 5, 8 }
                },
                new Node    // H
                {
                    Id = 8,
                    SuccessorIds = new int[] { 9 }
                },
                new Node    // I
                {
                    Id = 9,
                    SuccessorIds = new int[] {}
                },
                new Node    // J
                {
                    Id = 10,
                    SuccessorIds = new int[] { 7, 11, 12, 13 }
                },
                new Node    // K
                {
                    Id = 11,
                    SuccessorIds = new int[] {}
                },
                new Node    // L
                {
                    Id = 12,
                    SuccessorIds = new int[] { 7, 13 }
                },
                new Node    // M
                {
                    Id = 13,
                    SuccessorIds = new int[] {}
                }
            };
            iGraph.PrepareSuccessors();
            var HasCycle = false;
            var Result = TopologicalSorter.Sort(iGraph.Nodes, iNode => iNode.Successors, out HasCycle);

            // generated result

            // 10 (J), 12 (L), 13 (M), 11 (K), 1 (A),
            //  7 (G),  8 (H),  9 (I),  3 (C), 2 (B),
            //  6 (F),  5 (E),  4 (D)

            // dfs visiting sequence

            //  1 (A),  6 (F),  4 (D),  5 (E),   2 (B),
            //  3 (C),  7 (G),  8 (H),  9 (I),  10 (J),
            // 11 (K), 12 (L), 13 (M)

            Assert.IsTrue(IsTopologicalSort(Result, iNode => iNode.Successors));
        }

    }
}
