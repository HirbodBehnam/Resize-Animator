using System;
using System.Windows;

namespace ResizeAnimator
{
    /// <summary>
    /// Only for resizing WPF application
    /// </summary>
    public class WPFApplication
    {
        /// <summary>
        /// Resize form with animation (Resize very slowly)
        /// </summary>
        /// <param name="This">Call open form here, Mostly "this" keyword</param>
        /// <param name="Width">Width to change</param>
        /// <param name="Height">Hight to change</param>
        public static void Resize(FrameworkElement This, double Width, double Height)
        {
            while (This.Width != Width || This.Height != Height)
            {
                if (This.Width != Width)
                {
                    if (This.Width > Width)
                    {
                        This.Width--;
                    }
                    else
                    {
                        This.Width++;
                    }
                }

                if (This.Height != Height)
                {
                    if (This.Height > Height)
                    {
                        This.Height--;
                    }
                    else
                    {
                        This.Height++;
                    }
                }
            }
        }
        /// <summary>
        /// Resize form with animation
        /// </summary>
        /// <param name="This">Call open form here, Mostly "this" keyword</param>
        /// <param name="Width">Width to change</param>
        /// <param name="Height">Hight to change</param>
        /// <param name="Speed">Speed of resizing(Default 1)</param>
        public static void Resize(FrameworkElement This, double Width, double Height, float Speed = 1f)
        {
            while (This.Width != Width || This.Height != Height)
            {
                if (This.Width != Width)
                {
                    if (This.Width > Width)
                    {
                        This.Width = This.Width - Speed;
                    }
                    else
                    {
                        This.Width = This.Width + Speed;
                    }
                    if (Math.Abs(This.Width - Width) < Speed) { This.Width = Width; }
                }

                if (This.Height != Height)
                {
                    if (This.Height > Height)
                    {
                        This.Height = This.Height - Speed;
                    }
                    else
                    {
                        This.Height = This.Height + Speed;
                    }
                    if (Math.Abs(This.Height - Height) < Speed) { This.Height = Height; }
                }
            }
        }
    }
}
