using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFile = "Input.txt";

            Plateau plateau = new Plateau();
            List<Rover> rovers = new List<Rover>();

            ReadInputFile(inputFile, ref plateau, ref rovers);

            for(int i = 0; i < rovers.Count; i++)
            {
                plateau.MoveRover(rovers[i]);
            }

            Console.ReadLine();
        }

        private static void ReadInputFile(String filePath, ref Plateau plateau, ref List<Rover> rovers)
        {
            var lines = File.ReadAllLines(filePath);

            var pleateau_split = lines[0].Split(' ');

            plateau = new Plateau(Convert.ToInt32(pleateau_split[0]), Convert.ToInt32(pleateau_split[1]));

            for (int i = 1; i < lines.Count(); i++)
            {
                var roverPostion = lines[i].Split(' ');
                var roverCommands = lines[i + 1];
                rovers.Add(new Rover(rovers.Count + 1,Convert.ToInt32(roverPostion[0]), Convert.ToInt32(roverPostion[1]), roverPostion[2], roverCommands));
                i++;
            }
        }
    }
}
