﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAlgorithm_v_2._0
{
    internal class PrintTables
    {
        public static void PrintTable(int[] toPrint)
        {
            string stringToPrint = "";
            foreach (var item in toPrint)
            {
                stringToPrint += (" " + item);
            }
            Console.WriteLine(stringToPrint);
        }

        public static void PrintBitArrayTable(BitArray toPrint)
        {
            string stringToPrint = "";
            foreach (var item in toPrint)
            {
                stringToPrint += (" " + item.ToString());
            }
            Console.WriteLine(stringToPrint);
        }

        public static void PrintTableOfTables(int[][] toPrint)
        {
            string stringToPrint = "";
            int counter = 1;
            foreach (var item in toPrint)
            {
                stringToPrint += counter.ToString();
                foreach (var item2 in item)
                {
                    stringToPrint += (" " + item2);
                }
                counter++;
                stringToPrint += "\n \n";
            }
            Console.WriteLine(stringToPrint);
        }

        public static void PrintTableOfBitArray(BitArray[] toPrint)
        {
            string stringToPrint = "";
            int counter = 1;
            foreach (var item in toPrint)
            {
                stringToPrint += counter.ToString();
                foreach (var item2 in item)
                {
                    stringToPrint += (" " + item2.ToString());
                }
                counter++;
                stringToPrint += "\n \n";
            }
            Console.WriteLine(stringToPrint);
        }
    }
}