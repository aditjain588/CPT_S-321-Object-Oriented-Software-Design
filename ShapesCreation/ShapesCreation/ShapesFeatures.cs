// <copyright file="ShapesFeatures.cs" company="Adit Jain">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FinalExam
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    /// <summary>
    /// Class to implement shapes.
    /// </summary>
    public class ShapesFeatures
    {
        private List<List<Shapes>> shapeList; // list of list which contains all the objects of shape sequences.
        private int defaultSize; // default size.
        private List<string> seqList; // list of all sequences made by user.
        private Stack<ArrayList> undoStack; // undo stack of arraylists.
        private Stack<ArrayList> redoStack; // redo stack of arraylists.

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapesFeatures"/> class.
        /// </summary>
        /// <param name="defSize">Default size. </param>
        public ShapesFeatures(int defSize)
        {
            this.DefaultSize = defSize;
            this.seqList = new List<string>();
            this.shapeList = new List<List<Shapes>>();
            this.undoStack = new Stack<ArrayList>();
            this.redoStack = new Stack<ArrayList>();
        }

        /// <summary>
        /// gets or sets the value of defaultSize.
        /// </summary>
        public int DefaultSize
        {
            get
            {
                return this.defaultSize;
            }

            set
            {
                this.defaultSize = value;
            }
        }

        /// <summary>
        /// gets or sets the value of SeqList.
        /// </summary>
        public List<string> SeqList
        {
            get
            {
                return this.seqList;
            }

            set
            {
                this.seqList = value;
            }
        }

        /// <summary>
        /// gets or sets the value of shapeList list.
        /// </summary>
        public List<List<Shapes>> ShapeList
        {
            get
            {
                return this.shapeList;
            }

            set
            {
                this.shapeList = value;
            }
        }

        /// <summary>
        /// Changes default size of shapes.
        /// </summary>
        /// <param name="newSize">The new default size. </param>
        /// <returns>New default size. </returns>
        public int ChangeDefaultSize(int newSize)
        {
            ArrayList undoList = new ArrayList();

            // appends current state of function to arraylist.
            undoList.Add("defaultSize");
            undoList.Add(this.defaultSize);

            // arraylist is pushed on the undo stack.
            this.undoStack.Push(undoList);
            this.defaultSize = newSize;

            return newSize;
        }

        /// <summary>
        /// Change default size of particular shape.
        /// </summary>
        /// <param name="seqNum">Sequence number. </param>
        /// <param name="index">index of shape whose color has to be changed. </param>
        /// <param name="newColor">New color. </param>
        public void ChangeDefaultColor(int seqNum, int index, string newColor)
        {
            ArrayList undoList = new ArrayList();

            // appends current state of function to arraylist.
            undoList.Add("defaultColor");
            undoList.Add(seqNum);
            undoList.Add(index);
            undoList.Add(this.shapeList[seqNum - 1][index - 1].Color);

            // arraylist is pushed on the undo stack.
            this.undoStack.Push(undoList);

            this.shapeList[seqNum - 1][index - 1].Color = newColor;
        }

        /// <summary>
        /// Changes default thickness of a particular shape.
        /// </summary>
        /// <param name="seqNum">Sequence number. </param>
        /// <param name="index">index of shape whose thickness has to be changed.</param>
        /// <param name="newThickness">New thickness. </param>
        public void ChangeDefaultThickness(int seqNum, int index, double newThickness)
        {
            ArrayList undoList = new ArrayList();

            // appends current state of function to arraylist.
            undoList.Add("defaultThickness");
            undoList.Add(seqNum);
            undoList.Add(index);
            undoList.Add(this.shapeList[seqNum - 1][index - 1].Thickness);

            // arraylist is pushed on the undo stack.
            this.undoStack.Push(undoList);
            this.shapeList[seqNum - 1][index - 1].Thickness = newThickness;
        }

        /// <summary>
        /// Changes default thickness of a particular shape.
        /// </summary>
        /// <param name="seqNum">Sequence number. </param>
        /// <param name="index">index of shape whose thickness has to be changed.</param>
        /// <param name="newPattern">New pattern. </param>
        public void ChangeDefaultPattern(int seqNum, int index, string newPattern)
        {
            ArrayList undoList = new ArrayList();

            // appends current state of function to arraylist.
            undoList.Add("defaultPattern");
            undoList.Add(seqNum);
            undoList.Add(index);
            undoList.Add(this.shapeList[seqNum - 1][index - 1].Pattern);

            // arraylist is pushed on the undo stack.
            this.undoStack.Push(undoList);
            this.shapeList[seqNum - 1][index - 1].Pattern = newPattern;
        }

        /// <summary>
        /// Lists the shapes user has created with associated information.
        /// </summary>
        public void ListAllShapes()
        {
            if (this.shapeList.Count == 0)
            {
                Console.WriteLine("No shapes have been created yet");
                return;
            }

            int index = 0;
            foreach (List<Shapes> item in this.shapeList)
            {
                Console.WriteLine((index + 1) + " Sequence is: " + this.seqList[index]);
                index++;
                foreach (Shapes shape in item)
                {
                    shape.ShapeInfo();
                    Console.WriteLine(string.Empty);
                }
            }
        }

        /// <summary>
        /// Prints all the sequence of shapes created by user from the start of application.
        /// </summary>
        public void PrintHistory()
        {
            if (this.seqList.Count == 0)
            {
                Console.WriteLine("No shape sequencies have been created yet");
                return;
            }

            // Iterates sequence list and prints out all the sequences.
            for (int i = 0; i < this.seqList.Count; i++)
            {
                Console.WriteLine(i + 1 + " : " + this.seqList[i]);
            }
        }

        /// <summary>
        /// Adds new shape sequence to the shapeList list.
        /// </summary>
        /// <param name="seq">New sequence that is to be added. </param>
        public void AddNewSequence(string seq)
        {
            string[] sequence = seq.Split(' ');
            List<Shapes> tempShapeList = new List<Shapes>();
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == "s")
                {
                    Shapes newShape = new Square((i + 1) * this.defaultSize);
                    tempShapeList.Add(newShape);
                }
                else if (sequence[i] == "c")
                {
                    Shapes newShape = new Circle((i + 1) * this.defaultSize);
                    tempShapeList.Add(newShape);
                }
                else if (sequence[i] == "r")
                {
                    Shapes newShape = new Rectangle((i + 1) * this.defaultSize);
                    tempShapeList.Add(newShape);
                }
                else if (sequence[i] == "t")
                {
                    Shapes newShape = new Trapezium((i + 1) * this.defaultSize);
                    tempShapeList.Add(newShape);
                }
                else if (sequence[i] == "p")
                {
                    Shapes newShape = new Pentagon((i + 1) * this.defaultSize);
                    tempShapeList.Add(newShape);
                }
            }

            this.shapeList.Add(tempShapeList);
            string newSeq = string.Join(" ", seq);
            this.SeqList.Add(newSeq); // adding the new sequence to the seqList list of Shapes class.
        }

        /// <summary>
        /// Deletes a shape sequence from the shapeList list.
        /// </summary>
        /// <param name="seqNum">Sequence number of sequence to be deleted. </param>
        public void DeleteSequence(int seqNum)
        {
            this.shapeList.RemoveAt(seqNum - 1);
            this.seqList.RemoveAt(seqNum - 1);
        }

        /// <summary>
        /// Modifies or removes the sequence in dictionary and updates sequence list.
        /// </summary>
        /// <param name="seqNum">Sequence number of sequence that needs to be modified. </param>
        /// <param name="seq">New sequence. </param>
        /// <param name="ind">Used only in partial modification, contains the index of sequence which is to be modified.</param>
        public void ModifySequence(int seqNum, string seq, int ind)
        {
            // modify the seqeunce at seqNum by replacing shape with replaceShape(user input, passed as parameter) at mentioned index(user input, passed as parameter).
            string[] sequence = this.seqList[seqNum - 1].Split(' ');
            sequence[ind - 1] = seq;

            // updating sequence list
            this.seqList[seqNum - 1] = string.Join(" ", sequence);
            Shapes newShape = null;

            // get the shape's default size.
            double defSize = this.shapeList[seqNum - 1][ind - 1].Size();
            if (seq == "c")
            {
                newShape = new Circle(defSize);
            }
            else if (seq == "r")
            {
                newShape = new Rectangle(defSize);
            }
            else if (seq == "s")
            {
                newShape = new Square(defSize);
            }
            else if (seq == "p")
            {
                newShape = new Pentagon(defSize);
            }
            else if (seq == "t")
            {
                newShape = new Trapezium(defSize);
            }

            this.shapeList[seqNum - 1][ind - 1] = newShape;
        }

        /// <summary>
        /// Computes the area of a sequence.
        /// </summary>
        /// <param name="sequenceNum">Sequence whose area is to calculated. </param>
        /// <returns>Computed area. </returns>
        public double ComputeArea(int sequenceNum)
        {
            double area = 0.0;

            // get the dictionary key value pair associated with sequence num.
            foreach (Shapes item in this.shapeList[sequenceNum - 1])
            {
                area += item.Area;
            }

            Console.WriteLine("Computed area of sequence " + sequenceNum + " is: " + area);
            return area;
        }

        /// <summary>
        /// Filter the shapes based on specific criteria.
        /// </summary>
        /// <param name="thresholdArea">Threhold area. </param>
        /// <param name="operation">Type of operation. </param>
        // public List<string> FilterShapes()
        public void FilterShapesArea(int thresholdArea,  int operation)
        {
            List<Shapes> filterList = new List<Shapes>();
            foreach (List<Shapes> shape in this.shapeList)
            {
                foreach (Shapes item in shape)
                {
                    filterList.Add(item);
                }
            }

            IEnumerable<Shapes> filter = null;
            switch (operation)
            {
                // when area lesser then threshold is needed.
                case 1:
                    filter = filterList.Where(x => x.Area < thresholdArea);
                    break;

                // when area greater then threshold is needed.
                case 2:
                    filter = filterList.Where(x => x.Area > thresholdArea);
                    break;

                // when area equal to threshold is needed.
                case 3:
                    filter = filterList.Where(x => x.Area == thresholdArea);
                    break;
            }

            if (filter.Count() == 0)
            {
                Console.WriteLine("No shapes matched the specified criteria");
                return;
            }

            Console.WriteLine("Following shapes were filtered");
            foreach (Shapes shape in filter)
            {
                shape.ShapeInfo();
                Console.WriteLine(string.Empty);
            }
        }

        /// <summary>
        /// Filter shapes based on color.
        /// </summary>
        /// <param name="compareColor">Color. </param>
        public void FilterShapeColor(string compareColor)
        {
            List<Shapes> filterList = new List<Shapes>();

            // adding all shapes in the filterlist.
            foreach (List<Shapes> shape in this.shapeList)
            {
                foreach (Shapes item in shape)
                {
                    filterList.Add(item);
                }
            }

            var filter = filterList.Where(x => x.Color == compareColor);
            if (filter.Count() == 0)
            {
                Console.WriteLine("No shapes matched the specified criteria");
                return;
            }

            Console.WriteLine("Following shapes were filtered");
            foreach (Shapes shape in filter)
            {
                shape.ShapeInfo();
                Console.WriteLine(string.Empty);
            }
        }

        /// <summary>
        /// Filter shapes based on thickness.
        /// </summary>
        /// <param name="thresholdThickness">Threshold thickness. </param>
        /// <param name="operation">Type of operation. </param>
        public void FilterShapeThickness(double thresholdThickness, int operation)
        {
            List<Shapes> filterList = new List<Shapes>();
            foreach (List<Shapes> shape in this.shapeList)
            {
                foreach (Shapes item in shape)
                {
                    filterList.Add(item);
                }
            }

            IEnumerable<Shapes> filter = null;
            switch (operation)
            {
                // when thickness lesser then threshold is needed.
                case 1:
                    filter = filterList.Where(x => x.Thickness < thresholdThickness);
                    break;

                // when thickness greater then threshold is needed.
                case 2:
                    filter = filterList.Where(x => x.Thickness > thresholdThickness);
                    break;

                // when thickness equal to threshold is needed.
                case 3:
                    filter = filterList.Where(x => x.Thickness == thresholdThickness);
                    break;
            }

            if (filter.Count() == 0)
            {
                Console.WriteLine("No shapes matched the specified criteria");
                return;
            }

            Console.WriteLine("Following shapes were filtered");
            foreach (Shapes shape in filter)
            {
                shape.ShapeInfo();
                Console.WriteLine(string.Empty);
            }
        }

        /// <summary>
        /// Undo's the user last action.
        /// </summary>
        public void Undo()
        {
            if (this.undoStack.Count == 0)
            {
                Console.WriteLine("Nothing to undo! Stack empty.");
                Console.WriteLine(string.Empty);
                return;
            }

            ArrayList operationList = new ArrayList();
            operationList = this.undoStack.Pop();
            Console.WriteLine(operationList[1]);

            switch (operationList[0])
            {
                case "defaultSize":
                    this.ChangeDefaultSize((int)operationList[1]);
                    break;
                case "defaultColor":
                    this.ChangeDefaultColor((int)operationList[1], (int)operationList[2], (string)operationList[3]);
                    break;
                case "defaultThickness":
                    this.ChangeDefaultThickness((int)operationList[1], (int)operationList[2], (double)operationList[3]);
                    break;
                case "defaultPattern":
                    this.ChangeDefaultPattern((int)operationList[1], (int)operationList[2], (string)operationList[3]);
                    break;
            }

            this.redoStack.Push(this.undoStack.Pop());
        }

        /// <summary>
        /// Redo's the user last action.
        /// </summary>
        public void Redo()
        {
            if (this.redoStack.Count == 0)
            {
                Console.WriteLine("Nothing to redo! Stack empty.");
                Console.WriteLine(string.Empty);
                return;
            }

            ArrayList operationList = new ArrayList();
            operationList = this.redoStack.Pop();
            Console.WriteLine(operationList[1]);
            switch (operationList[0])
            {
                case "defaultSize":
                    this.ChangeDefaultSize((int)operationList[1]);
                    break;
                case "defaultColor":
                    this.ChangeDefaultColor((int)operationList[1], (int)operationList[2], (string)operationList[3]);
                    break;
                case "defaultThickness":
                    this.ChangeDefaultThickness((int)operationList[1], (int)operationList[2], (double)operationList[3]);
                    break;
                case "defaultPattern":
                    this.ChangeDefaultPattern((int)operationList[1], (int)operationList[2], (string)operationList[3]);
                    break;
            }
        }

        /// <summary>
        /// Save the current program status to an xml file.
        /// </summary>
        public void Save()
        {
            // output.xml file is saved in "MidTerm2\MidTerm2\bin\Debug" folder.
            XmlWriter xmlWriter = XmlWriter.Create("output.xml");
            xmlWriter.WriteStartElement("ShapesList");
            int i = 1;
            foreach (List<Shapes> item in this.shapeList)
            {
                xmlWriter.WriteStartElement("Sequence-" + i);
                i += 1;
                foreach (Shapes shape in item)
                {
                    xmlWriter.WriteStartElement("ShapeInfo");
                    xmlWriter.WriteElementString("Size", shape.Size().ToString());
                    xmlWriter.WriteElementString("ShapeType", shape.ShapeType);
                    xmlWriter.WriteElementString("Area", shape.Area.ToString());
                    xmlWriter.WriteElementString("Color", shape.Color.ToString());
                    xmlWriter.WriteElementString("Thickness", shape.Thickness.ToString());
                    xmlWriter.WriteElementString("Pattern", shape.Pattern.ToString());
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndElement();
            xmlWriter.Close();
            Console.WriteLine("Saved successfully");
        }

        /// <summary>
        /// Loads from an xml file.
        /// </summary>
        public void Load()
        {
            // setting the initial values.
            this.defaultSize = 10;
            this.shapeList.Clear();
            this.seqList.Clear();
            this.undoStack.Clear();
            this.redoStack.Clear();

            XmlDocument document = new XmlDocument();
            document.Load("output.xml");

            // looping to the nesting level of tree and making the sequence with the values encountered.
            foreach (XmlNode node in document.DocumentElement)
            {
                List<Shapes> shapeListTemp = new List<Shapes>();
                List<string> seqListTemp = new List<string>();
                for (var i = 0; i < node.ChildNodes.Count; i++)
                {
                    Shapes newShape = null;
                    double shapeSize = 0;
                    for (var j = 0; j < node.ChildNodes[i].ChildNodes.Count; j++)
                    {
                         if (node.ChildNodes[i].ChildNodes[j].Name == "ShapeType")
                        {
                            if (node.ChildNodes[i].ChildNodes[j].InnerText == "rectangle")
                            {
                                newShape = new Rectangle(shapeSize);
                                seqListTemp.Add("r");
                            }
                            else if (node.ChildNodes[i].ChildNodes[j].InnerText == "square")
                            {
                                newShape = new Square(shapeSize);
                                seqListTemp.Add("s");
                            }
                            else if (node.ChildNodes[i].ChildNodes[j].InnerText == "circle")
                            {
                                newShape = new Circle(shapeSize);
                                seqListTemp.Add("c");
                            }
                            else if (node.ChildNodes[i].ChildNodes[j].InnerText == "pentagon")
                            {
                                newShape = new Pentagon(shapeSize);
                                seqListTemp.Add("p");
                            }
                            else if (node.ChildNodes[i].ChildNodes[j].InnerText == "trapezium")
                            {
                                newShape = new Trapezium(shapeSize);
                                seqListTemp.Add("t");
                            }
                        }
                        else if (node.ChildNodes[i].ChildNodes[j].Name == "Size")
                        {
                            shapeSize = Convert.ToDouble(node.ChildNodes[i].ChildNodes[j].InnerText);
                        }
                        else if (node.ChildNodes[i].ChildNodes[j].Name == "Color")
                        {
                            newShape.Color = node.ChildNodes[i].ChildNodes[j].InnerText;
                        }
                        else if (node.ChildNodes[i].ChildNodes[j].Name == "Thickness")
                        {
                            newShape.Thickness = Convert.ToDouble(node.ChildNodes[i].ChildNodes[j].InnerText);
                        }
                        else if (node.ChildNodes[i].ChildNodes[j].Name == "Pattern")
                        {
                            newShape.Pattern = node.ChildNodes[i].ChildNodes[j].InnerText;
                        }
                    }

                    shapeListTemp.Add(newShape);
                }

                this.seqList.Add(string.Join(" ", seqListTemp));
                this.shapeList.Add(shapeListTemp);
                seqListTemp = null;
                shapeListTemp = null;
            }

            Console.WriteLine("Loaded successfully");
        }
    }
}