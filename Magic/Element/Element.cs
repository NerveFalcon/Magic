using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Elements
{
	abstract class Element : IMagic
	{
		public int ManaCost { get; protected set; }
		public int Damage { get; protected set; }
		public string Name { get; protected set; }

		public int Time { get; protected set; }
		public int DmgPerSec { get; protected set; }

		public Element()
		{
			Name = this.GetType().Name;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
