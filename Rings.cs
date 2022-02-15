using System.Drawing;

namespace filip_test
{
    public class Rings
    {
        public Point Location { get; set; }
        public int Size { get; set; }
        public Color Ring1 { get; set; }
        public Color Ring2 { get; set; }
        public Color Ring3 { get; set; }
        public Color Ring4 { get; set; }
        public Color Ring5 { get; set; }

        public Rings()
        {
            Location = new Point();
            Size = 100;
            Ring1 = Color.Red;
            Ring2 = Color.Green;
            Ring3 = Color.Blue;
            Ring4 = Color.Black;
            Ring5 = Color.Violet;
        }
        public void Draw (Graphics graphics)
        {
            Pen pen = new Pen(Color.Black);
            pen.Width = Size / 50;
            Brush ringBrush = new SolidBrush(Ring1); ;
            var ringWidth = Size / 3;
            var ringHeight = (3 * ringWidth) / 4;
            //zkouška vypsani obdelniku
            graphics.DrawEllipse(pen, Location.X, Location.Y, ringWidth, ringHeight);

        }
    }
}
