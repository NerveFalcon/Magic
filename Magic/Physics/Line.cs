using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Physics
{
	class Line
	{
		public double Begin { get; }
		public double End { get; }

		public Line(double begin, double end)
		{
			(this.Begin, this.End) = Compare(begin, end);
		}

		public bool Contains(double point)
		{
			return point >= Begin && point <= End;
		}

		private (double less, double more) Compare(double a, double b)
		{
			if (a > b)
			{
				return (b, a);
			}
			else
			{
				return (a, b);
			}
		}
	}
}
