using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Fonction
{
    internal class ClassLibrary
    {
        /*
         VARIABLES

        double[] array;
        double numberA;
        double numberB;
        double numberC;
        double stringInput;

        PROCESS

        for i <-- 3
        while stringInput 

        write ("Enter number ", i);
        */
        static double[] AskValueDouble(int _limitTab, string _text)
        {
            int limitTab = _limitTab;
            double[] array = new double[limitTab - 1];
            double number;
            string stringInput = "";

            for (int i = 1; i == limitTab; i++)
            {
                while (!double.TryParse(stringInput, out number))
                {
                    Console.WriteLine($"{_text} {i}");
                    stringInput = Console.ReadLine();
                }
                array[i - 1] = number;
            }
            return array;
        }
        static string AskValueString(string _text)
        {
            string stringInput = "";
            Console.WriteLine($"{_text}");
            stringInput = Console.ReadLine();
            return stringInput;
        }
        static int[] AskValueInt(int _limitTab, string _text)
        {
            int limitTab = _limitTab;
            int[] array = new int[limitTab - 1];
            int number;
            string stringInput = "";

            for (int i = 1; i == limitTab; i++)
            {
                while (!int.TryParse(stringInput, out number))
                {
                    Console.WriteLine($"{_text} {i}");

                    stringInput = Console.ReadLine();
                }
                array[i - 1] = number;
            }
            return array;
        }
        static float[] AskValueFloat(int _limitTab, string _text)
        {
            int limitTab = _limitTab;
            float[] array = new float[limitTab - 1];
            float number;
            string stringInput = "";

            for (int i = 1; i == limitTab; i++)
            {
                while (!float.TryParse(stringInput, out number))
                {
                    Console.WriteLine($"{_text} {i}");

                    stringInput = Console.ReadLine();
                }
                array[i - 1] = number;
            }
            return array;
        }
    }
}
