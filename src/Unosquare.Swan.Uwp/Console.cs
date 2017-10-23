#if WINDOWS_UWP
using System.Text;

namespace System
{
    class Console
    {
        public static ConsoleColor BackgroundColor { get; set; }
        public static int BufferHeight { get; set; }
        public static int CursorLeft { get; set; }
        public static int CursorTop { get; set; }
        public static bool CursorVisible { get; set; }
        public static IO.TextWriter Error { get; set; }
        public static ConsoleColor ForegroundColor { get; set; }
        public static IO.TextWriter Out { get; set; }
        public static Encoding OutputEncoding { get => Encoding.UTF8; set { } }
        public static int WindowHeight { get; set; }

        public static void ResetColor()
        {
            // Do nothing.
        }

        public static void SetCursorPosition(int left, int top)
        {
            // Do nothing.
        }
    }
}
#endif
