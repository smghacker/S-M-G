using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MatrixUnitTests
{
    [TestClass]
    public class MatrixDemoTests
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void CheckAndGetInputForDimensionOutOfRangeExceptionTest1()
        {
            Console.SetIn(new System.IO.StringReader("-1"));
            MatrixDemo.CheckAndGetInputForDimension(Console.ReadLine());
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void CheckAndGetInputForDimensionOutOfRangeExceptionTest2()
        {
            Console.SetIn(new System.IO.StringReader("a"));
            MatrixDemo.CheckAndGetInputForDimension(Console.ReadLine());
        }

        [TestMethod]
        public void MainProgramTestConsoleOutUsingFilesRegularTest()
        {
            FileStream newStream;
            StreamWriter writer;
            try
            {
                newStream = new FileStream("../../Actual.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(newStream);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Actual.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            Console.SetIn(new System.IO.StringReader("6"));
            MatrixDemo.Main();
            writer.Close();
            newStream.Close();

            //Read the actual and expected file and then comparing them 
            //The files are in folder MatrixUnitTest :)
            var file1Lines = File.ReadLines("../../ExpectedRegularTest.txt");
            var file2Lines = File.ReadLines("../../Actual.txt");
            
            IEnumerable<String> inFirstNotInSecond = file1Lines.Except(file2Lines);
            IEnumerable<String> inSecondNotInFirst = file2Lines.Except(file1Lines);
            
            bool isThisTheExpectedOutput = inFirstNotInSecond.Count() == 0 && inSecondNotInFirst.Count() == 0;
            Assert.IsTrue(isThisTheExpectedOutput);
        }
    }
}