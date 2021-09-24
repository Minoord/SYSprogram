using System;

namespace SYSLes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rechthoek = new Rectangle(100, 100, 50, 50);
            Rectangle vierkant = new Rectangle(50, 50, 50);
            Rectangle vierkantBeweeg = new Rectangle(50);
            Rectangle rechthoekBeweeg = new Rectangle(20, 30);

            vierkantBeweeg.MoveTo(50, 50);
            rechthoekBeweeg.MoveTo(100, 100);

            Console.WriteLine("Hello World!");
        }
    }

    class Rectangle
    {
        private float width;
        private float height;
        private float x;
        private float y;

        public Rectangle(float width, float height, float x , float y)
        {
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }
         public Rectangle( float x, float y , float size)
        {
            this.x = x;
            this.y = y;
            this.width = size;
            this.height = size;
        }

        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(float size)
        {
            this.width = size;
            this.height = size;
        }

        public void MoveTo(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public bool IsSquare()
        {
            bool rectangleIsVierkant;

            if ( this.x == this.y)
            {
               rectangleIsVierkant = true;
            }
            else
            {
                rectangleIsVierkant = false;
            }

            return rectangleIsVierkant;
        }
        public void Set(float x, float y, float width , float height)
        {

        }
    }
}
