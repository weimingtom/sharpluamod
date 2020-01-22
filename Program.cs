/*
 * Created by SharpDevelop.
 * User: a
 * Date: 2020/1/22
 * Time: 10:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using sharplua;

namespace sharpluatest
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
            HelloWorld.Main_();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}