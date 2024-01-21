using System;
namespace WordGameCore;

public enum Letter
{
    A = 1 << 0,
    B = 1 << 1,
    C = 1 << 2,
    D = 1 << 3,
    E = 1 << 4,
    F = 1 << 5,
    G = 1 << 6,
    H = 1 << 7,
    I = 1 << 8,
    J = 1 << 9,
    K = 1 << 10,
    L = 1 << 11,
    M = 1 << 12,
    N = 1 << 13,
    O = 1 << 14,
    P = 1 << 15,
    Q = 1 << 16,
    R = 1 << 17,
    S = 1 << 18,
    T = 1 << 19,
    U = 1 << 20,
    V = 1 << 21,
    W = 1 << 22,
    X = 1 << 23,
    Y = 1 << 24,
    Z = 1 << 25
}

public static class LetterExtensions
{
    public static int AsInt(this Letter letter)
    {
        return (int)letter;
    }
    
    public static Letter FromChar(char letter) => 
        letter switch
        {
            'a' => Letter.A,
            'b' => Letter.B,
            'c' => Letter.C,
            'd' => Letter.D,
            'e' => Letter.E,
            'f' => Letter.F,
            'g' => Letter.G,
            'h' => Letter.H,
            'i' => Letter.I,
            'j' => Letter.J,
            'k' => Letter.K,
            'l' => Letter.L,
            'm' => Letter.M,
            'n' => Letter.N,
            'o' => Letter.O,
            'p' => Letter.P,
            'q' => Letter.Q,
            'r' => Letter.R,
            's' => Letter.S,
            't' => Letter.T,
            'u' => Letter.U,
            'v' => Letter.V,
            'w' => Letter.W,
            'x' => Letter.X,
            'y' => Letter.Y,
            'z' => Letter.Z,
            _ => throw new ArgumentOutOfRangeException(nameof(letter), letter, $"Cannot convert {letter} to Letter")
        };
    
    public static bool IsVowel(this Letter letter)
    {
        return Letters.Vowels.Contains(letter);
    }
    
    public static bool IsConsonant(this Letter letter)
    {
        return Letters.Consonants.Contains(letter);
    }
}