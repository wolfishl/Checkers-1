﻿using CheckersProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    class AlphaBeta
    {

        public static int NrEntries = 0;

        public static Board callingFunction(Board board, int depth, double alfa, double beta, Player player)
        {
            Player opponent = player == Player.MAX ? Player.MIN : Player.MAX;
            Board bestMove = null;
            Double value = Game.MIN_VALUE;
            foreach(Board nextPosition in board.GetAllMoves(player))
            {
                double thisVal = Value(nextPosition, depth - 1, alfa, beta, opponent);
                if (thisVal > value)
                {
                    value = thisVal;
                    bestMove = nextPosition;
                }
            }
            return bestMove;
        }



        public static double Value(Board board, int depth, double alfa, double beta, Player player)
        {
            Trace.println("Enter alphabeta d = " + depth + " a = " + alfa + " b = " + beta + " P = " + player, 5);
            ++NrEntries;
            double value = 0.0;
            if (depth == 0)
            {
                value = board.HeuristicValue();
            }
            else
            {
                Player opponent = player == Player.MAX ? Player.MIN : Player.MAX;
                if (board.GameOver() && board.GetWinner() == opponent)
                {
                    value = player == Player.MAX ? Game.MIN_VALUE :
                    Game.MAX_VALUE;
                }

                if (player == Player.MAX)
                {
                    
                    foreach (Board nextPos in board.GetAllMoves(player))
                    {
                        double thisVal = Value(nextPos, depth - 1, alfa, beta, opponent);
                        if (thisVal > alfa)
                        {
                            alfa = thisVal;
                        }
                        if (beta <= alfa)
                        {
                            break;
                        }
                    }

                    value = alfa;
                }
                else  // player == Player.MIN
                {
                    foreach (Board nextPos in board.GetAllMoves(player))
                    {
                        double thisVal = Value(nextPos, depth - 1, alfa, beta, opponent);
                        if (thisVal < beta)
                        {
                            beta = thisVal;
                        }
                        if (beta <= alfa)
                        {
                            break;
                        }
                    }
                    value = beta;
                }
            }
            Trace.println("Exit alfabeta value = " + value + " depth " + depth, 5);
            return value;
        }

    }
}