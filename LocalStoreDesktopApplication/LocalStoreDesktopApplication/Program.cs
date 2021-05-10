// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace LocalStoreDesktopApplication
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Initializes the dictionary of databse, calls ProductStock class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// ,p.
        /// </summary>
        /// <param name="args"> oji.</param>
        public static void Main(string[] args)
        {
            // Dictionary of databse with Key as unique product ID and value as tuple with three items (product name, product current quantity, product description).
             Dictionary<string, Tuple<string, int, string>> dict = new Dictionary<string, Tuple<string, int, string>>();
             dict.Add("1", new Tuple<string, int, string>("pen", 5, "A pen is a common writing instrument used to apply ink to a surface, usually paper, for writing or drawing."));
             dict.Add("2", new Tuple<string, int, string>("paper", 10, "Paper is a thin sheet material produced by mechanically and/or chemically processing cellulose fibres derived from wood, rags, grasses or other vegetable sources in water, draining the water through fine mesh leaving the fibre evenly distributed on the surface, followed by pressing and drying."));
             dict.Add("3", new Tuple<string, int, string>("notebook", 40, "A notebook is a book or stack of paper pages that are often ruled and used for purposes such as recording notes or memoranda, other writing, drawing or scrapbooking."));
             dict.Add("4", new Tuple<string, int, string>("pencil", 20, "A pencil is a kind of writing equipment that is also used to draw, usually on paper"));
             dict.Add("5", new Tuple<string, int, string>("ruler", 14, "A ruler can be defined as a tool or device used to measure length and draw straight lines. A ruler can be used to measure lengths in both metric and customary units"));
             dict.Add("6", new Tuple<string, int, string>("eraser", 5, "An eraser is an article of stationery that is used for removing marks from paper or skin."));
             dict.Add("7", new Tuple<string, int, string>("textbook", 24, "A textbook is a book used for the study of a subject. People use a textbook to learn facts and methods about a certain subject"));
             dict.Add("8", new Tuple<string, int, string>("E-book", int.MaxValue, "An electronic book, or eBook, is a book publication made available in digital form, consisting of text, images, or both, readable on the flat-panel display of computers or other electronic devices."));

             ProductStock s = new ProductStock();
             int searchChoice = 0;
             string fileName = string.Empty;
             var searchRes = new ArrayList();

             int menuChoice = 0;
             while (menuChoice != 4)
             {
                 Console.WriteLine("Plese enter the required functionality ");
                 Console.WriteLine("1. Search");
                 Console.WriteLine("2. SaveSearch");
                 Console.WriteLine("3. Restock");
                 Console.WriteLine("4. Exit");

                 menuChoice = int.Parse(Console.ReadLine());

                 switch (menuChoice)
                 {
                     case 1:
                         Console.WriteLine("Search");

                         Console.WriteLine("Enter what needs to be searched ");
                         var userInput = Console.ReadLine();
                         var actualInput = userInput.Split(' ');

                         Console.WriteLine("Enter the search operation to be performed ");
                         Console.WriteLine("1. OR");
                         Console.WriteLine("2. AND");

                         searchChoice = int.Parse(Console.ReadLine());
                         switch (searchChoice)
                         {
                             case 1:
                                 Console.WriteLine("OR operation selected");
                                 searchRes = s.Search(dict, actualInput, "OR");
                                 fileName = DateTime.Now.ToString("yyyy-dd-hh-HH h-mm-ss-");
                                 break;
                             case 2:
                                 Console.WriteLine("AND operation selected");
                                 searchRes = s.Search(dict, actualInput, "AND");
                                 fileName = DateTime.Now.ToString("yyyy-dd-hh-HH h-mm-ss-");
                                 break;
                         }

                         Console.WriteLine(string.Empty);
                         break;
                     case 2:
                         Console.WriteLine("SaveSearch");
                         s.SaveSearch(searchRes, fileName);
                         Console.WriteLine(string.Empty);
                         break;
                     case 3:
                         Console.WriteLine("Restock");
                         Console.WriteLine("Enter the n");
                         int n = Convert.ToInt32(Console.ReadLine());
                         s.Restock(dict, n);
                         Console.WriteLine(string.Empty);
                         break;
                     case 4:
                         break;
                 }
             }
         }
        }
    }
