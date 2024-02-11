﻿using BinaryTree;

class Program
{
	static void Main(string[] args)
	{
		Tree<int> tree1 = new Tree<int>(10);
		Tree<string> tree2 = new Tree<string>("Hello");
		tree1.Insert(5);
		tree1.Insert(11);
		tree1.Insert(5);
		tree1.Insert(-12);
		tree1.Insert(15);
		tree1.Insert(0);
		tree1.Insert(14);
		tree1.Insert(-8);
		tree1.Insert(10);
		tree1.Insert(8);
		tree1.Insert(8);
		string sortedData = tree1.WalktTree();
		Console.WriteLine(sortedData + "\n");
	}

}
