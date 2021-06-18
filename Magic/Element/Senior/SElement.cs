using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Elements.Senior
{
	abstract class SElement : Element
	{
		public SElement() : base()
		{
			ManaCost = 2;
			Damage = 0;
		}
	}
}
