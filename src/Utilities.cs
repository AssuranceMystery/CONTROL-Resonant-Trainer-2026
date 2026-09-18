// Build: b31450ff7aa8fc0bfbaefa2c16f88ef4
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
