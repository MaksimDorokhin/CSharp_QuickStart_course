using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 0;
			Turtle.Speed = 9;
			/*	while (i < 4)
				{
					Turtle.Move(50);
					Turtle.TurnRight();
					Turtle.Move(50);
					Turtle.TurnRight();
					Turtle.Move(50);
					Turtle.TurnLeft();
					Turtle.Move(50);
					Turtle.TurnLeft();
					i++;
				}*/

			while (i < 6)
			{
				Turtle.Move(100);
				Turtle.Turn(60);
				i++;
			}
		}
	}
}
