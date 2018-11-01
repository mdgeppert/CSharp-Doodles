using System;


namespace TriangleApplication
{
	class Triangle
	{
		double leftSide;
		double bottomSide;
		public void AcceptSides()
		{
			leftSide = 3;
			bottomSide = 4;
			
		}
		public double GetArea()
		{
			return .5 * ( bottomSide * leftSide);
		}

		public double GetHypotenuse()
		{
			double Hypnse = Math.Pow(leftSide, 2) + Math.Pow(bottomSide, 2);
			return Math.Sqrt((double) Hypnse);
		}
		public void Display()
		{
			Console.WriteLine("The left side is {0} units long.", leftSide);
			Console.WriteLine("The bottom side is {0} units long.", bottomSide);
			Console.WriteLine("The hypotenuse is {0} units long", GetHypotenuse());
			Console.WriteLine("The area of the triangle is {0} square units.", GetArea());

		}
		class ExecuteTriangle
		{
			static void Main(string[] args)
			{
				Triangle t = new Triangle();
				t.AcceptSides();
				t.GetArea();
				t.Display();
				t.GetArea();
				t.GetHypotenuse();
				Console.WriteLine("Press Enter to continue.");
				Console.ReadLine();


			}
		}

		
	}

}

