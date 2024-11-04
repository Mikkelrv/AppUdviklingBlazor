
using System.Drawing;
using System.Numerics;

namespace AppUdviklingBlazor.Model
{
	public class TicTacToeWinStrategies
	{
		public bool isWin(int[,] arr, int player)
		{
			if (CheckDiagonalWin(arr,player))  return true;
			if (ThreeDown(arr, player)) return true; 
			if (ThreeVertically(arr, player)) return true;
			return false;
		}

		private bool ThreeVertically(int[,] arr, int player)
		{
			bool hasWon = false;
			for (int i = 0; i < arr.Length; i++)
			{
				for(int j = 1; j <= arr.Length; j++)
				{
					if (arr[i, j] != arr[i, j-1]) { hasWon = false;  break; }
					else hasWon = true;
				}
			}
			return hasWon;
		}

		private bool ThreeDown(int[,] arr, int player)
		{
			bool hasWon = false;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[0,i] == arr[1,i] && arr[1,i] == arr[2,i]) { return hasWon = true; }
			}
			return hasWon;
		}

		public bool CheckDiagonalWin(int[,] board, int player)
		{
			int size = board.GetLength(0); // Get the size of the board (assuming it's a square)

			// Check primary diagonal (top-left to bottom-right)
			bool primaryDiagonalWin = true;
			for (int i = 0; i < size; i++)
			{
				if (board[i, i] != player)
				{
					primaryDiagonalWin = false;
					break;
				}
			}

			// Check secondary diagonal (top-right to bottom-left)
			bool secondaryDiagonalWin = true;
			for (int i = 0; i < size; i++)
			{
				if (board[i, size - i - 1] != player)
				{
					secondaryDiagonalWin = false;
					break;
				}
			}

			// Return true if either diagonal is a win
			return primaryDiagonalWin || secondaryDiagonalWin;
		}

	}
}
