using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DatskiyDE.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;

            string[] words = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            foreach (string word in words)
            {
                if (word.Length > 1)
                {
                    string modifiedWord = word[word.Length - 1] + word.Substring(0, word.Length - 1);
                    result.Append(modifiedWord + " ");
                }
                else { result.Append(word + " "); }            
            }       
            return result.ToString().Trim();
        }
    }
}