using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Spravochnik_na_Puteshestvenika
{
    public class Edge
    {
        public int numedge, to, length, time, price;
        public Edge()
        {
            this.numedge = 0;
            this.to = 0;
            this.length = 0;
            this.time = 0;
            this.price = 0;
        }

        public Edge(int _numedge, int _to, int _length, int _time, int _price)
        {
            this.numedge = _numedge;
            this.to = _to;
            this.length = _length;
            this.time = _time;
            this.price = _price;
        }

        public static bool operator <(Edge c, Edge d)
        {
            return c.numedge < d.numedge;
        }
        public static bool operator >(Edge c, Edge d)
        {
            return c.numedge > d.numedge;
        }

        public override int GetHashCode()
        {
            return numedge;
        }
    }

    public class InfoEdge
    {
        int numedge, city1, city2;

        public InfoEdge()
        {
            this.numedge = -1;
            this.city1 = -1;
            this.city2 = -1;
        }

        public InfoEdge(int _numedge, int _city1, int _city2)
        {
            this.numedge = _numedge;
            this.city1 = _city1;
            this.city2 = _city2;
        }

        public override int GetHashCode()
        {
            return numedge;
        }
    }

}
