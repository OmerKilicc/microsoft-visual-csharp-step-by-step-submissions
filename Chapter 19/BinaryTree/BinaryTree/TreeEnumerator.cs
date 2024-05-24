using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
	internal class TreeEnumerator<TItem> : IEnumerator<TItem> where TItem : IComparable<TItem>
	{
		private Tree<TItem> currentData = null;
		private TItem currentItem = default(TItem);
		private Queue<TItem> enumData = null;

		public TreeEnumerator(Tree<TItem> currentData)
		{
			this.currentData = currentData;
		}

		private void populate(Queue<TItem> enumQueue, Tree<TItem> tree)
		{
			if (tree.LeftTree is not null)
			{
				populate(enumQueue, tree.LeftTree);
			}

			enumQueue.Enqueue(tree.NodeData);

			if (tree.RightTree is not null)
			{
				populate(enumQueue, tree.RightTree);
			}
		}

		TItem IEnumerator<TItem>.Current
		{
			get
			{
				if (this.enumData is null)
				{
					throw new InvalidOperationException("Use MoveNext before calling Current");
				}
				return this.currentItem;
			}
		}

		object IEnumerator.Current => throw new NotImplementedException();

		public bool MoveNext()
		{
			if (this.enumData is null)
			{
				this.enumData = new Queue<TItem>();
				populate(this.enumData, this.currentData);
			}

			if (this.enumData.Count > 0)
			{
				this.currentItem = this.enumData.Dequeue();
				return true;
			}

			return false;
		}

		void IDisposable.Dispose(){}

		void IEnumerator.Reset()
		{
			throw new NotImplementedException();
		}
	}
}
