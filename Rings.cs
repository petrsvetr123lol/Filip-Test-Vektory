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
            Pen pen = new Pen(Ring1) ;
            Pen pen2 = new Pen(Ring2);
            Pen pen3 = new Pen(Ring3);
            Pen pen4 = new Pen(Ring4);
            Pen pen5 = new Pen(Ring5);


            pen.Width = Size / 50;
            pen2.Width = Size / 50;
            pen3.Width = Size / 50;
            pen4.Width = Size / 50;
            pen5.Width = Size / 50;
 
            var ringWidth = Size / 3;
            var ringHeight = Size / 3;
            graphics.DrawEllipse(pen, Location.X, Location.Y, ringWidth, ringHeight);
            graphics.DrawEllipse(pen2, Location.X + Size/2, Location.Y, ringWidth, ringHeight);
            graphics.DrawEllipse(pen3, Location.X - Size/2, Location.Y, ringWidth, ringHeight);
            graphics.DrawEllipse(pen4, Location.X, Location.Y + Size/2, ringWidth, ringHeight);
            graphics.DrawEllipse(pen5, Location.X, Location.Y - Size/2, ringWidth, ringHeight);

        }
    }
}
