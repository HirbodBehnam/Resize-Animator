using System;

namespace ResizeAnimator
{
    public class ConsoleApplication
    {
        /// <summary>
        /// Resize buffer size of a console application
        /// </summary>
        /// <param name="Width">Width to change</param>
        /// <param name="Height">Hight to change</param>
        public static void BufferResize(int Width, int Height)
        { 
            while (Console.BufferWidth != Width || Console.BufferHeight != Height)
            {
                if (Console.BufferWidth != Width)
                {
                    if (Console.BufferWidth > Width)
                    {
                        Console.BufferWidth--;
                    }
                    else
                    {
                        Console.BufferWidth++;
                    }
                }
                if (Console.BufferHeight != Height)
                {
                    if (Console.BufferHeight > Height)
                    {
                        Console.BufferHeight--;
                    }
                    else
                    {
                        Console.BufferHeight++;
                    }
                }
            }
        }

        /// <summary>
        /// Resize buffer size of a console application
        /// </summary>
        /// <param name="Width">Width to change</param>
        /// <param name="Height">Hight to change</param>
        /// <param name="Speed">Speed of resizing(Default 1)</param>
        public static void BufferResize(int Width, int Height, int Speed = 1)
        {
            while (Console.BufferWidth != Width || Console.BufferHeight != Height)
            {
                if (Console.BufferWidth != Width)
                {
                    if (Console.BufferWidth > Width)
                    {
                        Console.BufferWidth = Console.BufferWidth - Speed;
                    }
                    else
                    {
                        Console.BufferWidth = Console.BufferWidth + Speed;
                    }
                    if (Math.Abs(Console.BufferWidth - Width) < Speed) { Console.BufferWidth = Width; }
                }

                if (Console.BufferHeight != Height)
                {
                    if (Console.BufferHeight > Height)
                    {
                        Console.BufferHeight = Console.BufferHeight - Speed;
                    }
                    else
                    {
                        Console.BufferHeight = Console.BufferHeight + Speed;
                    }
                    if (Math.Abs(Console.BufferHeight - Height) < Speed) { Console.BufferHeight = Height; }
                }
            }
        }

        /// <summary>
        /// Resize window size of a console application
        /// </summary>
        /// <param name="Width">Width to change</param>
        /// <param name="Height">Hight to change</param>
        public static void WindowResizer(int Width, int Height)
        {
            while (Console.WindowWidth != Width || Console.WindowHeight != Height)
            {
                if (Console.WindowWidth != Width)
                {
                    if (Console.WindowWidth > Width)
                    {
                        Console.WindowWidth--;
                    }
                    else
                    {
                        Console.WindowWidth++;
                    }
                }
                if (Console.WindowHeight != Height)
                {
                    if (Console.WindowHeight > Height)
                    {
                        Console.WindowHeight--;
                    }
                    else
                    {
                        Console.WindowHeight++;
                    }
                }
            }
        }
        /// <summary>
        /// Resize window size of a console application
        /// </summary>
        /// <param name="Width">Width to change</param>
        /// <param name="Height">Hight to change</param>
        /// <param name="Speed">Speed of resizing(Default 1)</param>
        public static void WindowResizer(int Width, int Height,int Speed)
        {
            while (Console.WindowWidth != Width || Console.WindowHeight != Height)
            {
                if (Console.WindowWidth != Width)
                {
                    if (Console.WindowWidth > Width)
                    {
                        Console.WindowWidth = Console.WindowWidth - Speed;
                    }
                    else
                    {
                        Console.WindowWidth = Console.WindowWidth + Speed;
                    }
                    if (Math.Abs(Console.WindowWidth - Width) < Speed) { Console.WindowWidth = Width; }
                }

                if (Console.WindowHeight != Height)
                {
                    if (Console.WindowHeight > Height)
                    {
                        Console.WindowHeight = Console.WindowHeight - Speed;
                    }
                    else
                    {
                        Console.WindowHeight = Console.WindowHeight + Speed;
                    }
                    if (Math.Abs(Console.WindowHeight - Height) < Speed) { Console.WindowHeight = Height; }
                }
            }
        }
    }
}
