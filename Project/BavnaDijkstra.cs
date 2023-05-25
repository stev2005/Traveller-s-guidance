using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
	private int GetAdd(Edge e, int way){
		if (way == 1) return e.length;
		if (way == 2) return e.time;
		if (way == 3) return e.price;
	}
	
	public static void Main()
	{
		const int inf = (1 << 30);
		Dictionary<string, int> cities;
		HashSet<InfoEdge> roads;
        //public Dictionary<int, SortedSet<Edge>> v;
		Dictionary<int, HashSet<Edge>> v;
		HashSet<int> unavailable_nodes;
		HashSet<int> unavailable_edges;
        //public Dictionary<int, int> distances;
        int nextNodeNum;
        int nextEdgeNum;
		int Dijkstra(int start, int end, int way)
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
			int n =  v.Count;
			for (int i = 1; i <= n - 2; ++i){
				int ver = -1;
				int mindist = inf;
				foreach (var item in v){
					int curver = item.Value;
					if (!used.Contains(curver)){
						if (mindist > distances[curver]){
							mindist = distances[curver];
							ver = curver;
						}
					}
				}
				used.Add(ver);
				foreach (var item in v[ver]){
					Edge e = item.Value;
					int to = e.to;
					int addval = GetAdd(e, way)
					if (distances[to] > distances[ver] + addval)
						distances[to] = distances[ver] + addval;
				}
			}
			return distances[end];
        }
	}
}
