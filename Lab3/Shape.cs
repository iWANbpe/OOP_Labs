using System;
using System.Drawing;

namespace OOP_Lab3
{
    public abstract class Shape
    {
        public abstract void PreDraw(ShapePosition shapePosition, Graphics graphics);
        public abstract void Draw(ShapePosition shapePosition, Graphics graphics);
    }

    public class Dot : Shape
    {
        public override void PreDraw(ShapePosition shapePosition, Graphics graphics)
        {
            return;
        }

        public override void Draw(ShapePosition shapePosition, Graphics graphics)
        {
            graphics.FillEllipse(Brushes.Red, shapePosition.startPostion.X - 2, shapePosition.startPostion.Y - 2, 5, 5);
        }
    }

    public class Line : Shape
    {
        public override void PreDraw(ShapePosition shapePosition, Graphics graphics)
        {
            graphics.DrawLine(Pens.Red, shapePosition.startPostion.X, shapePosition.startPostion.Y, shapePosition.lastPostion.X, shapePosition.lastPostion.Y);
        }

        public override void Draw(ShapePosition shapePosition, Graphics graphics)
        {
            graphics.DrawLine(Pens.Black, shapePosition.startPostion.X, shapePosition.startPostion.Y, shapePosition.lastPostion.X, shapePosition.lastPostion.Y);
        }
    }

    public class Rectangle : Shape
    {
        public override void PreDraw(ShapePosition shapePosition, Graphics graphics)
        {
            graphics.DrawRectangle(Pens.Red, GetRectangle(shapePosition));
        }

        public override void Draw(ShapePosition shapePosition, Graphics graphics)
        {
            graphics.DrawRectangle(Pens.Black, GetRectangle(shapePosition));
        }
        private System.Drawing.Rectangle GetRectangle(ShapePosition shapePosition)
        {
            int centerX = shapePosition.startPostion.X;
            int centerY = shapePosition.startPostion.Y;

            int radiusX = Math.Abs(shapePosition.lastPostion.X - centerX);
            int radiusY = Math.Abs(shapePosition.lastPostion.Y - centerY);

            return new System.Drawing.Rectangle(centerX - radiusX, centerY - radiusY, radiusX * 2, radiusY * 2);
        }
    }

    public class Circle : Shape
    {
        public override void PreDraw(ShapePosition shapePosition, Graphics graphics)
        {
            graphics.DrawEllipse(Pens.Red, GetRectangle(shapePosition));
        }

        public override void Draw(ShapePosition shapePosition, Graphics graphics)
        {
            System.Drawing.Rectangle rect = GetRectangle(shapePosition);
            graphics.FillEllipse(new SolidBrush(Color.Yellow), rect);
            graphics.DrawEllipse(Pens.Black, rect);
        }

        private System.Drawing.Rectangle GetRectangle(ShapePosition shapePosition)
        {
            int x = Math.Min(shapePosition.startPostion.X, shapePosition.lastPostion.X);
            int y = Math.Min(shapePosition.startPostion.Y, shapePosition.lastPostion.Y);
            int width = Math.Abs(shapePosition.startPostion.X - shapePosition.lastPostion.X);
            int height = Math.Abs(shapePosition.startPostion.Y - shapePosition.lastPostion.Y);

            return new System.Drawing.Rectangle(x, y, width, height);
        }
    }
}