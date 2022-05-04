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
        static void WriteT(int size)
        {
            // Letter T begin
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.TurnLeft();
            Turtle.Move(size - size / 2);
            Turtle.Angle = 90;
            Turtle.Move(size);
            // Letter T end
        }
        static void WriteO(int size)
        {
            // Letter O begin
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
            // Letter O end
        }
        static void WriteP(int size)
        {
            // Letter P begin
            Turtle.Angle = 0;
            Turtle.Move(size / 2);
            WriteO(size / 2);
            // Letter O end
        }
        static void Main(string[] args)
		{
            //Turtle.Speed = 9;
            ///* for(int i = 0; i < 4; i++)
            // {
            //     Turtle.Move(50);
            //     Turtle.TurnRight();
            //     Turtle.Move(50);
            //     Turtle.TurnRight();
            //     Turtle.Move(50);
            //     Turtle.TurnLeft();
            //     Turtle.Move(50);
            //     Turtle.TurnLeft();
            // }*/

            //while (i < 6)
            //{
            //    Turtle.Move(100);
            //    Turtle.Turn(60);
            //    i++;
            //}

            // Tort

            Turtle.Speed = 8;
            Turtle.X = 200;
            Turtle.Y = 200;

            WriteT(60);

            Turtle.X = 240;
            Turtle.Y = 200;

            WriteO(30);

            Turtle.X = 290;
            Turtle.Y = 200;

            WriteP(30); 

            Turtle.X = 340;
            Turtle.Y = 200;

            WriteT(30);

        }
    }
}
