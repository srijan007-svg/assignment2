﻿using System;
using System.IO;
using System.Text;

class filexercise3
{
    public static void Main()
    {
        string fileName = @"mytest.txt";
        int count;

        try
        {
            // Delete the file if it exists.
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            Console.Write("\n\n Count the number of lines in a file :\n");
            Console.Write("------------------------------------------\n");
            // Create the file.
            using (StreamWriter fileStr = File.CreateText(fileName))
            {
                fileStr.WriteLine(" welcome ");
                fileStr.WriteLine(" to ");
                fileStr.WriteLine(" orchid ");
                fileStr.WriteLine(" international ");
                fileStr.WriteLine(" college ");
                fileStr.WriteLine(" kathmandu ");
                fileStr.WriteLine(" gaushala ");
                fileStr.WriteLine(" bijay chowk ");
            }
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                count = 0;
                Console.WriteLine(" Here is the content of the file mytest.txt : ");
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                    count++;
                }
                Console.WriteLine("");
            }
            Console.Write(" The number of lines in  the file {0} is : {1} \n\n", fileName, count);
        }
        catch (Exception MyExcep)
        {
            Console.WriteLine(MyExcep.ToString());
        }
    }
}
