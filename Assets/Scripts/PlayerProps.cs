using System;
using System.Runtime.InteropServices;
using static CStdLib;

[StructLayout(LayoutKind.Sequential)]
[Serializable]
public struct PlayerProps
{
    public float Health;
    public float Hunger;

    public static unsafe PlayerProps* CreatePlayerProps()
    {
        PlayerProps* props = (PlayerProps*)malloc((ulong)sizeof(PlayerProps));
        // init fields
        props->Health = 1.0f;
        props->Hunger = 1.0f;
        return props;
    }
};