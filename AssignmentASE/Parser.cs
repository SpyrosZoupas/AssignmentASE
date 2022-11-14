using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace AssignmentASE
{
    internal class Parser
    {
        public static void ParseAction(string commandTyped)
        {
            commandTyped = commandTyped.ToLower().Trim();
            string[] split = commandTyped.Split(' ');
            int count = 0;
            foreach (string s in split)
            {
               count++;
            }
            if (count == 2) //==2 or > 1 or > 1 & < 2??
            {
                string command = split[0];
                string[] parameters = split[1].Split(',');
                int[] parametersInteger = new int[parameters.Length];
                for (int i = 0; i < parameters.Length; i++)
                {
                    parametersInteger[i] = parseInt(parameters[i]);
                    //throw exception in case it's not a number?
                }

                //change to switch for the other stuff.
                switch(command)
                {
                    case "drawto":
                        if (parametersInteger.Count() != 2)
                        {
                            Console.WriteLine("WRONG NUMBER OF PARAMETERS. PARAMETERS NEEDED = 2");
                        } else
                        {
                                 
                            //we draw
                        }
                        break;
                    case "moveto":
                        if (parametersInteger.Count() != 2)
                        {
                            Console.WriteLine("WRONG NUMBER OF PARAMETERS. PARAMETERS NEEDED = 2");
                            //maybe a method that is called to check for parameters?
                        } else
                        {
                            //we draw
                        }
                        break;
                }
            }
        }

        //public static Action ParseAction(IEnumerable<string> tokens)
        //{
          //  throw new NotImplementedException();
        //}

        public static int parseInt(string parameter)
        {
            if (int.TryParse(parameter, out int result))
            {
                return result;
            } else
            {
                //dont want to return anything
                return result;
            }
        }

    }
}
