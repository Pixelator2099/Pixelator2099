using System.Drawing;
using System.Threading;

using System;

// External DLLS
using System.Runtime.InteropServices;
// process
using System.Diagnostics;


public class bas {


    // basic implementacion
    // Screen change fc and bc 
    static public void Screen(ConsoleColor fore, ConsoleColor back)
    {
        Console.BackgroundColor = fore;
        Console.ForegroundColor = back;

    }

    static public void ForeColor(int value)
    {
        Console.ForegroundColor = (ConsoleColor)value;
    }


    // Change console windows size
    static void ScreenSize(int width, int height)
    {
        Console.SetWindowSize(width, height);

    }

    // get Rows
    static int ScreenHeight()
    {
        return Console.WindowHeight;
    }

    // get Cols
    static int ScreenWidth()
    {
        return Console.WindowWidth;
    }

    // Windows Title
    static public void ScreenTitle(string data)
    {
        Console.Title = data;
    }

    // Clear Screen
    static public void Cls()
    {
        Console.Clear();
    }

    // Locate cursor
    static public void Locate(int x, int y)
    {
        Console.SetCursorPosition(y, x);
    }

    // Print
    static public void Print(string txt)
    {
        Console.Write(txt);
    }
    static public void Print(int txt)
    {
        Console.Write(txt);
    }

    // Wait
    static public void Wait()
    {
        Locate(ScreenHeight(), 1);
        Console.Read();
    }




}