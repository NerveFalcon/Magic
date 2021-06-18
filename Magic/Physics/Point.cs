using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Physics
{
	struct Point
	{
		public double X { get; private set; }
		public double Y { get; private set; }
		public double Z { get; private set; }

		public Point(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public Point Move(double x, double y, double z) => new(X += x, Y += y, Z += z);

		public override string ToString() => $"({X}:{Y}:{Z})";
	}
}
