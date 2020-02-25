using System;
using System.Collections.Generic;

public class Triangle
{
  public int Side1;
  public int Side2;
  public int Side3;


  public Triangle(int side1, int side2, int side3)
  {
    Side1 = side1;
    Side2 = side2;
    Side3 = side3;
  }

  public string TriangleType()
  {
    if (Side1 > (Side2 + Side3) || Side2 > (Side1 + Side3) || Side3 > (Side1 + Side2))
    {
      return "This is not a Triangle";
    }
    else if ((Side1 != Side2) && (Side1 != Side3) && (Side2 != Side3))
    {
      return "This is a Scalene Triangle";
    } 
    else if ((Side1 == Side2) && (Side1 == Side3))
    {
      return "This is an Equilateral Triangle";
    }
    else if ((Side1 == Side2) || (Side1 == Side3) || (Side2 == Side3))
    {
      return "This is a Isosceles Triangle";
    }
  
    else 
    {
      return "meow =^.^=";
    }
  }
}


public class Program
{
  public static void Main()
  {
    Console.WriteLine("Please enter a number for side 1");
    string stringSide1 = Console.ReadLine();
    int side1 = int.Parse(stringSide1);
    Console.WriteLine("Please enter a number for side 2");
    string stringSide2 = Console.ReadLine();
    int side2 = int.Parse(stringSide2);
    Console.WriteLine("Please enter a number for side 3");
    string stringSide3 = Console.ReadLine();
    int side3 = int.Parse(stringSide3);
    Triangle userTriangle = new Triangle(side1, side2, side3);
    string checkTriangle = userTriangle.TriangleType();
    Console.WriteLine(checkTriangle);
  }


  
}