using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Elements.Junior
{
	abstract class JElement : Element
	{
		public JElement()
		{
			ManaCost = 1;
			Damage = 5;
		}

	}
}
