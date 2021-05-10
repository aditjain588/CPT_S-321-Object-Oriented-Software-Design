// <copyright file="Program.cs" company="Adit Jain">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FinalExam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Entry point of console application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main program.
        /// </summary>
        /// <param name="args">args. </param>
        private static void Main(string[] args)
        {
            ShapesFeatures newShape = new ShapesFeatures(10);
            int menuChoice = 0;
            while (menuChoice != 10)
            {
                Console.WriteLine("Please select the required functionality ");
                Console.WriteLine("1: Change default size of shapes");
                Console.WriteLine("2: List the shape created by user with all associated information.");
                Console.WriteLine("3: View history of shape creation sequence");
                Console.WriteLine("4: Add a sequence/Delete a sequence");
                Console.WriteLine("5: Modify a sequence");
                Console.WriteLine("6: Compute the area of existing shapes");
                Console.WriteLine("7: Filter shapes based on specific criteria");
                Console.WriteLine("8: Undo/Redo");
                Console.WriteLine("9: Save/Load");
                Console.WriteLine("10: Quit");
                Console.WriteLine(string.Empty);

                menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the new default size value");
                        int newSize = int.Parse(Console.ReadLine());
                        newShape.ChangeDefaultSize(newSize);
                        Console.WriteLine(string.Empty);
                        break;
                    case 2:
                        newShape.ListAllShapes();
                        Console.WriteLine(string.Empty);
                        break;
                    case 3:
                        newShape.PrintHistory();
                        Console.WriteLine(string.Empty);
                        break;
                    case 4:
                        int subMenuChoice = 0;
                        while (subMenuChoice != 3)
                        {
                            Console.WriteLine("Please select the required functionality");
                            Console.WriteLine("1: Add a new sequence");
                            Console.WriteLine("2: Delete a sequence");
                            Console.WriteLine("3: Go back to main menu");
                            Console.WriteLine(string.Empty);
                            subMenuChoice = int.Parse(Console.ReadLine());

                            switch (subMenuChoice)
                            {
                                case 1:
                                    Console.WriteLine("Enter the new sequence to be added");
                                    var userInput = Console.ReadLine();
                                    newShape.AddNewSequence(userInput);
                                    Console.WriteLine(string.Empty);
                                    break;
                                case 2:
                                    newShape.PrintHistory();
                                    Console.WriteLine("Enter sequence number of sequence to be deleted");
                                    int seqNum = int.Parse(Console.ReadLine());
                                    newShape.DeleteSequence(seqNum);
                                    break;
                                case 3:
                                    break;
                            }
                        }

                        break;
                    case 5:
                        newShape.PrintHistory();

                        Console.WriteLine("Enter the serial number of sequence you want to modify"); // (1,2,3.....)
                        int seqNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine(newShape.SeqList[seqNumber - 1]);

                        Console.WriteLine("Enter the index of sequence you want to change"); // (1,2,3....)
                        int index = int.Parse(Console.ReadLine());

                        subMenuChoice = 0;
                        while (subMenuChoice != 5)
                        {
                            Console.WriteLine(string.Empty);
                            Console.WriteLine("Please select the required shape modification");
                            Console.WriteLine("1. Replace the shape with another shape.");
                            Console.WriteLine("2. Change the shape color");
                            Console.WriteLine("3. Change the shape pattern");
                            Console.WriteLine("4. Change the shape thickness");
                            Console.WriteLine("5. Go back to main menu");

                            subMenuChoice = int.Parse(Console.ReadLine());

                            switch (subMenuChoice)
                            {
                                case 1:
                                    Console.WriteLine("Enter the shape you want to replace with");
                                    string replaceShape = Console.ReadLine();
                                    newShape.ModifySequence(seqNumber, replaceShape, index);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the new color");
                                    string newColor = Console.ReadLine();
                                    newShape.ChangeDefaultColor(seqNumber, index, newColor);
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the new pattern");
                                    string newPattern = Console.ReadLine();
                                    newShape.ChangeDefaultPattern(seqNumber, index, newPattern);
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the new thickness");
                                    double newThickness = int.Parse(Console.ReadLine());
                                    newShape.ChangeDefaultThickness(seqNumber, index, newThickness);
                                    break;
                                case 5:
                                    break;
                            }
                        }

                        Console.WriteLine(string.Empty);
                        break;
                    case 6:
                        newShape.PrintHistory();
                        Console.WriteLine("Enter the sequence number of sequence, whose area is to be computed");
                        seqNumber = int.Parse(Console.ReadLine());
                        newShape.ComputeArea(seqNumber);
                        Console.WriteLine(string.Empty);
                        break;
                    case 7:
                        subMenuChoice = 0;
                        while (subMenuChoice != 4)
                        {
                            Console.WriteLine("Select the criteria for filtering");
                            Console.WriteLine("1: Filter based on Area");
                            Console.WriteLine("2: Filter based on Color");
                            Console.WriteLine("3: Filter based on thickness");
                            Console.WriteLine("4: Go back to main menu");

                            subMenuChoice = int.Parse(Console.ReadLine());
                            switch (subMenuChoice)
                            {
                                case 1:
                                    Console.WriteLine("Enter threshold area");
                                    int ar = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter the type of operation");
                                    Console.WriteLine("1: Area less then a threshold value");
                                    Console.WriteLine("2: Area greater then a threshold value");
                                    Console.WriteLine("3: Area equal to threshold value");
                                    int operation = int.Parse(Console.ReadLine());

                                    newShape.FilterShapesArea(ar, operation);
                                    Console.WriteLine(string.Empty);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the color which will be macthed to shape color");
                                    string color = Console.ReadLine();
                                    newShape.FilterShapeColor(color);
                                    Console.WriteLine(string.Empty);
                                    break;
                                case 3:
                                    Console.WriteLine("Enter threshold thickness");
                                    ar = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter the type of operation");
                                    Console.WriteLine("1: Thickness less then a threshold value");
                                    Console.WriteLine("2: Thickness greater then a threshold value");
                                    Console.WriteLine("3: Thickness equal to a threshold value");
                                    operation = int.Parse(Console.ReadLine());

                                    newShape.FilterShapeThickness(ar, operation);
                                    Console.WriteLine(string.Empty);
                                    break;
                                case 4:
                                    break;
                            }
                        }

                        Console.WriteLine(string.Empty);
                        break;
                    case 8:
                        subMenuChoice = 0;
                        while (subMenuChoice != 3)
                        {
                            Console.WriteLine("Please select required functionality");
                            Console.WriteLine("1: Undo");
                            Console.WriteLine("2: Redo");
                            Console.WriteLine("3: Go back to main menu");
                            Console.WriteLine(string.Empty);

                            subMenuChoice = int.Parse(Console.ReadLine());
                            switch (subMenuChoice)
                            {
                                case 1:
                                    newShape.Undo();
                                    break;
                                case 2:
                                    newShape.Redo();
                                    break;
                                case 3:
                                    break;
                            }
                        }

                        Console.WriteLine(string.Empty);
                        break;
                    case 9:
                        subMenuChoice = 0;
                        while (subMenuChoice != 3)
                        {
                            Console.WriteLine("Please select required functionality");
                            Console.WriteLine("1: Save to XML file");
                            Console.WriteLine("2: Load from XML file");
                            Console.WriteLine("3: Go back to main menu");
                            Console.WriteLine(string.Empty);

                            subMenuChoice = int.Parse(Console.ReadLine());
                            switch (subMenuChoice)
                            {
                                case 1:
                                    newShape.Save();
                                    Console.WriteLine(string.Empty);
                                    break;
                                case 2:
                                    newShape.Load();
                                    Console.WriteLine(string.Empty);
                                    break;
                                case 3:
                                    break;
                            }
                        }

                        Console.WriteLine(string.Empty);
                        break;
                    case 10:
                        break;
                }
            }
        }
    }
}
