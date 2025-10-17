using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Lab3
{
    public partial class Form1 : Form
    {
        private bool isMouseButtonDown = false;

        private ShapePosition shapePosition = new ShapePosition();
        private Shape currentShape = null;
        private Shape[] shapes;
        private int maxShapes = 113;

        private Bitmap bitmap;

        private Dictionary<string, Shape> shapeDictionary = new Dictionary<string, Shape>();

        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            shapes = new Shape[maxShapes];
            pictureBox1.Image = bitmap;
            shapePosition.startPostion = Point.Empty;

            shapeDictionary.Add("Dot", new Dot());
            shapeDictionary.Add("Line", new Line());
            shapeDictionary.Add("Rectangle", new Rectangle());
            shapeDictionary.Add("Circle", new Circle());

            UpdateShapesCountText();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string shapeName = e.ClickedItem.Name.Split('_')[0];
            shapeDictionary.TryGetValue(shapeName, out currentShape);
            UpdateSelectedShapeText(shapeName);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, Point.Empty);
            if (isMouseButtonDown) currentShape.PreDraw(shapePosition, e.Graphics);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (GetShapesCount() < maxShapes && currentShape != null)
            {
                isMouseButtonDown = true;
                shapePosition.startPostion = ReadMousePosition();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseButtonDown && GetShapesCount() < maxShapes && currentShape != null)
            {
                shapePosition.lastPostion = ReadMousePosition();
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (GetShapesCount() < maxShapes && currentShape != null)
            {
                isMouseButtonDown = false;
                shapePosition.lastPostion = ReadMousePosition();
                Graphics graphics = Graphics.FromImage(bitmap);

                currentShape.Draw(shapePosition, graphics);
                AddShape(currentShape);
                pictureBox1.Invalidate();
            }
        }

        private Point ReadMousePosition()
        {
            Point screenPos = Cursor.Position;
            return pictureBox1.PointToClient(screenPos);
        }

        private void AddShape(Shape shape)
        {
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] == null)
                {
                    shapes[i] = shape;
                    break;
                }
            }

            UpdateShapesCountText();
        }

        private int GetShapesCount()
        {
            int shapesCount = 0;

            foreach (Shape shapeInList in shapes)
            {
                if (shapeInList != null)
                {
                    shapesCount++;
                }
                else
                {
                    break;
                }
            }

            return shapesCount;
        }

        private void UpdateShapesCountText()
        {
            label1.Text = GetShapesCount() + "/" + maxShapes;
        }

        private void UpdateSelectedShapeText(string shapeName)
        {
            label2.Text = shapeName;
        }
    }
}