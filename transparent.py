import ctypes

ctypes.windll.user32.MessageBoxW(0, "Select window you want to transparent and press OK", "Transparenter", 0)

hwnd = ctypes.windll.user32.GetForegroundWindow()

colorref = 0x00000000;
bAlpha = 200;
Layered = 0x00080000;
topMost = 0x00000008;
nIndex = -20;

ctypes.windll.user32.SetWindowLongA(hwnd, nIndex, Layered)
# ctypes.windll.user32.SetWindowLongA(hwnd, nIndex, topMost)
ctypes.windll.user32.SetLayeredWindowAttributes(hwnd,colorref,bAlpha,2);

