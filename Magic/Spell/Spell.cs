using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Elements;

namespace Magic.Spell
{
	class Spell : IMagic
	{
		#region properties
		#region parent

		public string Name { get; protected set; }
		public int ManaCost { get; protected set; }

		#endregion
		#region elements

		protected Dictionary<System.Type, int> Elements { get; private set; }
		protected int MinManaCost { get; set; }

		#endregion

		public int Impulse { get; set; }
		//public int 

		#endregion

		public Spell(string name, int manaCost)
		{
			Name = name;
			ManaCost = manaCost;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
