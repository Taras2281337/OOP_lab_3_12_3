using System;
using System.IO;

namespace OOP_lab_3_12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("input.txt");

            string s = file.ReadLine();

            for (int i = 1; i < s.Length; ++i)
            {
                if ((s[i] == '(') && (s[i + 1] != ')'))
                {
                    s = s.Remove(i + 1, 1);
                    --i;
                }
            }

            StreamWriter newFile = File.CreateText("output.txt");

            newFile.WriteLine(s);

            newFile.Close();
        }
    }
}
