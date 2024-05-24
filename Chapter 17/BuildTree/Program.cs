using BinaryTree;

namespace BuildTree
{
	class Program
	{
		static void Main(string[] args)
		{
			Tree<char> charTree = null;
			InsertIntoTree<char>(ref charTree, 'M', 'X', 'A', 'M', 'Z', 'Z', 'N');
			string sortedData = charTree.WalktTree();
			Console.WriteLine($"Sorted data is: {sortedData}");

		}

		/* Static ve void döndüren bir fonksiyon, parametre olarak binarytreeyi referans alıyor, 
		 * bir de binary treeye verilecek tipte TItem dizisi, ama item sayısı bilinmediği için params ile alıyor
		 * son olarak bu ITemların hepsinin Comparable olmasını istiyoruz ki binary treeye yerleştirebilelim
		 */
		static void InsertIntoTree<TItem>(ref Tree<TItem> tree, params TItem[] data) where TItem : IComparable<TItem>
		{
			foreach (TItem datum in data)
			{
				if (tree is null)
				{
					tree = new Tree<TItem>(datum);
				}
				else
				{
					tree.Insert(datum);
				}
			}

		}
	}
}