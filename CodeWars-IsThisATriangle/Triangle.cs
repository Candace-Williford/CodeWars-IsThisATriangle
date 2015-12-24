using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_IsThisATriangle
{
    public static class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

//Implement a method that accepts 3 integer values a, b, c. The method should return true if 
//a triangle can be built with the sides of given length and false in any other case.

//(In this case, all triangles must have surface greater than 0 to be accepted).
//-----------------------------------------------------------------------------
//The Triangle Inequality Theorem
//  A + B > C
//  B + C > A
//  A + C > B
//All 3 of these conditions must return true