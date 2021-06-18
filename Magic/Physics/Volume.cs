using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Physics
{
	struct Volume
	{
		public Volume(Point center, int radius, bool elipse = true)
		{
			Center = center;
			RadiusX = RadiusY = RadiusZ = radius;
			this.elipse = elipse;
		}
		public Volume(Point center, int radiusX, int radiusY, int radiusZ, bool elipse = true)
		{
			Center = center;
			RadiusX = radiusX;
			RadiusY = radiusY;
			RadiusZ = radiusZ;
			this.elipse = elipse;
		}

		public Point Center { get; private set; }

		private readonly bool elipse;

		public bool IsSphere()
		{
			return elipse;
		}

		public bool Contains(Point point)
		{
			if (IsSphere())
			{
				return InElipse(point);
			}
			else
			{
				return Inparallelepiped(point);
			}
		}
		private bool InElipse(Point point)
		{
			bool xy = true;
			bool yz = true;
			bool zx = true;
			return xy && yz && zx;
		}
		private bool Inparallelepiped(Point point)
		{
			bool x = new Line(Center.X + RadiusX, Center.X - RadiusX).Contains(point.X);
			bool y = new Line(Center.Y + RadiusY, Center.Y - RadiusY).Contains(point.Y);
			bool z = new Line(Center.Z + RadiusZ, Center.Z - RadiusZ).Contains(point.Z);
			return x && y && z;
		}


		public int RadiusX { get; private set; }
		public int RadiusY { get; private set; }
		public int RadiusZ { get; private set; }
	}
}
