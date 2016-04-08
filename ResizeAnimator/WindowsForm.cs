using System;
using System.Windows.Forms;

namespace ResizeAnimator
{
    /// <summary>
    /// Only for resizing windows forms
    /// </summary>
    public class WindowsForm
    {
        /// <summary>
        /// Resize a form by animation
        /// </summary>
        /// <param name="This">Call open form here, Mostly "this" keyword</param>
        /// <param name="Width">Width to change</param>
        /// <param name="Height">Hight to change</param>
        public static void Resize(Form This, int Width, int Height)
        {
            while (This.Width != Width || This.Height != Height)
            {
                if (This.Width != Width)
                {
                    if (This.Width > Width)
                    {
                        This.Width--;
                        Application.DoEvents();
                    }
                    else
                    {
                        This.Width++;
                        Application.DoEvents();
                    }
                }

                if (This.Height != Height)
                {
                    if (This.Height > Height)
                    {
                        This.Height--;
                        Application.DoEvents();
                    }
                    else
                    {
                        This.Height++;
                        Application.DoEvents();
                    }
                }
            }
        }
        /// <summary>
        /// Resize a form by animation
        /// </summary>
        /// <param name="This">Call open form here, Mostly "this" keyword</param>
        /// <param name="Width">Width to change</param>
        /// <param name="Height">Hight to change</param>
        /// <param name="Speed">Speed of resizing(Default 1)</param>
        public static void Resize(Form This, int Width, int Height, int Speed = 1)
        {
            while (This.Width != Width || This.Height != Height)
            {
                if (This.Width != Width)
                {
                    if (This.Width > Width)
                    {
                        This.Width = This.Width - Speed;

                        Application.DoEvents();
                    }
                    else
                    {
                        This.Width = This.Width + Speed;
                        Application.DoEvents();
                    }
                    if (Math.Abs(This.Width - Width) < Speed) { This.Width = Width; }
                }

                if (This.Height != Height)
                {
                    if (This.Height > Height)
                    {
                        This.Height = This.Height - Speed;
                        Application.DoEvents();
                    }
                    else
                    {
                        This.Height = This.Height + Speed;
                        Application.DoEvents();
                    }
                    if (Math.Abs(This.Height - Height) < Speed) { This.Height = Height; }
                }
            }
        }
    }
}
