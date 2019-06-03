﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class game
    {
        int size;
        int[,] map;
        int space_x, space_y;

        public game (int size)
        {
            if (size < 2) size = 2;
            if (size > 5) size = 5;
            this.size = size;
            map = new int [size, size]; 
        }

        public void start ()
        {
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    map[x, y] = coords_posit(x, y) + 1;
            space_x = size - 1;
            space_y = size - 1;
            map[space_x, space_y - 1] = 0;       
        }

        public int number (int posit)
        {
            int x, y;
            posit_coords(posit, out x, out y);
            if (x < 0 || x >= size) return 0;
            if (y < 0 || y >= size) return 0;
            return map[x, y];
        }

        private int coords_posit (int x, int y)
        {
            return y * size + x;
        }


        private int posit_coords (int posit, out int x, out int y)
        {
            x = posit % size;
            y = posit / size;

        }

    }
}
