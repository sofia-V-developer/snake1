using System;
using System.Collections.Generic;
using System.Linq;
class Game
{
    static readonly int x = 80;
    static readonly int y = 26;


    static void Main()
    {
        Console.SetWindowSize(x + 1, y + 1);
        Console.SetBufferSize(x + 1, y + 1);
        Console.CursorVisible = false;
    } struct Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public char ch { get; set; }

        public static implicit operator Point((int, int, char) value) =>

            new Point { x = value.Item1, y = value.Item2, ch = value.Item3 };
        public void Draw()
        {
            DrawPoint(ch);
        }
        public void Clear()
        {
            DrawPoint(' ');
        }
        private void DrawPoint(char ch)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(ch);
        }





} }    



   
        
        

        
    

