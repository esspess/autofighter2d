using System;
public static class IntExtension
{
    public static void Times(this int self, Action<int> action)
    {
        for (int i = 0; i < self; ++i)
        {
            action(i);
        }
    }
}