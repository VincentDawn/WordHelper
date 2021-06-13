using System;
using WordHelper.Helpers;
using WordHelper.Interfaces;
using Xunit;

namespace WordHelperUnitTests
{
    public class BaseWordHelperTest
    {
        [Fact]
        public void IsAnagram()
        {
            IWordHelper wordHelper = new BaseWordHelper();

            Assert.True(wordHelper.IsAnagram("Tar", "Rat"));
        }

        [Fact]
        public void IsNotAnagram()
        {
            IWordHelper wordHelper = new BaseWordHelper();

            Assert.False(wordHelper.IsAnagram("Star", "Rat"));
        }

        [Fact]
        public void IsPaldindrome()
        {
            IWordHelper wordHelper = new BaseWordHelper();

            Assert.True(wordHelper.IsPalindrome("Anna"));
        }

        [Fact]
        public void IsNotPaldindrome()
        {
            IWordHelper wordHelper = new BaseWordHelper();

            Assert.False(wordHelper.IsPalindrome("Banana"));
        }

        [Fact]
        public void PalindromeArgumentNull()
        {
            IWordHelper wordHelper = new BaseWordHelper();

            Assert.Throws<ArgumentNullException>(() => wordHelper.IsPalindrome("Banana"));
        }
    }
}
