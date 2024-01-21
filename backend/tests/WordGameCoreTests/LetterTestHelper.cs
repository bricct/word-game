using WordGameCore;

namespace WordGameCoreTests;

public class LetterTestHelper
{
    
    public static IEnumerable<Letter> AllLettersOrdered = new[]
    {
        Letter.A, Letter.B, Letter.C, Letter.D, Letter.E, Letter.F, Letter.G,
        Letter.H, Letter.I, Letter.J, Letter.K, Letter.L, Letter.M, Letter.N,
        Letter.O, Letter.P, Letter.Q, Letter.R, Letter.S, Letter.T, Letter.U,
        Letter.V, Letter.W, Letter.X, Letter.Y, Letter.Z
    };
    
    public static IEnumerable<Letter> AllVowels = new[]
    {
        Letter.A, Letter.E, Letter.I, Letter.O, Letter.U
    };

    public static IEnumerable<Letter> AllConsonants = new[]
    {
        Letter.B, Letter.C, Letter.D, Letter.F, Letter.G, Letter.H, Letter.J,
        Letter.K, Letter.L, Letter.M, Letter.N, Letter.P, Letter.Q, Letter.R,
        Letter.S, Letter.T, Letter.V, Letter.W, Letter.X, Letter.Y, Letter.Z
    };
}