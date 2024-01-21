using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordGameCore;

namespace WordGameCoreTests;

[TestClass]
public class LetterSetTests
{
    [TestMethod]
    public void Empty_IsEmpty()
    {
        var empty = LetterSet.Empty;
        Assert.AreEqual(0, empty.Count);
        foreach (var letter in LetterTestHelper.AllLettersOrdered)
        {
            Assert.IsFalse(empty.Contains(letter));
        }
    }
    
    [TestMethod]
    public void FromString_IsCorrect()
    {
        var set = LetterSet.FromString("abcdefghijklmnopqrstuvwxyz");
        Assert.AreEqual(26, set.Count);
        foreach (var letter in LetterTestHelper.AllLettersOrdered)
        {
            Assert.IsTrue(set.Contains(letter));
        }
        set = LetterSet.FromString("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        Assert.AreEqual(26, set.Count);
        foreach (var letter in LetterTestHelper.AllLettersOrdered)
        {
            Assert.IsTrue(set.Contains(letter));
        }

        set = LetterSet.FromString("AeIoU");
        Assert.AreEqual(5, set.Count);
        foreach (var letter in LetterTestHelper.AllVowels)
        {
            Assert.IsTrue(set.Contains(letter));
        }
        
        set = LetterSet.FromString("BcDfGhJkLmNpQrStVwXyZ");
        Assert.AreEqual(21, set.Count);
        foreach (var letter in LetterTestHelper.AllConsonants)
        {
            Assert.IsTrue(set.Contains(letter));
        }

        set = LetterSet.FromString("aaaaaaaeeeeeeee");
        Assert.AreEqual(2, set.Count);
        Assert.IsTrue(set.Contains(Letter.A));
        Assert.IsTrue(set.Contains(Letter.E));
    }
    
    [TestMethod]
    public void ToSet_IsCorrect()
    {
        var set = LetterSet.ToSet(Letter.A, Letter.E, Letter.I, Letter.O, Letter.U);
        Assert.AreEqual(5, set.Count);
        foreach (var letter in LetterTestHelper.AllVowels)
        {
            Assert.IsTrue(set.Contains(letter));
        }
        
        set = LetterSet.ToSet(Letter.B, Letter.C, Letter.D, Letter.F, Letter.G, Letter.H, Letter.J,
            Letter.K, Letter.L, Letter.M, Letter.N, Letter.P, Letter.Q, Letter.R,
            Letter.S, Letter.T, Letter.V, Letter.W, Letter.X, Letter.Y, Letter.Z);
        Assert.AreEqual(21, set.Count);
        foreach (var letter in LetterTestHelper.AllConsonants)
        {
            Assert.IsTrue(set.Contains(letter));
        }
    }
    
    [TestMethod]
    public void IsSubsetOf_IsCorrect()
    {
        var set = LetterSet.ToSet(Letter.A, Letter.E, Letter.I, Letter.O, Letter.U);
        Assert.IsTrue(set.IsSubsetOf(Letters.All));
        Assert.IsTrue(set.IsSubsetOf(Letters.Vowels));
        Assert.IsFalse(set.IsSubsetOf(Letters.Consonants));
        
        set = LetterSet.ToSet(Letter.B, Letter.C, Letter.D, Letter.F, Letter.G, Letter.H, Letter.J,
            Letter.K, Letter.L, Letter.M, Letter.N, Letter.P, Letter.Q, Letter.R,
            Letter.S, Letter.T, Letter.V, Letter.W, Letter.X, Letter.Y, Letter.Z);
        Assert.IsTrue(set.IsSubsetOf(Letters.All));
        Assert.IsTrue(set.IsSubsetOf(Letters.Consonants));
        Assert.IsFalse(set.IsSubsetOf(Letters.Vowels));
    }
    
    [TestMethod]
    public void IsSuperSetOf_IsCorrect()
    {
        var set = LetterSet.ToSet(Letter.A, Letter.E, Letter.I, Letter.O, Letter.U);
        Assert.IsTrue(Letters.All.IsSupersetOf(set));
        Assert.IsTrue(Letters.Vowels.IsSupersetOf(set));
        Assert.IsFalse(Letters.Consonants.IsSupersetOf(set));
        
        set = LetterSet.ToSet(Letter.B, Letter.C, Letter.D, Letter.F, Letter.G, Letter.H, Letter.J,
            Letter.K, Letter.L, Letter.M, Letter.N, Letter.P, Letter.Q, Letter.R,
            Letter.S, Letter.T, Letter.V, Letter.W, Letter.X, Letter.Y, Letter.Z);
        Assert.IsTrue(Letters.All.IsSupersetOf(set));
        Assert.IsTrue(Letters.Consonants.IsSupersetOf(set));
        Assert.IsFalse(Letters.Vowels.IsSupersetOf(set));
    }
}