using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordGameCore;

namespace WordGameCoreTests;

[TestClass]
public class LettersTests
{
    
    [TestMethod]
    public void Vowels_ContainsAllVowels()
    {
        Assert.IsTrue(Letters.Vowels.Contains(Letter.A));
        Assert.IsTrue(Letters.Vowels.Contains(Letter.E));
        Assert.IsTrue(Letters.Vowels.Contains(Letter.I));
        Assert.IsTrue(Letters.Vowels.Contains(Letter.O));
        Assert.IsTrue(Letters.Vowels.Contains(Letter.U));
    }

    [TestMethod]
    public void Consonants_ContainAllConsonants()
    {
        Assert.IsTrue(Letters.Consonants.Contains(Letter.B));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.C));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.D));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.F));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.G));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.H));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.J));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.K));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.L));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.M));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.N));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.P));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.Q));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.R));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.S));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.T));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.V));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.W));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.X));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.Y));
        Assert.IsTrue(Letters.Consonants.Contains(Letter.Z));
    }
}