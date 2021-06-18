using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Physics
{
	class Vector
	{
		public Point Begin { get; private set; }
		public Point End { get; private set; }

		public Vector(Point begin, Point end)
		{
			Begin = begin;
			End = end;
		}

		public bool Contains(Point point)
		{
			bool x = new Line(Begin.X, End.X).Contains(point.X);
			bool y = new Line(Begin.Y, End.Y).Contains(point.Y);
			bool z = new Line(Begin.Z, End.Z).Contains(point.Z);
			return x && y && z;
		}
	}
}
