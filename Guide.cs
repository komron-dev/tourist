using System;
namespace tourist
{
	class Guide
	{
		private string name { get; }
		private int talkative { get; }

		public Guide(string n, int t)
		{
			name = n;
			talkative = t;
		}

		public int GetTalkative() { return talkative; }
	}
}

