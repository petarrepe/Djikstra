using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjikstraDLL.Moje
{
    public class Graph
    {
        public List<Vertex> vertices = new List<Vertex>();

        public void AddVertice(Vertex v)
        {
            vertices.Add(v);
        }
        public Vertex FindVertex(string data)
        {
            return vertices.Where(t => t._data == data).First();
        }
    }
}
