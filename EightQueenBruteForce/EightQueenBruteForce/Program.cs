using System;


namespace EightQueenBruteForce
{



    public class EightQueens
    {

        char[,] board = new char[8, 8];
        int queens;
        int count;
        public void PlaceQueens()
        {

            for (int firstQueenRow = 0;
                firstQueenRow < board.GetLength(0) && queens < 8;
                firstQueenRow++)
            {
                for (int firstQueenCol = 0;
                firstQueenCol < board.GetLength(1) && queens < 8;
                firstQueenCol++)
                {
                    // reset the board 
                    board = new char[8, 8];
                    queens = 0;

                    // place first queen at starting position 
                    board[firstQueenRow, firstQueenCol] = 'Q';
                    ConflictSquares(firstQueenRow, firstQueenCol);
                    ++queens;

                    // remaining queens will be placed in board 

                    bool done = false; // indicates if all squares filled



                    for (int rowMove = 0;
                     rowMove < board.GetLength(0) && !done; rowMove++)
                    {
                        for (int colMove = 0;
                        colMove < board.GetLength(1) && !done; colMove++)
                        {
                            // if valid move, place queen 

                            // and mark off conflict squares 
                            if (QueenCheck(rowMove, colMove))
                            {
                                board[rowMove, colMove] = 'Q';
                                ConflictSquares(rowMove, colMove);
                                ++queens;
                                
                            } // end if 

                            // done when no more squares left 
                            if (!AvailableSquare())
                                done = true;

                        } // end for colMove 
                    } // end for rowMove 
                } // end for firstQueenCol 
            } // end for firstQueenRow 
            
            PrintBoard();
           
        }


        public bool ValidMove(int row, int column)
        {
            return (row >= 0 && row < 8 && column >= 0 && column < 8);
        }
        public bool AvailableSquare()
        {
            for (int row = 0; row < board.GetLength(0); row++)
                for (int col = 0; col < board.GetLength(1); col++)
                    if (board[row, col] == '\0')

                        return true;

            return false;
        }

        public bool QueenCheck(int rowValue, int colValue)
        {
            return (board[rowValue, colValue] == '\0');
        }

        public void ConflictSquares(int row, int col)
        {
            for (int i = 0; i < 8; i++)
            {
                // place a '*' in the row occupied by the queen 
                if (board[row, i] == '\0')
                    board[row, i] = '*';
                // place a '*' in the col occupied by the queen 
                if (board[i, col] == '\0')
                    board[i, col] = '*';
            } // end fo r 
              // place a '*' in the diagonals occupied by the queen 
            XDiagonals(row, col);
        } // end method XConflictSquares 
          // place * in diagonals of position in all 4 directions 
        public void XDiagonals(int rowValue, int colValue)
        {
            int row = rowValue, column = colValue;
            // upper left diagonal 
            for (int diagonal = 0; diagonal < 8 && ValidMove(--row, --column); diagonal++)
                board[row, column] = '*';
            row = rowValue;
            column = colValue;
            // upper right diagonal
            for (int diagonal = 0; diagonal < 8 && ValidMove(--row, ++column); diagonal++)
                board[row, column] = '*';
            row = rowValue;
            column = colValue;
            // lower left diagonal 
            for (int diagonal = 0; diagonal < 8 && ValidMove(++row, --column); diagonal++)
                board[row, column] = '*';
            row = rowValue;
            column = colValue;
            // lower right diagonal 
            for (int diagonal = 0; diagonal < 8 && ValidMove(++row, ++column); diagonal++)
                board[row, column] = '*';
        } // end method XDiagonals 
          // displays the chessboard 
        public void PrintBoard()
        {
            Console.Write(" ");
           
            // display numbers for column 
            for (int k = 1; k < 9; k++)
                Console.Write(" {0}", k);

            Console.WriteLine("\n");

            for (int row = 0; row < board.GetLength(0); row++)
            {
                Console.Write("{0}", row);

                for (int column = 0; column < board.GetLength(0); column++)
                    Console.Write(" {0}", board[row, column]);

                Console.WriteLine();
            } // end for 
            Console.WriteLine("\n{0} queens placed on the board.", queens);
            
         
            Console.WriteLine("\nNumber of solutions: {0}\n", queens);            
            
        }
        public class EightQueensTest
        {
            public static void Main(string[] args)
            {
                EightQueens application = new EightQueens();
                application.PlaceQueens();
                Console.ReadKey();
            } // end Main 
        }
    }
}

