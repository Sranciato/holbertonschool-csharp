using System;

class Character
{
    public static bool IsLower(char letter)
    {
        if (letter >= 'A' && letter <= 'Z')
            return false;
        return true;
    }
}
