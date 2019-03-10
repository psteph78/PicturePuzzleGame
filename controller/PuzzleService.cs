using System;

namespace Lab7_PicturePuzzle
{
    //class shuffles an array randomly so that the outcome can lead to a solution
    class PuzzleService
    {

        public int[] shufflePuzzleImages(int[] array, int difficulty_level, ref int emptyTile)
        {
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n);
                n--;
                int temp = array[n];
                array[n] = array[k];
                array[k] = temp;
                if (k == emptyTile)
                {
                    emptyTile = n;
                }
            }

            if (!isSolvable(difficulty_level, emptyTile))
            {
                if (emptyTile >= 0 && emptyTile <= difficulty_level - 1)
                {
                    int temp = array[difficulty_level-1];
                    array[difficulty_level - 1] = array[difficulty_level - 2];
                    array[difficulty_level - 2] = temp;
                }
                else
                {
                    int temp = array[0];
                    array[0] = array[1];
                    array[1] = temp;
                }
            }
      
            return array;
        }

        private int countInversion(int i, int level_difficulty)
        {
            int X = i % (int)Math.Sqrt(level_difficulty);
            int Y = i / (int)Math.Sqrt(level_difficulty);

            int inversions = 0;
            int tileNum = Y * level_difficulty + X;
            int lastTile = level_difficulty;
            int tileValue = i;

            for (int q = tileNum + 1; q < lastTile; q++)
            {
                int k = q % level_difficulty;
                int l = q / level_difficulty;

                int compValue = k + l;
                if (tileValue > compValue && tileValue != (lastTile - 1))
                {
                    inversions++;
                }
            }
            return inversions;
        }

        private int sumInversions(int level_diffculty)
        {
            int inversions = 0;
            for (int i = 0; i < level_diffculty; i++)
            {
                inversions += countInversion(i, level_diffculty);
            }

            return inversions;
        }

        private bool isSolvable(int level_difficulty, int emptyTile)
        {
            if (level_difficulty % 2 == 1)
            {
                return (sumInversions(level_difficulty) % 2 == 0);
            }
            else
            {
                return ((sumInversions(level_difficulty) + level_difficulty - emptyTile) % 2 == 0);
            }
        }
    }
}
