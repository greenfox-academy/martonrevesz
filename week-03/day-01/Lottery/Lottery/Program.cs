﻿using System;
using System.IO;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\Lottery\Lottery\lottery-data.txt";
            int[] thefinalArray = FindFiveMostCommon(WriteLotteryDataIntoArray(source));
            foreach (int item in thefinalArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static int[] WriteLotteryDataIntoArray(string source)
        {
            var sr = new StreamReader(source);
            string line = "";
            int[] options = new int[90];

            try
            {
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] splitData = line.Split(';');
                        for (int i = 11; i < 16; i++)
                        {                    
                                options[(int.Parse(splitData[i])) - 1] += 1;                          
                        }                       
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
            }
            return options;
        }
        static int[] FindFiveMostCommon(int[] inputArray)
        {
            int[] result = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int currentMaxIndex = 0;
                for (int j = 1; j < inputArray.Length; j++)
                {
                    if (inputArray[currentMaxIndex] < inputArray[j])
                    {
                        currentMaxIndex = j;
                    }                  
                }
                result[i] = currentMaxIndex + 1;
                inputArray[currentMaxIndex] = -1;
            }
            return result;
        }
    }
}
