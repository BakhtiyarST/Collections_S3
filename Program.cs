using System.Net.NetworkInformation;

namespace Collections_S3;

public class Program
{
	static Stack<Tuple<int, int>> _path;

	static void Main(string[] args)
	{
		// Task1();
		// Task2();
		Task3();

	}

	static void Task3()
	{
		int[,] maze = new int[,]
		{
			{1, 1, 1, 1, 1, 1, 1 },
			{1, 0, 0, 0, 0, 0, 1 },
			{1, 0, 1, 1, 1, 0, 1 },
			{0, 0, 0, 0, 1, 0, 2 },
			{1, 1, 0, 0, 1, 1, 1 },
			{1, 1, 1, 1, 1, 1, 1 },
			{1, 1, 1, 1, 1, 1, 1 }
		};

		// <<<<<<< Home work modified maze >>>>>>>
		int[,] mazeAlt = new int[,]
		{
			{1, 1, 1, 1, 1, 1, 1 },
			{1, 0, 0, 0, 0, 0, 1 },
			{1, 0, 1, 1, 1, 0, 1 },
			{2, 0, 0, 0, 1, 0, 2 },
			{1, 1, 0, 2, 1, 1, 1 },
			{1, 1, 1, 1, 1, 1, 1 },
			{1, 1, 1, 2, 1, 1, 1 }
		};
		_path = new Stack<Tuple<int, int>>();
		// FindPath(1, 1, maze);
		FindPathAlt(1, 1, mazeAlt);
	}

	// <<<<<<< Home work modified function >>>>>>>
	static int FindPathAlt(int i, int j, int[,] maze)
	{
		int countWays = 0;

		Console.WriteLine(maze[i, j]);
		if (maze[i, j] == 0)
			_path.Push(new Tuple<int, int>(i, j));

		while (_path.Count > 0)
		{
			var current = _path.Pop();

			Console.WriteLine($"{current.Item1},{current.Item2}");
			if (maze[current.Item1, current.Item2] == 2)
			{
				Console.WriteLine($"The way out is found {current.Item1},{current.Item2}");
				countWays++;
  			// return countWays;
			}

			maze[current.Item1, current.Item2] = 1;

			if (current.Item1 + 1 < maze.GetLength(0)
				&& maze[current.Item1 + 1, current.Item2] != 1)
				_path.Push(new Tuple<int, int>(current.Item1 + 1, current.Item2));

			if (current.Item2 + 1 < maze.GetLength(1)
				&& maze[current.Item1, current.Item2 + 1] != 1)
				_path.Push(new Tuple<int, int>(current.Item1, current.Item2 + 1));

			if (current.Item1 > 0 && maze[current.Item1 - 1, current.Item2] != 1)
				_path.Push(new Tuple<int, int>(current.Item1 - 1, current.Item2));

			if (current.Item2 > 0 && maze[current.Item1, current.Item2 - 1] != 1)
				_path.Push(new Tuple<int, int>(current.Item1, current.Item2 - 1));

		}
		Console.WriteLine("No way out");
		return countWays;
	}

	static bool FindPath(int i, int j, int[,] maze)
	{
		Console.WriteLine(maze[i, j]);
		if (maze[i,j]==0)
			_path.Push(new Tuple<int,int>(i, j));

		while (_path.Count > 0)
		{
			var current = _path.Pop();

			Console.WriteLine($"{current.Item1},{current.Item2}");
			if (maze[current.Item1, current.Item2] == 2)
			{
				Console.WriteLine($"The way out is found {current.Item1},{current.Item2}");
				return true;
			}

			maze[current.Item1, current.Item2] = 1;

			if (current.Item1 + 1 < maze.GetLength(0)
				&& maze[current.Item1 + 1, current.Item2] != 1)
				_path.Push(new Tuple<int, int>(current.Item1 + 1, current.Item2));

			if (current.Item2 + 1 < maze.GetLength(1)
				&& maze[current.Item1, current.Item2 + 1] != 1)
				_path.Push(new Tuple<int, int>(current.Item1, current.Item2 + 1));

			if (current.Item1 > 0 && maze[current.Item1 - 1, current.Item2] != 1)
				_path.Push(new Tuple<int, int>(current.Item1 - 1, current.Item2));

			if (current.Item2 > 0 && maze[current.Item1, current.Item2 - 1] != 1)
				_path.Push(new Tuple<int, int>(current.Item1, current.Item2 - 1));

		}
		Console.WriteLine("No way out");
		return false;
	}

	static void Task2()
	{
		//foreach (var x in new CustomEnumerable())
		//	Console.WriteLine(x);

		var ce = new CustomEnumerable();
		foreach (var x in ce)
		{
			Console.WriteLine($"{x}");
		}
	}

	static void Task1()
	{
		var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
		Console.WriteLine(string.Join(", ", list));
		ReverseList(list);
		Console.WriteLine(string.Join(", ", list));
	}
	static void ReverseList(List<int> list)
	{
		int listSize;
		listSize = list.Count;
		Stack<int> stack = new Stack<int>();
		for (int i = 0; i < list.Count; i++)
			stack.Push(list[i]);
		list.Clear();
		for (int i = 0; i < listSize; i++)
			list.Add(stack.Pop());
	}
}
