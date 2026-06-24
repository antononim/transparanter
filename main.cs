using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
// using Windows.WinApi32;

class HWProg {
	public static void Main() {
		MessageBox.Show("             Hello world!\n(nvm the console, idk how to disable it)", "Lilly is da best!", 0);
		int hwnd = GetForegroundWindow();
		int colorref = 0x00000000;
		byte bAlpha = 200;
		int Layered = 0x00080000;
		int nIndex = -20;
		
		SetWindowLongA(hwnd, nIndex, Layered);
		SetLayeredWindowAttributes(hwnd,colorref,bAlpha,2);
		// SetLayeredWindowAttributes(hwnd,colorref,bAlpha,1);
		Console.ReadLine();
		
		
	}
	public static bool CB(int hwnd, int lparam){
		return true;
	}
	
	[DllImport("User32.dll")]
	public static extern int SetWindowLongA( int hWnd, int nIndex, int dwNewLong);
	
	[DllImport("User32.dll")]
	// [return: MarhsalAs(UnmanagedType.Bool)]
	public static extern bool EnumWindows(Action lpEnumFunc, int lParam);
	
	[DllImport("User32.dll")]
	public static extern int GetForegroundWindow();
	
	[DllImport("User32.dll")]
	// [return: MarhsalAs(UnmanagedType.Bool)]
	public static extern void SetLayeredWindowAttributes(int hwnd, int crKey, byte bAlpha, int dwFlags);
	
	
}