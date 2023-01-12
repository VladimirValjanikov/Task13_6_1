using System.Diagnostics;

namespace Task13_6_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var array = new int[1000000];

			var list = new List<int>(array);
			var linkedList = new LinkedList<int>(array);

			var watch = Stopwatch.StartNew();
			list.Insert(1, 1);
			Console.WriteLine($"Вставка в list: {watch.Elapsed.TotalMilliseconds}  мс");
			
			watch.Restart();

			linkedList.AddAfter(linkedList.First, 1);
			Console.WriteLine($"Вставка в linkedList: {watch.Elapsed.TotalMilliseconds}  мс");
			watch.Stop();

			Console.ReadLine();
		}
	}
}