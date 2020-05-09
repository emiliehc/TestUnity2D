using System.Runtime.InteropServices;
using System.Text;

public static class CStdLib
{
    [DllImport("msvcrt.dll")]
    public static extern unsafe void* malloc(ulong size);

    [DllImport("msvcrt.dll")]
    public static extern unsafe void free(void* ptr);

    [DllImport("msvcrt.dll")]
    public static extern unsafe void* memset(void* str, int c, ulong n);

    [DllImport("msvcrt.dll")]
    public static extern ulong strlen(string s);
    
    [DllImport("msvcrt.dll")]
    public static extern ulong strlen(StringBuilder s);

    
}