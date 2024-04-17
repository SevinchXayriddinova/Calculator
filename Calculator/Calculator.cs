using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public static class Calculator
	{
		
		public static double SolveMath(List<double> doubles, List<char> operators)
		{


			while (operators.Any(x => x == '*' || x == '/'))
			{
				var oper = operators.FindIndex(x => x == '*' || x == '/');
				if (operators[oper] == '/' && doubles[oper + 1] == 0)
				{
					throw new DivideByZeroException();
				}
				else
				{
					var res = Calculate(doubles[oper], doubles[oper + 1], operators[oper].ToString());
					doubles.RemoveRange(oper, 2);
					doubles.Insert(oper, res);
					operators.RemoveAt(oper);
				}
			}

			while (operators.Count > 0)
			{
				var res = Calculate(doubles[0], doubles[1], operators[0].ToString());
				doubles.RemoveRange(0, 2);
				doubles.Insert(0, res);
				operators.RemoveAt(0);
			}
				
					
				
			return doubles[0];
		}



		

		public static double Calculate(double value1, double value2, string mathOperator)
		{
			double result = 0;
			switch (mathOperator)
			{
				case "/":
					result = value1 / value2;
					break;
				case "*":
					result = value1 * value2;
					break;
				case "+":
					result = value1 + value2;
					break;
				case "-":
					result = value1 - value2;
					break;
				}

				return result;
			}
		
	}
}
