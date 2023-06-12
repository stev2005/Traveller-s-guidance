using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Spravochnik_na_Puteshestvenika
{

    public class Graph
    {
        const int inf = (1 << 30);
        public Dictionary<string, int> cities;
        public HashSet<InfoEdge> roads;
        //public Dictionary<int, SortedSet<Edge>> v;
        public Dictionary<int, HashSet<Edge>> v;
        public HashSet<int> unavailable_nodes;
        public HashSet<int> unavailable_edges;
        //public Dictionary<int, int> distances;
        private int nextNodeNum;
        private int nextEdgeNum;

        private int GetAdd(Edge e, int way)
        {
            if (way == 1) return e.length;
            if (way == 2) return e.time;
            if (way == 3) return e.price;
        }

        public Graph()
        {
            this.cities = new Dictionary<string, int>();
            //this.v = new Dictionary<int, SortedSet<Edge>>();
            this.v = new Dictionary<int, HashSet<Edge>>();
            this.unavailable_nodes = new HashSet<int>();
            this.unavailable_edges = new HashSet<int>();
            //this.distances = new Dictionary<int, int>();
            this.nextEdgeNum = 0;
            this.nextNodeNum = 0;
        }

        public Graph(Dictionary<string, int> _cities, Dictionary<int, HashSet<Edge>> _v,
                     HashSet<int> _unavailable_nodes, HashSet<int> _unavailable_edges)
        {
            this.cities = _cities;
            //this.v = new Dictionary<int, SortedSet<Edge>>();
            this.v = _v;
            this.unavailable_nodes = _unavailable_nodes;
            this.unavailable_edges = _unavailable_edges;
            //this.distances = new Dictionary<int, int>();
            this.nextEdgeNum = 0;
            this.nextNodeNum = 0;
        }

        private int GetNodeNum()
        {
            nextNodeNum++;
            return nextNodeNum;
        }

        private int GetEdgeNum()
        {
            nextEdgeNum++;
            return nextEdgeNum;
        }

        public void AddCity(string name)
        {
            int numcity = cities[name];
            if (numcity == 0)
                cities[name] = GetNodeNum();
        }

        public void AddRoad(string name1, string name2, int _lenght, int _time, int _price)
        {
            int city1 = cities[name1];
            int city2 = cities[name2];
            if (city1 > city2)
            {
                city1 ^= city2;
                city2 ^= city1;
                city1 ^= city2;
            }
            int numedge = GetEdgeNum();
            InfoEdge road = new InfoEdge(numedge, city1, city2);
            roads.Add(road);
            Edge e = new Edge(numedge, city2, _lenght, _time, _price);
            v[city1].Add(e);
            e.to = city1;
            v[city2].Add(e);
        }

        public EditNameCity(string OldName, string NewName)
        {
            int numcity = cities[OldName];
            cities.Remove(OldName);
            cities.Add(NewName, numcity);
        }

        private void ChangeCharacteristic(ref int val1, ref int val2, int newval)
        {
            val1 = newval;
            val2 = newval;
        }

        public EditEdge(int numedge, int par, int val)
        {
            int city1 = roads[numedge].city1;
            int city2 = roads[numedge].city2;
            if (par == 1)
                ChangeCharacteristic(ref v[city1][numedge].length, ref v[city2][numedge].length, val);
            if (par == 2)
                ChangeCharacteristic(ref v[city1][numedge].time, ref v[city2][numedge].time, val);
            if (par == 3)
                ChangeCharacteristic(ref v[city1][numedge].price, ref v[city2][numedge].price, val);
        }

        public void DisableEnableNode(int NumNode)
        {
            if (unavailable_nodes.Contains(NumNode))
                unavailable_nodes.Remove(NumNode);
            else unavailable_nodes.Add(NumNode);
        }

        public void DisableEnableEdge(int NumEdge)
        {
            if (unavailable_edges.Contains(NumEdge))
                unavailable_edges.Remove(NumEdge);
            else unavailable_edges.Add(NumEdge);
        }

        public void DeleteEdge(int NumEdge)
        {
            if (unavailable_edges.Contains(NumEdge))
                unavailable_edges.Remove(NumEdge);
            int city1 = roads[NumEdge].city1;
            int city2 = roads[NumEdge].city2;
            InfoEdge toreminfo = roads[NumEdge];
            roads.Remove(toreminfo);
            Edge toremedge = v[city1][NumEdge];
            v[city1].Remove(toremedge);
            toremedge = v[city2][NumEdge];
            v[city2].Remove(toremedge);
        }

        public void DeleteNode(int NumNode)
        {
            foreach (var path in v[NumNode])
                DeleteEdge(path.numedge);
            if (unavailable_nodes.Contains(NumNode))
                unavailable_nodes.Remove(NumNode);
            v.Remove(NumNode);
        }

        private int Dijkstra(int start, int end, int way)
        {
            /*way: 1, 2, 3
            * 1: sort by length  
            * 2: sort by time
            * 3: sort by price
            */
            Dictionary<int, int> distances = new Dictionary<int, int>();
            HashSet<int> used = new HashSet<int>();
            foreach (var item in cities)
            {
                int city = item.Value;
                distances[city] = (1 << 30);
            }
            /*int start = cities[startstr];
            int end = cities[endstr];*/
            distances[start] = 0;
            int n = v.Count;
            for (int i = 1; i <= n - 2; ++i)
            {
                int ver = -1;
                int mindist = inf;
                foreach (var item in v)
                {
                    int curver = item.Value;
                    if (!used.Contains(curver))
                    {
                        if (mindist > distances[curver])
                        {
                            mindist = distances[curver];
                            ver = curver;
                        }
                    }
                }
                used.Add(ver);
                foreach (var item in v[ver])
                {
                    Edge e = item.Value;
                    int to = e.to;
                    int addval = GetAdd(e, way);

                    if (distances[to] > distances[ver] + addval)
                        distances[to] = distances[ver] + addval;
                }
            }
            return distances[end];
        }
    }

    public int FindShortestDistance(string from, string to, string way)
    {
        int start = cities[from];
        int end = cities[to];
        int iway;
        switch (way)
        {
            case "lenght": iway = 1; break;
            case "time": iway = 2; break;
            case "price": iway = 3; break;
        }
        int rez = Dijkstra(start, end, iway);
        return rez;
    }
}
