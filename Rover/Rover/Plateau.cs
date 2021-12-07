using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    class Plateau
    {
        private int line;
        private int col;

        public Plateau(int line = 0, int col = 0)
        {
            this.line = line;
            this.col = col;
        }

        public void MoveRover(Rover rover)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Rover #" + rover.Get_number() + " start from (" + rover.Get_x() + ", " + rover.Get_y() + ") and is oriented to: " + rover.Get_angleTo() + ": ");
            var commands = rover.Get_commands().ToCharArray();
            foreach (char command in commands)
            {
                if (command == 'L' || command == 'R') rover.RotateTo(command);
                else if(command == 'M')
                {
                    rover.Move(line, col);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Rover position is now: (" + rover.Get_x() + ", " + rover.Get_y() + ") and is oriented to: " + rover.Get_angleTo() + "\n");
        }
    }
}
