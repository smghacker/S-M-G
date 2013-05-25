using System;
using Matrix;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixUnitTests
{
    [TestClass]
    public class SpecialMatrixTests
    {
        [TestMethod]
        public void ConstructorRegularTest()
        {
            SpecialMatrix specialMatrix = new SpecialMatrix(3);
            Assert.AreEqual(0, specialMatrix.Matrix[1, 1]);
        }

        [TestMethod]
        public void MatrixPropertyRegularTest()
        {
            SpecialMatrix specialMatrix = new SpecialMatrix(3);
            int[,] matrix = new int[3,3];
            int length = matrix.GetLength(0);
            for (int i = 0; i < length; i++)
			{
			    for (int j = 0; j < length; j++)
			    {
			        matrix[i,j] = i+j;
			    }
			}
            specialMatrix.Matrix = matrix;
            int actual = specialMatrix.Matrix[1, 1];
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void MatrixPropertyTestWithNull()
        {
            SpecialMatrix specialMatrix = new SpecialMatrix(3);
            specialMatrix.Matrix = null;
        }

        [TestMethod]
        public void FillMatrixRegularTest()
        {
            SpecialMatrix specialMatrix = new SpecialMatrix(6);

            specialMatrix.FillMatrix();

            Assert.AreEqual(31, specialMatrix.Matrix[2, 1]);
        }
    }
}
