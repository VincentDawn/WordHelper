using WordHelper.Helpers;
using WordHelper.Interfaces;
using Xunit;

namespace WordHelperUnitTests
{
    public class FormalLogicWordHelperTest
    {
        [Fact]
        public void IsAnagram()
        {
            IWordHelper wordHelper = new FormalLogicWordHelper();

            Assert.True(wordHelper.IsAnagram("Tar", "Rat"));
        }

        [Fact]
        public void IsNotAnagram()
        {
            IWordHelper wordHelper = new FormalLogicWordHelper();

            Assert.False(wordHelper.IsAnagram("Star", "Rat"));
        }

        [Fact]
        public void IsPaldindrome()
        {
            IWordHelper wordHelper = new FormalLogicWordHelper();

            Assert.True(wordHelper.IsPalindrome("Anna"));
        }

        [Fact]
        public void IsNotPaldindrome()
        {
            IWordHelper wordHelper = new FormalLogicWordHelper();

            Assert.False(wordHelper.IsPalindrome("Banana"));
        }
    }
}
