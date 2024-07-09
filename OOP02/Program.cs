namespace OOP02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			employees emp1 = new employees(1,"yousef",5,5600,new hire_date("24","11","2001"),"F");
			Console.WriteLine(emp1.ToString());



		}
	}
}
