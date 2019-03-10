using System;

namespace Lab7_PicturePuzzle.Controller
{
    //class to control the moves of the puzzle
    class PuzzleController
    {
        public int[] moveDown(int [] array, ref int emptyTile, int level_diffculty)
        {
            if ((emptyTile <= level_diffculty - 1) && (emptyTile >= level_diffculty - (int)Math.Sqrt(level_diffculty)))
                return array;

            int temp = array[emptyTile];
            array[emptyTile] = array[emptyTile + (int)Math.Sqrt(level_diffculty)];
            array[emptyTile + (int)Math.Sqrt(level_diffculty)] = temp;

            emptyTile = emptyTile + (int)Math.Sqrt(level_diffculty);
            return array;
        }

        public int[] moveUp(int[] array, ref int emptyTile, int level_diffculty)
        {
            if ((emptyTile <= (int)Math.Sqrt(level_diffculty) -1 )  && (emptyTile >= 0))
                return array;

            int temp = array[emptyTile];
            array[emptyTile] = array[emptyTile - (int)Math.Sqrt(level_diffculty)];
            array[emptyTile - (int)Math.Sqrt(level_diffculty)] = temp;

            emptyTile = emptyTile - (int)Math.Sqrt(level_diffculty);
            return array;
        }

        public int[] moveRight(int[] array, ref int emptyTile, int level_diffculty)
        {
            if ((emptyTile + 1) % (int)Math.Sqrt(level_diffculty) == 0)
                return array;

            int temp = array[emptyTile];
            array[emptyTile] = array[emptyTile + 1];
            array[emptyTile + 1] = temp;

            emptyTile = emptyTile + 1;
            return array;
        }

        public int[] moveLeft(int[] array, ref int emptyTile, int level_diffculty)
        {
            if ((emptyTile ) % (int)Math.Sqrt(level_diffculty) == 0)
                return array;

            int temp = array[emptyTile];
            array[emptyTile] = array[emptyTile - 1];
            array[emptyTile - 1] = temp;

            emptyTile = emptyTile - 1;
            return array;
        }

        public bool checkIfWin(PicturePuzzle[] array, int level_difficulty)
        {
            for (int i = 0; i < level_difficulty; i++)
                if (!array[i].matchesInitialPuzzle())
                    return false;

            return true;
        }
    }
}
