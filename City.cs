using System;
using System.Diagnostics.Metrics;

namespace tourist
{
	class City
	{
		private List<District> ds = new();


		public City(List<District> dss)
		{
			foreach (District d in dss)
			{
				if (ds.Contains(d)) throw new Exception("The given district is already in the city");
				ds.Add(d);
			}
		}

		public District? WhichDistrict(Wonder w)
		{
			foreach (District d in ds)
			{
				if (d.GetWs().Contains(w)) return d;
			}

			return null;
		}

		public District MaxTotalTime()
		{
			int max = 0;
			District maxDist = null;
			foreach (District d in ds)
			{
				if (max < d.TotalTime())
				{
					max = d.TotalTime();
					maxDist = d;
				}
			}

            return maxDist;
        }

		public bool CathedralEverywhere()
		{
			foreach (District d in ds)
			{
				if (d.Cathedrals() > 0) continue;
				else return false;
			}

			return true;
		}
		// getters
        public List<District> GetDs() { return ds; }

    }
}

