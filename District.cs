using System;
using System.Diagnostics.Metrics;

namespace tourist
{
	class District
	{
		private string name { get; }
		private List<Wonder> ws = new();
		public District(string n, List<Wonder> wss)
		{
			name = n;
			foreach (var w in wss)	
			{
                if (ws.Contains(w)) throw new Exception("Given wonder is already in the district");
				ws.Add(w);
			}
		}

		public int MaxDistance()
		{
			if (ws.Count == 0) throw new Exception("There are no wonders");

            int maxDistance = 0;
            foreach (Wonder w in ws)
            {
                int d = w.Farthest(ws);
                if (maxDistance < d)
                {
                    maxDistance = d;
                }
            }

            return maxDistance;
        }

		public int Cathedrals()
		{
			int counter = 0;

			foreach (Wonder w in ws)
			{
				if (w.GetType() == "cathedral") counter++;
			}

			return counter;
		}

		public int TotalTime()
		{
			int total = 0;

            foreach (Wonder w in ws)
            {
				total += w.ExpectedTime();
            }

            return total;
        }

		// getters

		public string GetName() { return name;  }
		public List<Wonder> GetWs() { return ws; }
	}
}

