public class TicTacToe {

    private readonly int _n;
    private readonly int[,] _rows;
    private readonly int[,] _cols;
    private readonly int[] _diagonal1;
    private readonly int[] _diagonal2;

    public TicTacToe(int n) {
        _n = n;
        _rows = new int[n, 2];
        _cols = new int[n, 2];
        _diagonal1 = new int[2];
        _diagonal2 = new int[2];
    }
    
    public int Move(int row, int col, int player) {
        _rows[row, player - 1]++;
        if (_rows[row, player - 1] == _n)
        {
            return player;
        }

        _cols[col, player - 1]++;
        if (_cols[col, player - 1] == _n)
        {
            return player;
        }

        if (row == col)
        {
            _diagonal1[player - 1]++;
            if (_diagonal1[player - 1] == _n)
            {
                return player;
            }
        }

        if(row + col == _n - 1)
        {
            _diagonal2[player - 1]++;
            if (_diagonal2[player - 1] == _n)
            {
                return player;
            }
        }

        return 0;
    }
}
