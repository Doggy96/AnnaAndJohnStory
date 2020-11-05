using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnaAndJohnStory.Model
{
	class House :John
	{
		public House()
		{

		}

		public void Door()
		{
			Console.WriteLine("Opens the door");
		}

		public void LeavesTheHouse()
		{
			Console.WriteLine("John gets out of the house");
		}

		public void CloseTheDoor()
		{
			Console.WriteLine("John Closes the door and leaves with Anna");
		}


	}
}
