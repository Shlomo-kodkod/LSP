using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    //not implemnt LSP
    //internal class Rectangle
    //{

    //    public int Width;
    //    public int Height;

    //    public Rectangle(int width, int height)
    //    {
    //        this.Width = width;
    //        this.Height = height;
    //    }

    //    public int Area()
    //    {
    //        return this.Width * this.Height;
    //    }
    //}

    //internal class Square : Rectangle
    //{
    //    public Square(int width, int height) : base(width,height)
    //    {
    //        this.Height = width;
    //    }
    //}

    //internal static class Test2
    //{
    //    public static void TestArea(Rectangle shape)
    //    {
    //        Console.WriteLine(shape.Area());
    //    }
    //}


    //implemnt LSP

    internal interface IShape
    {
        public int Area();
    }

    internal class Rectangle : IShape
    {
        private int Width;
        private int Height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Area()
        {
            return this.Width * this.Height;
        }
    }

    internal class Square : IShape
    {
        private int Length;
        public Square(int length) 
        {
            this.Length = length;
        }

        public int Area()
        {
            return this.Length * this.Length;
        }
    }

    internal static class Test2
    {
        public static void TestArea(IShape shape)
        {
            Console.WriteLine(shape.Area());
        }
    }


}


