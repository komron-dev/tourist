using System;
namespace tourist
{
	abstract class Wonder
	{
		protected int x { get; }
		protected int y { get; }
		protected int interest { get; }
		protected int built { get; }

		private Guide guide;

		protected Wonder(int x, int y, int i, int b)
		{
			this.x = x;
			this.y = y;
			interest = i;
			built = b;
		}

		public abstract string GetType();

		public virtual int ExpectedTime() {
            int g;
            if (guide == null) g = 1;
            else g = 1 + guide.GetTalkative();

            return Factor() * interest * g;
        }

		protected abstract int Factor();

		private int Distance(Wonder w1, Wonder w2)
		{
			return Math.Abs(w1.x - w2.x) + Math.Abs(w1.y - w2.y);
        }

		public int Farthest(List<Wonder> ws)
		{
			if (ws.Count == 0) throw new Exception("There are no wonders");

			int farthest = 0;
			foreach (Wonder w in ws)
			{
				int d = Distance(w, this);
				if (farthest < d)
				{
                    farthest = d;
				}
			}

			return farthest;
		}

		public void SetGuide(Guide g) { guide = g; }

		public int GetX() { return x; }
        public int GetY() { return y; }
    }

    class Cathedral : Wonder
	{
		public Cathedral(int x, int y, int i, int b) : base(x, y, i, b) { }

		public override string GetType() { return "cathedral"; }

		protected override int Factor() { return (2023 - built) + 5; }
 	}

    class Museum : Wonder
    {
        public Museum(int x, int y, int i, int b) : base(x, y, i, b) { }

        public override string GetType() { return "museum"; }

        protected override int Factor() { return 10000 / (x * x + y * y + 1); }
    }

    class Castle : Wonder
    {
        public Castle(int x, int y, int i, int b) : base(x, y, i, b) { }

        public override string GetType() { return "castle"; }

        protected override int Factor() { return (2023 - built) * 2; }
    }

}

