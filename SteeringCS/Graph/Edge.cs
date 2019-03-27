using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteeringCS.Graph
{
    class Edge
    {
        public Node Destination { get; set; }
        public double Cost { get; set; }

        public Edge(Node destination, double cost)
        {
            Destination = destination;
            Cost = cost;
        }

    }
}
