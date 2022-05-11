namespace ConsoleApp3
{
    public class Program
    {
		public static void Main()
		{
			string msg = "";
			for (int i = 1; i <= 100; i++)
				Console.WriteLine(Mensagem(i));
		}

		public static string Mensagem(int i)
		{
			int divisor = DivisivelPor3(i) + DivisivelPor5(i) + DivisivelPor7(i);
			switch (divisor)
			{
				case 1:
					return "fizz";
				case 2:
					return "buzz";
				case 3:
					return "fizz buzz";
				case 4:
				case 5:
				case 6:
					return "Leonardo";
				default:
					return i.ToString();
			}
		}

		public static int DivisivelPor3(int i) => i % 3 == 0 ? 1 : 0;

		public static int DivisivelPor5(int i) => i % 5 == 0 ? 2 : 0;

		public static int DivisivelPor7(int i) => i % 7 == 0 ? 4 : 0;
	}

}
   