using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordGameCore;

namespace WordGameCoreTests;

[TestClass]
public class LetterExtensionsTests
{
    [TestMethod]
    public void AsInt_IsCorrect()
    {
        var i = 0;
        foreach (var letter in LetterTestHelper.AllLettersOrdered)
        {
            Assert.AreEqual(1 << i++, letter.AsInt());
        }
    }

    [TestMethod]
    public void FromChar_IsCorrect()
    {
        var i = 0;
        foreach (var letter in LetterTestHelper.AllLettersOrdered)
        {
            Assert.AreEqual(letter, LetterExtensions.FromChar((char)('a' + i++)));
        }
    }
    
    [TestMethod]
    public void IsVowel_IsCorrect()
    {
        foreach (var letter in LetterTestHelper.AllVowels)
        {
            Assert.IsTrue(letter.IsVowel());
        }

        foreach (var letter in LetterTestHelper.AllConsonants)
        {
            Assert.IsFalse(letter.IsVowel());
        }
    }
    
    [TestMethod]
    public void IsConsonant_IsCorrect()
    {
        foreach (var letter in LetterTestHelper.AllConsonants)
        {
            Assert.IsTrue(letter.IsConsonant());
        }
        foreach (var letter in LetterTestHelper.AllVowels)
        {
            Assert.IsFalse(letter.IsConsonant());
        }
    }
}
