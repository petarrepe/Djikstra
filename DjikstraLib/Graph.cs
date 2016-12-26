using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DjikstraLib
{
    public class Graph<T>
    {
        List<Vertex> vertices = new List<Vertex>();
        int[,] weightedEdges = new int[10, 10];

        public Graph(int[,] adjMatrix)
        {

            char alphabet = 'A';
            weightedEdges = adjMatrix;

            for (int i = 0; i < adjMatrix.GetLength(0); i++)
            {
                List<Vertex> listOfAdjecentVertices = new List<Vertex>();
                List<int> listOfCosts = new List<int>();
                Vertex v = new Vertex();
                
                for(int j=0; j < adjMatrix.GetLength(0); j++)
                {
                    if (adjMatrix[i, j] == 0) continue;
                    else
                    {
                        listOfAdjecentVertices.Add(new Vertex(((Convert.ToChar(65 + j)))));
                        listOfCosts.Add(adjMatrix[i, j]);
                    }
                }

                v._data = alphabet.ToString();
                v._neighbors = listOfAdjecentVertices;
                v._costToNeighbors = listOfCosts;
                vertices.Add(v);

                alphabet++;
            }

        }

        public string DjikstraShortestPath(int indexOfSourceVertex, int indexOfEndVertex)
        {
            Vertex source = vertices.Find(t => t._data == Convert.ToChar(indexOfSourceVertex + 65).ToString());
            Vertex destination = vertices.Find(t => t._data == Convert.ToChar(indexOfEndVertex + 65).ToString());
            Vertex currentlyVisitedNode = source;
            List<Vertex> visitedNodes = new List<Vertex>();

            int[] distances = CreateAndInitializeDistancesArray(); //elements set to maximum values;
            char[] indexWhichSetMinDistance =  new char[vertices.Count]; //za jednostavno izračunavanje puta
            while (currentlyVisitedNode != destination)
            {
                UpdateDistances(ref distances, currentlyVisitedNode, source, ref indexWhichSetMinDistance);
                visitedNodes.Add(currentlyVisitedNode);
                currentlyVisitedNode = ChooseNextNode(distances, visitedNodes);
            }
            string shorttestPathFormatted = PrintShortestPath(indexWhichSetMinDistance, indexOfEndVertex, indexOfSourceVertex);

            return shorttestPathFormatted;
        }

        private string PrintShortestPath(char[] indexWhichSetMinDistance, int indexOfEndVertex, int indexOfSourceVertex)
        {
            StringBuilder sb = new StringBuilder();
            char endVertex = Convert.ToChar(indexOfEndVertex + 65);
            List<char> list = new List<char>();
            char nextVertex;

            for (int i = indexOfEndVertex; i > 0; )
            {
                nextVertex = indexWhichSetMinDistance[i];
                list.Add(nextVertex);

                if (i == indexOfSourceVertex) break;
                i = nextVertex - 65;
            }
            for (int i = list.Count - 1; i >= 0; i--)
            {
                sb.Append(list[i] + "->");
            }

            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }

        private Vertex ChooseNextNode(int[] distances, List<Vertex> visitedNodes)
        {
            Vertex nextNode = new Vertex();
            List<int> visited = new List<int>();
            List<int> remainingNodes = new List<int>();
            int minValue = int.MaxValue;
            int indexOfMinValue=0;

            foreach (var vertex in visitedNodes)
            {
                visited.Add(Convert.ToChar(vertex._data) - 65);
            }

            for (int i = 0; i < distances.Length; i++)
            {
                if (visited.Contains(i)) continue;
                else remainingNodes.Add(i);
            }

            for (int i = 0; i < remainingNodes.Count; i++)
            {
                if (distances[remainingNodes[i]] < minValue)
                {
                    minValue = distances[remainingNodes[i]];
                    indexOfMinValue = remainingNodes[i];
                }
            }

            nextNode = vertices.Find(t => t._data == Convert.ToChar(indexOfMinValue + 65).ToString());
            return nextNode;
        }

        private void UpdateDistances(ref int[] distances, Vertex curr, Vertex source, ref char[] indexesOfShortestPath)
        {
            var index = Convert.ToChar(curr._data) - 65;
            for (int i = 0; i < curr._neighbors.Count; i++)
            {
                int neighbourIndex = Convert.ToChar(curr._neighbors[i]._data)-65;
                if (curr._data == source._data) //prvi prolaz kroz petlju glavnog programa
                {
                    distances[index] = 0;
                    distances[neighbourIndex] = curr._costToNeighbors[i];

                    indexesOfShortestPath[index] = (char)(index + 65);
                    indexesOfShortestPath[neighbourIndex] = (char)(index + 65);
                }
                else if (distances[neighbourIndex] > curr._costToNeighbors[i] + distances[Convert.ToChar(curr._data) - 65])
                {
                    distances[neighbourIndex] = curr._costToNeighbors[i] + distances[Convert.ToChar(curr._data) - 65];

                    indexesOfShortestPath[neighbourIndex] = (char)(index+65);
                }
            }
        }

        private int[] CreateAndInitializeDistancesArray()
        {
            int[] dist = new int[vertices.Count];

            for (int i = 0; i < dist.Length; i++)
            {
                dist[i] = int.MaxValue;
            }

            return dist;
        }
    }
}
