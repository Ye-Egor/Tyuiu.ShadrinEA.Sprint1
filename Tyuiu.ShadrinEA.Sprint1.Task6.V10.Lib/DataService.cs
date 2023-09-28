using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShadrinEA.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            value = Regex.Replace(value, @"[^\w\s]", "");

            string[] words = value.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    int middleIndex = words[i].Length / 2;
                    words[i] = words[i].Remove(middleIndex, 1);
                }
            }
            return string.Join(" ", words);

        }


    }// это сложно!
    // я старался и у меня почти получилось
}
