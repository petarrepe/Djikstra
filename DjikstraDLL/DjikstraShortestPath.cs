//using DjikstraDLL;
//using DjikstraDLL.Github;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DjikstraDLL
//{
//    public class DjikstraShortestPath<TGraph, TVertex>
//        where TGraph : IGraph<TVertex>, IWeightedGraph<TVertex>
//        where TVertex : IComparable<TVertex>
//    {
//        /// <summary>
//        /// INSTANCE VARIABLES
//        /// </summary>
//        private int _edgesCount;
//        private int _verticesCount;
//        private long[] _distances;
//        private int[] _predecessors;
//        private WeightedEdge<TVertex>[] _edgeTo;

//        // A dictionary that maps node-values to integer indeces
//        private Dictionary<TVertex, int> _nodesToIndices;

//        // A dictionary that maps integer index to node-value
//        private Dictionary<int, TVertex> _indicesToNodes;

//        // A const that represent an infinite distance
//        private const Int64 Infinity = Int64.MaxValue;
//        private const int NilPredecessor = -1;


//        /// <summary>
//        /// CONSTRUCTOR
//        /// </summary>
//        /// <param name="Graph"></param>
//        public DjikstraShortestPath(IGraph<T> Graph, TVertex Source)
//        {
//            //if (Graph == null)
//            //    throw new ArgumentNullException();
//            //else if (!Graph.HasVertex(Source))
//            //    throw new ArgumentException("The source vertex doesn't belong to graph.");

//            // Init
//            _initializeDataMembers(Graph);

//            // Traverse the graph
//            _dijkstra(Graph, Source);

//        }

//        private void _initializeDataMembers(IGraph<T> graph)
//        {
//            throw new NotImplementedException();
//        }

//        private void _dijkstra<T>(IGraph<T> graph, TVertex source)
//        {
//            throw new NotImplementedException();
//        }

//    }
//}
