using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр_1
{
    public interface ICalculator 
    {
        //str1 str2
        void PutSymbol(string str1);
        string DeleteSymbol(char smbl);
        string ChangeSymbol(char smbl1, char smbl2);
        char GetSymbolByIndex(string str1, int indx); 
        int GetLenght(string str1);
        int NumOfVowels();
        void NumOfConsonants();
        void NumOfWords();
        void NumOfSentences();


    }
    public class Calculator //: ICalculator 
    {
        public string str1 = "";
        void PutSymbol(string str1) 
        {
            this.str1 = str1;
        }
        int GetLenght(string str1) 
        {
            return str1.Length;
        }
        char GetSymbolByIndex(string str1, int indx) 
        {
            return str1[indx];
        }

        string ChangeSymbol(char smbl1, char smbl2) 
        {
            str1 = str1.Replace(smbl1, smbl2);
            return str1;
        }
        string DeleteSymbol(char smbl) 
        {
            str1 = str1.Remove(smbl);
            return str1;
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
