using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    public class SpecialMatrix
    {
        private int[,] matrix;

        public int[,] Matrix
        {
            get { return this.matrix; }
            set
            {
                if (value != null)
                {
                    this.matrix = value;
                }
                else
                {
                    throw new ArgumentNullException("matrix", "Matrix is missing");
                }
            }
        }

        private int dimensions;

        public int Dimensions
        {
            get { return this.dimensions; }
            set { this.dimensions = value; }
        }

        public SpecialMatrix(int dimension)
        {
            this.Dimensions = dimension;
            this.Matrix = new int[this.Dimensions, this.Dimensions];
        }

        private void ChangeDirectionCoeficients(ref int directionXCoef, ref int directionYCoef)
        {
            int[] dirXCoef = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirYCoef = { 1, 0, -1, -1, -1, 0, 1, 1 }; 
            int numberOfDirections = dirXCoef.Length;

            int positionOfCoeficients = 0;
            for (int i = 0; i < numberOfDirections; i++)
            {
                if (dirXCoef[i] == directionXCoef && dirYCoef[i] == directionYCoef)
                {
                    positionOfCoeficients = i;
                    break;
                }
            }

            directionXCoef = dirXCoef[(positionOfCoeficients + 1) % 8];
            directionYCoef = dirYCoef[(positionOfCoeficients + 1) % 8];

        }

        private bool CheckIfNextCellIsEmpty(int currentX, int currentY)
        {
            int[,] arr = this.Matrix;
            int[] dirXCoef = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirYCoef = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int numberOfDirections = dirXCoef.Length;

            for (int i = 0; i < numberOfDirections; i++)
            {
                if (currentX + dirXCoef[i] >= arr.GetLength(0) || currentX + dirXCoef[i] < 0)
                {
                    dirXCoef[i] = 0;
                }

                if (currentY + dirYCoef[i] >= arr.GetLength(0) || currentY + dirYCoef[i] < 0)
                {
                    dirYCoef[i] = 0;
                }
            }

            for (int i = 0; i < numberOfDirections; i++)
                if (arr[currentX + dirXCoef[i], currentY + dirYCoef[i]] == 0)
                {
                    return true;
                }
            return false;
        }

        private void FindEmptyCell(out int x, out int y)
        {
            x = 0;
            y = 0;
            int[,] arr = this.Matrix;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        return;
                    }
                }
            }
        }

        public void FillMatrix()
        {
            int currentNumber = 1;
            int row = 0; 
            int col = 0; 
            int currentDirXCoef = 1;
            int currentDirYCoef = 1;
            int dimension = this.Dimensions ;
            while (true)
            {
                this.Matrix[row, col] = currentNumber;

                if (!this.CheckIfNextCellIsEmpty(row, col))
                {
                    FindEmptyCell(out row, out col);

                    if (row == 0 && col == 0)
                    {
                        break;
                    }

                    ChangeDirectionCoeficients(ref currentDirXCoef, ref currentDirYCoef);
                    currentNumber++;
                    this.Matrix[row, col] = currentNumber; 
                }
                else
                {
                    while ((row + currentDirXCoef >= dimension || row + currentDirXCoef < 0 || col + currentDirYCoef >= dimension || col + currentDirYCoef < 0 || this.Matrix[row + currentDirXCoef, col + currentDirYCoef] != 0))
                    {
                        ChangeDirectionCoeficients(ref currentDirXCoef, ref currentDirYCoef);
                    }

                    row += currentDirXCoef;
                    col += currentDirYCoef;
                    currentNumber++;
                }
            }
        }

        public void Print()
        {
            int length = this.Dimensions;
            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < length; col++)
                {
                    Console.Write("{0,3}", this.Matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
