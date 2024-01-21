using System.Collections;

namespace WordGameCore;

public interface ILetterSet: IReadOnlySet<Letter>;

public readonly struct LetterSet(int letterSetFlag): ILetterSet
{
    private int AsInt() => letterSetFlag;
    
    #region Factory Methods
    public static LetterSet Empty => new (0);
    public static LetterSet ToSet(params Letter[] letters) =>
        new (letters.Aggregate(0, (current, letter) => current | letter.AsInt()));
    public static LetterSet ToSet(IEnumerable<Letter> letters) =>
        new (letters.Aggregate(0, (current, letter) => current | letter.AsInt()));  
    
    public static LetterSet FromString(string letters)
    {
        var letterArr = letters.ToLower().Select(LetterExtensions.FromChar);
        return ToSet(letterArr);
    }
    #endregion
    
    #region Fast Impls
    
    public bool Contains(Letter letter)
    {
        return (letterSetFlag & letter.AsInt()) != 0;
    }
    
    private bool IsProperSubsetOf(LetterSet other)
    {
        return IsSubsetOf(other) && letterSetFlag != other.AsInt();
    }
    
    private bool IsProperSupersetOf(LetterSet other)
    {
        return IsSupersetOf(other) && letterSetFlag != other.AsInt();
    }
    
    private bool IsSubsetOf(LetterSet other)
    {
        return (letterSetFlag & other.AsInt()) == letterSetFlag;
    }
    
    private bool IsSupersetOf(LetterSet other)
    {
        return (letterSetFlag | other.AsInt()) == letterSetFlag;
    }
    
    private bool Overlaps(LetterSet other)
    {
        return (letterSetFlag & other.AsInt()) != 0;
    }
    
    private bool Equals(LetterSet other)
    {
        return letterSetFlag == other.AsInt();
    }
    
    #endregion
    
    #region IReadOnlySet<Letter>
    
    
    public bool IsProperSubsetOf(IEnumerable<Letter> other)
    {
        if (other is LetterSet otherSet)
        {
            return IsProperSubsetOf(otherSet);
        }
        return ToReadOnlySet().IsProperSubsetOf(other);
    }

    public bool IsProperSupersetOf(IEnumerable<Letter> other)
    {
        if (other is LetterSet otherSet)
        {
            return IsProperSupersetOf(otherSet);
        }
        return ToReadOnlySet().IsProperSupersetOf(other);
    }
    
    public bool IsSubsetOf(IEnumerable<Letter> other)
    {
        if (other is LetterSet otherSet)
        {
            return IsSubsetOf(otherSet);
        }
        return ToReadOnlySet().IsSubsetOf(other);
    }
    
    public bool IsSupersetOf(IEnumerable<Letter> other)
    {
        if (other is LetterSet otherSet)
        {
            return IsSupersetOf(otherSet);
        }
        return ToReadOnlySet().IsSupersetOf(other);
    }

    public bool Overlaps(IEnumerable<Letter> other)
    {
        if (other is LetterSet otherSet)
        {
            return Overlaps(otherSet);
        }
        return ToReadOnlySet().Overlaps(other);
    }
    
    public bool SetEquals(IEnumerable<Letter> other)
    {
        if (other is LetterSet otherSet)
        {
            return Equals(otherSet);
        }
        return ToReadOnlySet().SetEquals(other);
    }

    public bool Equals(ILetterSet other)
    {
        if (other is LetterSet otherSet)
        {
            return Equals(otherSet);
        }
        return ToReadOnlySet().Equals(other);
    }
    
    private IReadOnlySet<Letter> ToReadOnlySet() => new HashSet<Letter>(this);

    public IEnumerator<Letter> GetEnumerator()
    {
        for (var power = 0; power < 26; power++)
        {
            var letter = (Letter)(1 << power);
            if (Contains(letter))
            {
                yield return letter;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count
    {
        get
        {
            var count = 0;
            for (var power = 0; power < 26; power++)
            {
                var letter = (Letter)(1 << power);
                if (Contains(letter))
                {
                    count++;
                }
            }
            return count;
        }
    }

    #endregion
    
}