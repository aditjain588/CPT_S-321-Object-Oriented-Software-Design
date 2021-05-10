// <copyright file="ShapesClassTests.cs" company="Adit Jain">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MidTerm2Tests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using FinalExam;
    using NUnit.Framework;

    /// <summary>
    /// CLass to test the methods of Shapes class.
    /// </summary>
    [TestFixture]
    public class ShapesClassTests
    {
        /// <summary>
        /// Tests if 0 is passed as parameter in ChangeDefaultSize method.
        /// </summary>
        [Test]
        public void ChangeDefaultSizeNullTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.ChangeDefaultSize(0);
            Assert.That(newShapes.DefaultSize, Is.EqualTo(0));
        }

        /// <summary>
        /// General test for ChangeDefaultSize method.
        /// </summary>
        [Test]
        public void ChangeDefaultSizeGeneralTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.ChangeDefaultSize(30);
            Assert.That(newShapes.DefaultSize, Is.EqualTo(30));
        }

        /// <summary>
        /// Test for ModifySequence method, if a single shape sequence is supposed to replace sequence at key: 3.
        /// </summary>
        [Test]
        public void ModifySequenceSingleShapeTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.AddNewSequence("c s r c");
            newShapes.AddNewSequence("s r c c t");
            newShapes.AddNewSequence("c s r");

            newShapes.ModifySequence(3, "s", 3); // sequence "c s r" should be changed to "c s s".
            Assert.That(newShapes.SeqList[2], Is.EqualTo("c s s"));
        }

        /// <summary>
        /// General test for ComputeArea method.
        /// </summary>
        [Test]
        public void ComputeAreaGeneralTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.AddNewSequence("c s c r");
            double area = newShapes.ComputeArea(1);

            // computing for sequence "c s c r"
            // I made a calculation error, when i computed the area myself for testing, i forgot to double the lenght of size hence got wrong area. Mistake is now rectified.
            Assert.That(area, Is.EqualTo(4341.59));
        }

        /// <summary>
        /// Null test for ComputeArea method, that is, if area is computed of empty sequence.
        /// </summary>
        [Test]
        public void ComputeAreaNullTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.AddNewSequence(" ");
            double area = newShapes.ComputeArea(1);

            // computing for sequence " "
            Assert.That(area, Is.EqualTo(0));
        }

        /// <summary>
        /// Test for ComputeArea method, for a single character in sequence.
        /// </summary>
        [Test]
        public void ComputeAreaSingleCharacterTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.AddNewSequence("s");
            double area = newShapes.ComputeArea(1);

            // computing for sequence "s"
            Assert.That(area, Is.EqualTo(100));
        }

        /// <summary>
        /// Test for ComputeArea method, for a same multiple character in sequence.
        /// </summary>
        [Test]
        public void ComputeAreaMultipleCharacterTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.AddNewSequence("s s s s s s s s s s");
            double area = newShapes.ComputeArea(1);

            // computing for sequence "s s s s s s s s s s"
            // I made a calculation error, when i computed the area myself for testing, i forgot to double the lenght of size hence got wrong area. Mistake is now rectified.
            Assert.That(area, Is.EqualTo(38500.0));
        }

        /// <summary>
        /// Test for ChangeColor method.
        /// </summary>
        [Test]
        public void ChangeDefaultColorTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.AddNewSequence("s p r");
            newShapes.AddNewSequence("t c r s");
            newShapes.ChangeDefaultColor(1, 2, "red");

            Assert.AreEqual(newShapes.ShapeList[0][1].Color, "red");
        }

        /// <summary>
        /// Test for ChangeDefaultThickness method.
        /// </summary>
        [Test]
        public void ChangeDefaultThicknessTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.AddNewSequence("s p r");
            newShapes.AddNewSequence("t c r s");
            newShapes.ChangeDefaultThickness(1, 2, 10);

            Assert.AreEqual(newShapes.ShapeList[0][1].Thickness, 10);
        }

        /// <summary>
        /// Test for ChangeDefaultPattern method.
        /// </summary>
        [Test]
        public void ChangeDefaultPatternTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.AddNewSequence("s p r");
            newShapes.AddNewSequence("t c r s");
            newShapes.ChangeDefaultPattern(1, 2, "dotted");

            Assert.AreEqual(newShapes.ShapeList[0][1].Pattern, "dotted");
        }

        /// <summary>
        /// Test for ChangeDefaultPattern method.
        /// </summary>
        [Test]
        public void ChangeDefaultPatternAnotherTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.AddNewSequence("s p r");
            newShapes.AddNewSequence("t c r s");
            newShapes.ChangeDefaultPattern(2, 3, "dashed");

            Assert.AreEqual(newShapes.ShapeList[1][2].Pattern, "dashed");
        }

        /// <summary>
        /// General test for DeletionSequence method, delete the last sequence.
        /// </summary>
        [Test]
        public void SequenceDeletionTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.AddNewSequence("s c r");
            newShapes.AddNewSequence("r r r c");
            newShapes.AddNewSequence("c c r s");

            newShapes.DeleteSequence(3);
            List<string> testList = new List<string>();
            testList.Add("s c r");
            testList.Add("r r r c");

            Assert.AreEqual(newShapes.SeqList, testList);
        }

        /// <summary>
        /// General test for DeletionSequence method, deletes a sequence in middle of list.
        /// </summary>
        [Test]
        public void MiddleSequenceDeletionTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.AddNewSequence("s c r t p");
            newShapes.AddNewSequence("r r r c");
            newShapes.AddNewSequence("c c r s");

            newShapes.DeleteSequence(2);
            List<string> testList = new List<string>();
            testList.Add("s c r t p");
            testList.Add("c c r s");
            Assert.AreEqual(newShapes.SeqList, testList);
        }

        /// <summary>
        /// Test for DeletionSequence method, when sequence is out of range, no changes should be made in this case.
        /// </summary>
        [Test]
        public void OutOfRangeSequenceDeletionTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.AddNewSequence("s c r t p");
            newShapes.AddNewSequence("r r r c");
            newShapes.AddNewSequence("c c r s");

            newShapes.DeleteSequence(4);
            List<string> testList = new List<string>();
            testList.Add("s c r t p");
            testList.Add("c c r s");
            testList.Add("r r r c");
            Assert.AreEqual(newShapes.SeqList, testList);
        }

        /// <summary>
        /// Test for Undo and Redo method, testing undo and redo of default size value.
        /// </summary>
        [Test]
        public void DefaultSizeUndoRedoTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.ChangeDefaultSize(20);

            newShapes.Undo();
            Assert.AreEqual(newShapes.DefaultSize, 10);

            newShapes.Redo();
            Assert.AreEqual(newShapes.DefaultSize, 20);
        }

        /// <summary>
        /// Test for Undo and Redo method, testing undo and redo for shape colors.
        /// </summary>
        [Test]
        public void ColorUndoRedoTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);
            newShapes.AddNewSequence("s p r");
            newShapes.AddNewSequence("t c r s");

            newShapes.ChangeDefaultColor(1, 2, "red");
            newShapes.ChangeDefaultColor(1, 2, "blue");
            newShapes.Undo();
            Assert.AreEqual(newShapes.ShapeList[0][1].Color, "red");

            newShapes.Redo();
            Assert.AreEqual(newShapes.ShapeList[0][1].Color, "blue");
        }

        /// <summary>
        /// Test for Undo and Redo method, testing undo and redo for AddSequence method.
        /// </summary>
        [Test]
        public void AddSequenceUndoRedoTest()
        {
            ShapesFeatures newShapes = new ShapesFeatures(10);

            newShapes.AddNewSequence("s c r t p");
            newShapes.AddNewSequence("r r r c");
            newShapes.AddNewSequence("c c r s");

            List<string> testList = new List<string>();
            testList.Add("s c r t p");
            testList.Add("c c r s");

            newShapes.Undo();
            Assert.AreEqual(newShapes.SeqList, testList);

            newShapes.Redo();
            testList.Add("c c r s");
            Assert.AreEqual(newShapes.SeqList, testList);
        }
    }
}
