using System;
class Jiaogu 
{
	public static void Main(string[] args) 
	{
		Console.Write("\n������һ����:");
		string s = Console.ReadLine();
		int a = int.Parse( s );

		while( a != 1 )
		{
			Console.Write( " " +a );
      a= (a % 2 == 1)? a*3+1: a /2;
		}
		Console.WriteLine(" " +a);
	}
}
