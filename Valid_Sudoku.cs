public class Solution 
{
    //https://github.com/MeowCoderC/PuzzleSudoku-150leetcode-#
    public bool IsValidSudoku(char[][] board) 
    {
        for (int row = 0; row < board.Length; row++)
        {
            HashSet<char> r =  new HashSet<char>();
            for (int i = 0; i < board.Length; i++)
            {
                if(board[row][i] == '.') continue;
                if (!r.Add(board[row][i]))
                {
                    return false;
                }
            }
        }

        for (int col = 0; col < board.Length; col++)
        {
            HashSet<char> c = new HashSet<char>();
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i][col] == '.') continue;
                if (!c.Add(board[i][col]))
                {
                    return false;
                }
            }
        }

        for (int square = 0; square < 9; square++)
        {
            HashSet<char> s = new HashSet<char>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int row = (square / 3) * 3 + i;
                    int col = (square % 3) * 3 + j;
                    if (board[row][col] == '.') continue;
                    if(!s.Add(board[row][col])) return false;
                }
            }
        }
        
        return true;
    }
}