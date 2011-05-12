using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErrorHandling
{
    class test
    {
        [STAThread]     // prebuilt attribute to run entire code in order
        static void Main(string[] args)
        {
            try	
			{
				Method1();
				Method2();
				Method3();

				//Optional
				OptionalMethod();


				Method5();

								
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine("Main-DivideByZero Exception:\n\t");
				Console.WriteLine("\tMain e.ToString: {0}", e.ToString());
				Console.WriteLine("\tMain e.Message: {0}", e.Message);
				Console.WriteLine("\tMain e.StackTrace: {0}", e.StackTrace);
				Console.WriteLine("\tMain e.InnerException: {0}", e.InnerException);
			}
			
			catch (StringErrorException e)
			{
				Console.WriteLine("Main StringErrorException:\n\t");
				Console.WriteLine("\tMain e.ToString: {0}", e.ToString());
				Console.WriteLine("\tMain e.Message: {0}", e.Message);
				Console.WriteLine("\tMain e.StackTrace: {0}", e.StackTrace);
				Console.WriteLine("\tMain e.InnerException: {0}", e.InnerException);
			}

			catch (Exception e)
			{
				Console.WriteLine("Main Overall Exception:\n\t");
				Console.WriteLine("\tMain e.ToString: {0}", e.ToString());
				Console.WriteLine("\tMain e.Message: {0}", e.Message);
				Console.WriteLine("\tMain e.StackTrace: {0}", e.StackTrace);
				Console.WriteLine("\tMain e.InnerException: {0}", e.InnerException);
			}
			finally
			{
				Console.WriteLine("\nEnd of Error Handling Exercise");
			}
		}

		public static void Method1()  // static means it does not need to be instantiated. It's already there to use. 
		{
			int varInteger1;
			int varInteger2;
			int varDivResult;
			try	
			{
				Console.WriteLine("\nIn Method 1");
				Console.Write("Enter data for variable 1: ");
				varInteger1 = Convert.ToInt32(Console.ReadLine());
				Console.Write("Enter data for variable 2: ");
				varInteger2 = Convert.ToInt32(Console.ReadLine());
				varDivResult = varInteger1 / varInteger2;
				Console.WriteLine("Division Result: {0}", varDivResult);
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine("Method 1-DivideByZero Exception:\n\t");
				Console.WriteLine("\te.ToString: {0}", e.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Method 1-Overall Exception:\n\t");
				Console.WriteLine("\te.ToString: {0}", e.ToString());
			}
		}

		public static void Method2()
		{
			int varInteger1;
			
			try	
			{
				Console.WriteLine("\nIn Method 2");
				varInteger1 = Convert.ToInt32("Bad Data");
			}
			catch (FormatException e)
			{
				Console.WriteLine("Method 2-Format Exception:\n\t");
				Console.WriteLine("\te.ToString: {0}", e.ToString());
			}
		}
		public static void Method3()
		{
			try 
			{
				Console.WriteLine("\nIn Method 3");
				Method4();
			}
			catch (FormatException e)
			{
				Console.WriteLine("Method 3-Overall Exception:\n\t");
				Console.WriteLine("\te.ToString: {0}", e.ToString());				
			}
		}

		public static void Method4()
		{
			int varInteger1;
			
			Console.WriteLine("In Method 4");
			varInteger1 = Convert.ToInt32("Bad Data");
		}

		public static void Method5()
		{
			int varInteger1;
			
			try	
			{
				Console.WriteLine("\nIn Method 5");
				varInteger1 = Convert.ToInt32("Bad Data");
			}
			catch (FormatException e)
			{
				Console.WriteLine("Method 5-Format Exception:\n\t");
				throw (new StringErrorException("Additional string info from Method 5",e));
			}
			
		}

		public static void OptionalMethod()
		{
			int varInteger1 = Int32.MaxValue; // .MaxValue is a property
			int varInteger2 = Int32.MaxValue;
			int varSum = 0;

			try	
			{
				Console.WriteLine("\nIn Optional Exercise");
				varSum = varInteger1 + varInteger2; 
				Console.WriteLine("Sum Unchecked: {0}", 
					varSum);
				varSum = checked(varInteger1 + varInteger2);
				Console.WriteLine("Sum Checked: {0}", 
					varSum);
			}
			catch (OverflowException e)
			{
				Console.WriteLine("Optional Exercise-Overflow Exception:\n\t");
				Console.WriteLine("\te.ToString: {0}", e.ToString());
			}
		}
    }
}
