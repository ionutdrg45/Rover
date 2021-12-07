using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    class Rover
    {
        private int number;
        private int x;
        private int y;
        private String angleTo;
        private String commands;

        public Rover(int number, int x = 0, int y = 0, String angleTo = "Null", String commands = "Null")
        {
            this.number = number;
            this.x = x;
            this.y = y;
            this.angleTo = angleTo;
            this.commands = commands;
        }

        public int Get_number()
        {
            return number;
        }

        public int Get_x() { 
            return x; 
        }
        public int Get_y()
        {
            return y;
        }
        public String Get_angleTo()
        {
            return angleTo;
        }

        public String Get_commands()
        {
            return commands;
        }

        public void RotateTo(char command)
        {
            if(command == 'L')
            {
                switch (angleTo)
                {
                    case "N":
                        angleTo = "V";
                        break;

                    case "V":
                        angleTo = "S";
                        break;
                    case "S":
                        angleTo = "E";
                        break;
                    case "E":
                        angleTo = "N";
                        break;
                }
            }
            else if (command == 'R')
            {
                switch (angleTo)
                {
                    case "N":
                        angleTo = "E";
                        break;

                    case "E":
                        angleTo = "S";
                        break;
                    case "S":
                        angleTo = "V";
                        break;
                    case "V":
                        angleTo = "N";
                        break;
                }
            }
        }

        public void Move(int line, int col)
        {
            switch (angleTo)
            {
                case "N":
                    if(y + 1 < line) y = y + 1;
                    break;

                case "E":
                    if(x+1 < col) x = x + 1;
                    break;
                case "S":
                    if(y - 1 >= 0) y = y - 1;
                    break;
                case "V":
                    if(x - 1 >= 0) x = x - 1;
                    break;
            }
        }
    }
}
