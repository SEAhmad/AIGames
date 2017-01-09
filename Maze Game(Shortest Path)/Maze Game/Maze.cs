﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maze_Game
{
    class Maze
    {
        public static Queue que = new Queue();
        public static Stack stack = new Stack();
        public static int[,] mzar = new int[13, 30]
        {
               {1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
               {1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1},
               {1,0,0,0,1,1,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
               {1,0,0,0,1,0,0,0,0,1,0,0,0,0,1,1,1,1,0,0,0,1,1,1,1,1,1,0,0,1},
               {1,0,0,0,1,1,1,1,1,1,1,1,1,0,0,0,0,1,0,0,0,1,0,0,1,0,0,0,0,1},
               {1,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,1,0,0,0,1,0,0,1,0,1,1,1,1},
               {1,0,0,0,0,0,1,0,0,1,1,1,1,0,0,0,0,1,1,1,0,1,0,0,1,0,1,0,0,1},
               {1,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,1,0,1,0,0,1},
               {1,1,1,1,1,0,1,0,0,1,0,0,0,0,0,1,0,0,0,1,1,1,1,1,1,0,0,0,0,1},
               {1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,1,1,1,1},
               {1,0,0,0,1,1,1,1,1,1,0,0,1,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0,1},
               {1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1},
               {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1}
               };
        public static int[,] visted = new int[13, 30];
        public static void start()
        {
            stack.Clear();
            que.Clear();
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    visted[i, j] = 0;
                }
            }
        }
    }
}
