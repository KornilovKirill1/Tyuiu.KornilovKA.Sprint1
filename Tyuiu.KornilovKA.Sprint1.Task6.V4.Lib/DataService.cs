using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KornilovKA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            value = Regex.Replace(value, "[.,;\\-:]", "");
            string[] arrayWord = value.Split(' ');
            List<string> result = new List<string>();
            for (int i = 0; i < arrayWord.Length; i++)
            {
                if (arrayWord[i].Contains("нн") == true)
                {
                    result.Add(arrayWord[i].ToLower());
                }
            }

            return String.Join(", ", result);
        }
    }
}
