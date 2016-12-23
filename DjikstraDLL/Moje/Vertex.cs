using System.Collections.Generic;

namespace DjikstraDLL.Moje
{
    public class Vertex
    {
        public string _data;
        public LinkedList<Vertex> _pointsTo;
        public LinkedList<int> _costs;

        public Vertex(string data, LinkedList<Vertex> neighbors, LinkedList<int> costs)
        {
            _data = data;
            _pointsTo = neighbors;
            _costs = costs;
        }
    }

}
