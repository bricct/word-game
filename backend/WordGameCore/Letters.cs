namespace WordGameCore;

public static class Letters
{
    public static readonly ILetterSet Consonants = LetterSet.ToSet(
        Letter.B, Letter.C, Letter.D, Letter.F, Letter.G, Letter.H, Letter.J, 
        Letter.K, Letter.L, Letter.M, Letter.N, Letter.P, Letter.Q, Letter.R, Letter.S,
        Letter.T, Letter.V, Letter.W, Letter.X, Letter.Y, Letter.Z);
    
    public static readonly ILetterSet Vowels = LetterSet.ToSet(Letter.A, Letter.E, Letter.I, Letter.O, Letter.U);

    public static readonly ILetterSet All = LetterSet.ToSet(Consonants.Union(Vowels));
}