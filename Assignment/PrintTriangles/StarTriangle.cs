using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleFunctions
{
    /// <summary>
    /// This class defines the methods for displaying Star Triangles
    /// </summary>
    public class StarTriangle
    {
        public static int HeightOfTriangle = 1;
       
        /// <summary>
        /// This method displays the star triangle for the user.
        /// A Star(*) triangle is printed for user
        /// </summary>
        public static void PrintStarTriangle()
        {

            Console.WriteLine("\n\n\n Below is the triangle with height of {0} lines\n", HeightOfTriangle);

            int arraySize = 4 * HeightOfTriangle - 3;
            char[] triangleArray = new char[arraySize];
            int halfTriangleArrayLength = triangleArray.Length / 2;
            for (int i = 0; i <= halfTriangleArrayLength; i += 2)
            {
                triangleArray[halfTriangleArrayLength] = '*';
                triangleArray[halfTriangleArrayLength - i] = '*';
                triangleArray[halfTriangleArrayLength + i] = '*';

                Console.WriteLine(triangleArray);
            }

            Console.WriteLine("\n");
        }

    }
}
