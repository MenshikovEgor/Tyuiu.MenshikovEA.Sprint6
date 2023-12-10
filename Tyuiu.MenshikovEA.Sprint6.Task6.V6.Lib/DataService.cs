using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.MenshikovEA.Sprint6.Task6.V6.Lib
{
    public class DataService : ISprint6Task6V6
    {
        public string CollectTextFromFile(string path)
        {
            string content = File.ReadAllText(path, Encoding.UTF8);

            
            string[] words = content.Split(new[] { ' ', '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);

          
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                
                if (word.Contains("b"))
                {
                    
                    result.Append(word).Append(" ");
                }
            }

            return result.ToString().Trim();
        }
    }
}
