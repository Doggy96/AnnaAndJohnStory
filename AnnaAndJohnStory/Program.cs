using AnnaAndJohnStory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnaAndJohnStory
{
	class Program
	{
		static void Main(string[] args)
		{
			Anna anna = new Anna();
			John john = new John();
			House house = new House();

			anna.Mandalo();
			john.Question();
			anna.Answear();
			house.Door();
			house.LeavesTheHouse();
			house.CloseTheDoor();
			




		}
	}
}
