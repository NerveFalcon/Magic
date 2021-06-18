using System;
using Magic.Physics;

namespace Magic
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = new Point(1, 2, 3);
			var b = new Point(1, 2, 5);
			
			var c = new Point(1, 2, 4);

			var v = new Vector(a, b);
			if (v.Contains(c))
			{
				Console.WriteLine("содержит");
			}
			else
			{
				Console.WriteLine("не содержит");
			}
		}
	}
}
