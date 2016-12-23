using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjikstraDLL.Moje
{
    public class WeightedEdge
    {
        public Vertex _source;
        public Vertex _destination;
        public int _cost;

        public WeightedEdge(Vertex source, Vertex destination, int cost)
        {
            _source = source;
            _destination = destination;
            _cost = cost;
        }
        
    }
}
