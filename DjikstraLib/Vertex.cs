using System.Collections.Generic;

namespace DjikstraLib
{
    public class Vertex
    {
        internal string _data;
        internal List<Vertex> _neighbors = new List<Vertex>();
        internal List<int> _costToNeighbors = new List<int>();
        public Vertex()
        {

        }
        public Vertex(char data)
        {
            _data = data.ToString();
        }
    }
}
