using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр_1
{
    public interface ICalculator 
    {
        //str1 исходная строка
        void PutSymbol(string str1);
        string DeleteSubstr(string substr);
        string ChangeSubstr(string str1, string substr1, string substr2);
        char GetSymbolByIndex(string str1, int indx); 
        int GetLenght(string str1);
        int NumOfVowels(string str1);
        int NumOfConsonants(string str1);
        int NumOfWords(string str1);
        int NumOfSentences(string str1);


    }
    public class Calculator : ICalculator 
    {
        public string str1 = "";
        public int CountVowels = 0;
        public int CountWords = 0;
        public int CountSentences = 0;
        public void PutSymbol(string str1) 
        {
            this.str1 = str1;
        }
        public int GetLenght(string str1) 
        {
            return str1.Length;
        }
        public char GetSymbolByIndex(string str1, int indx) 
        {
            return str1[indx];
        }

        public string ChangeSubstr(string str1, string substr1, string substr2) 
        {
            str1 = str1.Replace(substr1, substr2);
            return str1;
        }
        public string DeleteSubstr(string substr) 
        {
            str1 = str1.Replace(substr, "");
            return str1;
        }
        public int NumOfVowels(string str1) 
        {
            str1.ToLower();
            for (int i = 0; i < str1.Length; i++) 
            {
                if (str1[i] == 'а' 
                    || str1[i] == 'о'
                    || str1[i] == 'у'
                    || str1[i] == 'ы'
                    || str1[i] == 'и'
                    || str1[i] == 'я'
                    || str1[i] == 'ё'
                    || str1[i] == 'е'
                    || str1[i] == 'э'
                    || str1[i] == 'ю') 
                {
                    CountVowels++;
                }
            }
            return CountVowels;
        }
        public int NumOfConsonants(string str1)
        {
            NumOfVowels(str1); //отнять пробелы, восклицательные знаки
            return (str1.Length - CountVowels);
        }
        public int NumOfWords(string str1) 
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == ' ')
                {
                    CountWords++;
                }
            }
            return CountWords;
        }
        public int NumOfSentences(string str1)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == '.'
                    || str1[i] == '!'
                    || str1[i] == '?')
                {
                    CountSentences++;
                }
            }
            return CountSentences;
        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
