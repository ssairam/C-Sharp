using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    /* 
    Context 
Given a  2D Array, :

1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 0 0 0 0
0 0 0 0 0 0
0 0 0 0 0 0
We define an hourglass in  to be a subset of values with indices falling in this pattern in 's graphical representation:

a b c
  d
e f g
There are  hourglasses in , and an hourglass sum is the sum of an hourglass' values.

Task 
Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum.

Note: If you have already solved the Java domain's Java 2D Array challenge, you may wish to skip this challenge.

Input Format

There are  lines of input, where each line contains  space-separated integers describing 2D Array ; every value in  will be in the inclusive range of  to .

Constraints

Output Format

Print the largest (maximum) hourglass sum found in .

Sample Input

1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0
Sample Output

19
  */
    public class MatrixMultiplication
    {
        public int Run()
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            var hourGlassValue = new int[16];
            var counter = 0;
            var colCount = 0;

            for (int i = 0; i < 4; i++)//Rows
            {
                for (int j = 0; j < 4; j++)//Columns
                {
                    var m = new Matrix();
                    m.Initialize(i, j + colCount, arr);
                    hourGlassValue[counter] = m.GetTotal;
                    counter++;
                }
            }
            return hourGlassValue.Max();
        }

        private class Matrix
        {
            int _m, _n; int[][] _matrix;
            int _firstRow = 0;
            int _secondRow = 0;
            int _thirdRow = 0;

            public int GetTotal
            {
                get
                {
                    return _firstRow + _secondRow + _thirdRow;
                }
            }

            public void Initialize(int m, int n, int[][] matrix)
            {
                _m = m; _n = n; _matrix = matrix;
                FirstRowTotal();
                GetSecondRow();
                GetThirdRow();
            }

            private void FirstRowTotal()
            {
                if (_n + 2 > _matrix.GetLength(0)) throw new Exception("Invalid Operation!");
                _firstRow = _matrix[_m][_n] + _matrix[_m][_n + 1] + _matrix[_m][_n + 2];
            }
            public void GetSecondRow()
            {
                if (_n + 2 > _matrix.GetLength(0)) throw new Exception("Invalid Operation!");
                _secondRow = _matrix[RowCount(_m + 1)][_n + 1];
            }
            public void GetThirdRow()
            {
                if (_n + 2 > _matrix.GetLength(0)) throw new Exception("Invalid Operation!");
                _thirdRow = _matrix[RowCount(_m + 2)][_n] + _matrix[RowCount(_m + 2)][_n + 1] + _matrix[RowCount(_m + 2)][_n + 2];
            }

            private int RowCount(int row)
            {
                if (row > 5)
                    return row % 6;
                else
                    return row;
            }
        }
    }
}
