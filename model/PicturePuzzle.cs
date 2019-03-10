using System.Windows.Forms;

namespace Lab7_PicturePuzzle
{

    //class uses two indexes to check when the current puzzle
    //matches the initial puzzle -> solution to puzzle found
    class PicturePuzzle:PictureBox
    {
        int index = 0;
        int imageIndex = 0;

        public int getIndex() { return index; }

        public void setIndex(int value) { index = value; }
        
        public int getImageIndex() { return imageIndex; }
        public void setImageIndex(int value) { imageIndex = value; }

        public bool matchesInitialPuzzle()
        {
            return (index == imageIndex);
        }
    }
}
