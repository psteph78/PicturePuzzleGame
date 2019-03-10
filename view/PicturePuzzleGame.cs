using Lab7_PicturePuzzle.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7_PicturePuzzle
{
    public partial class PicturePuzzleGame : Form
    {
        private PuzzleController puzzleController = new PuzzleController();
        private int emptyTile = 0;
        private PuzzleService puzzleService = new PuzzleService();

        private OpenFileDialog imageSearch = null;
        private Image image;
        private PictureBox initialPicture = null;

        private PicturePuzzle[] puzzleImages = null;
        private Bitmap[] images = null;
        private int[] indices = null;
        private const int low_difficulty = 4;
        private const int medium_difficulty = 16;
        private const int high_difficulty = 25;

        private int current_difficulty = 0;

        public PicturePuzzleGame()
        {
            InitializeComponent();
        }

        //method initializes picture for the puzzle and sets it on the picture groupBox
        private void chooseImageButton(object sender, EventArgs e)
        {
            if (imageSearch == null)
                imageSearch = new OpenFileDialog();
            if (imageSearch.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = CreateBitmapImage(Image.FromFile(imageSearch.FileName));
                groupBoxPuzzle.Controls.Clear();
                initialPicture = new PictureBox();
                initialPicture.Height = groupBoxPuzzle.Height;
                initialPicture.Width = groupBoxPuzzle.Width;
                groupBoxPuzzle.Controls.Add(initialPicture);
                initialPicture.Image = image;
            }
        }
        //method creates a bitmap of an image passed as parameter
        private Bitmap CreateBitmapImage(Image image)
        {
            Bitmap bitmappedImage = new Bitmap(groupBoxPuzzle.Width, groupBoxPuzzle.Height);
            Graphics imageGraphics = Graphics.FromImage(bitmappedImage);
            imageGraphics.DrawImage(image, new Rectangle(0, 0, groupBoxPuzzle.Width, groupBoxPuzzle.Height));
            imageGraphics.Flush();

            return bitmappedImage;
        }

        //method creates a puzzle-piece from the initial picture
        private void CreateBitmapImage(Image image, Bitmap[] images, int index, int row, int col, int width, int height)
        {
            images[index] = new Bitmap(width, height);

            Graphics imgGraphics = Graphics.FromImage(images[index]);

            imgGraphics.DrawImage(image, new Rectangle(0, 0, width, height),
            new Rectangle(width * (index % col), height * (index / col), width, height),
                GraphicsUnit.Pixel);
            imgGraphics.Flush();

            //sets the first puzzle-piece to grey(emptyTile)
            if (index == 0)
            {
                for (int x = 0; x < images[index].Width; x++)
                {
                    for (int y = 0; y < images[index].Height; y++)
                    {
                        images[index].SetPixel(x, y, Color.Silver);
                    }
                }
            }
        }
        
        //method initializes the game based on the difficulty by creating all the puzzle pieces
        private void SetDifficultyPuzzle(int current_diffculty)
        {
            if (initialPicture != null)
            {
                groupBoxPuzzle.Controls.Remove(initialPicture);
            }
            if (puzzleImages == null)
            {
                images = new Bitmap[current_diffculty];
                puzzleImages = new PicturePuzzle[current_diffculty];
            }
            images = new Bitmap[current_diffculty];
            int rows = (int)Math.Sqrt(current_diffculty);
            int cols = (int)Math.Sqrt(current_diffculty);
            int width = groupBoxPuzzle.Width / rows;
            int height = groupBoxPuzzle.Height / cols;
            indices = new int[current_diffculty];
            for (int i = 0; i < current_diffculty; i++)
            {
                indices[i] = i;
                if (puzzleImages[i] == null)
                {
                    puzzleImages[i] = new PicturePuzzle();
                    puzzleImages[i].BorderStyle = BorderStyle.Fixed3D;

                }
                puzzleImages[i].Width = width;
                puzzleImages[i].Height = height;

                ((PicturePuzzle)puzzleImages[i]).setIndex(i);

                CreateBitmapImage(image, images, i, rows, cols, width, height);

                puzzleImages[i].Location = new Point(width * (i % cols), height * (i / cols));
                if (!groupBoxPuzzle.Controls.Contains(puzzleImages[i]))
                    groupBoxPuzzle.Controls.Add(puzzleImages[i]);
            }

            indices = puzzleService.shufflePuzzleImages(indices, current_diffculty, ref emptyTile);

            for (int i = 0; i < current_diffculty; i++)
            {
                puzzleImages[i].Image = images[indices[i]];
                ((PicturePuzzle)puzzleImages[i]).setImageIndex(indices[i]);
            }
            
           
        }
        private void lowDifficultyButton(object sender, EventArgs e)
        {
            clearPuzzle();
            reinitializeValues();
            current_difficulty = low_difficulty;
            SetDifficultyPuzzle(current_difficulty);
        }

        private void mediumDifficultyButton(object sender, EventArgs e)
        {
            clearPuzzle();
            reinitializeValues();
            current_difficulty = medium_difficulty;
            SetDifficultyPuzzle(current_difficulty);
        }

        private void highDifficultyButton(object sender, EventArgs e)
        {
            clearPuzzle();
            reinitializeValues();
            current_difficulty = high_difficulty;
            SetDifficultyPuzzle(current_difficulty);
        }

        private void userChoiceDifficulty(object sender, EventArgs e)
        {
            string nr = nrOfPieces.Text;
            int nrOfPuzzlePieces = Int32.Parse(nr);

            if (Math.Sqrt(nrOfPuzzlePieces) % 1 == 0)
            {
                clearPuzzle();
                reinitializeValues();
                current_difficulty = nrOfPuzzlePieces;
                SetDifficultyPuzzle(current_difficulty);
            }
        }

        private void moveLeft(object sender, EventArgs e)
        {
            indices = puzzleController.moveLeft(indices, ref emptyTile, current_difficulty);
            changePuzzlePieces();
            checkIfWin();
        }

        private void moveUp(object sender, EventArgs e)
        {
            indices = puzzleController.moveUp(indices, ref emptyTile, current_difficulty);
            changePuzzlePieces();
            checkIfWin();
        }

        private void MoveDown(object sender, EventArgs e)
        {
            indices = puzzleController.moveDown(indices, ref emptyTile, current_difficulty);
            changePuzzlePieces();
            checkIfWin();
        }

        private void moveRight(object sender, EventArgs e)
        {
            indices = puzzleController.moveRight(indices, ref emptyTile, current_difficulty);
            changePuzzlePieces();
            checkIfWin();
        }

        //method is called after every move to re-draw the puzzle pieces on the board
        private void changePuzzlePieces()
        {
            for (int i = 0; i < current_difficulty; i++)
            {
                puzzleImages[i].Image = images[indices[i]];
                ((PicturePuzzle)puzzleImages[i]).setImageIndex(indices[i]);
            }
        }

        private void checkIfWin()
        {
            bool win = puzzleController.checkIfWin(puzzleImages, current_difficulty);
            if (win)
            {
                for (int i = 0; i < current_difficulty; i++)
                    groupBoxPuzzle.Controls.Remove(puzzleImages[i]);
                groupBoxPuzzle.Controls.Add(initialPicture);
            }
        }

        private void reinitializeValues()
        {
            emptyTile = 0;
            puzzleImages = null;
            images = null;
            indices = null;
        }

        //method clears the board of all puzzle pieces
        private void clearPuzzle()
        {
            for (int i = 0; i < current_difficulty; i++)
                groupBoxPuzzle.Controls.Remove(puzzleImages[i]);
        }
    }
}
