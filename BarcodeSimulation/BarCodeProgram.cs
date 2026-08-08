using System;
using System.Collections.Generic;
using BarcodeSimulation;


namespace _14_Csharp_Level1.BarCode_Simulation
{
    internal class BarCodeProgram
    {
        //Lets make BarCode Simulation
        /*
        CategoryNumber  --> 3 --> 001
        ItemPrice       --> 5 --> 02000
        ItemNumber      --> 5 --> 00011
        ItemName        --> ReadLine() --> "iPhone"
        Separator       --> #//#
        */
        private static void Main(string[] args)
        {

            string Separator = "#//#";
            string Barcodes = @"0010200000011#//#0020220000012#//#0030015000013"; // 3 barcodes

            string[] barcodesArray = Barcodes.Split(new[] { Separator }, StringSplitOptions.None);

            Item itemObj = new Item();
            List<Item> itemsList = new List<Item>();

            foreach (string barcode in barcodesArray)
            {
                itemObj = new Item();
                itemObj.CategoryNumber = Convert.ToInt16(barcode.Substring(0, 3));
                itemObj.ItemPrice = Convert.ToInt16(barcode.Substring(3, 5));
                itemObj.ItemNumber = Convert.ToInt16(barcode.Substring(8, 5));
                Console.Write("Enter Item Name : ");
                itemObj.ItemName = Console.ReadLine();
                itemsList.Add(itemObj);
            }

            string newRecords = string.Empty;
            foreach (var item in itemsList)
            {
                newRecords += $"{itemObj.GetFormattedCategoryNumber(item.CategoryNumber)}" +
                    $"{itemObj.GetFormattedItemPrince(item.ItemPrice)}" +
                    $"{itemObj.GetFormattedItemNumber(item.ItemNumber)}{Separator}";
            }
            newRecords = newRecords.Substring(0, newRecords.Length - Separator.Length);

            foreach (var item in itemsList)
            {
                Console.WriteLine("\n----------------------------------");
                Console.WriteLine($"ItemName       : {item.ItemName}.");
                Console.WriteLine($"CategoryNumber : {item.CategoryNumber}");
                Console.WriteLine($"ItemNumber     : {item.ItemNumber}");
                Console.WriteLine($"ItemPrice      : {item.ItemPrice}$");
                Console.WriteLine("----------------------------------\n");
            }



            Console.ReadKey();
        }

    }

}
