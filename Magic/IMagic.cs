using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic
{
	public interface IMagic
	{
		string Name { get; }
		int ManaCost { get; }

		public string ToString();
	}
}
