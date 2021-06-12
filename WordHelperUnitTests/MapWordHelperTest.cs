using WordHelper.Helpers;
using WordHelper.Interfaces;
using Xunit;

namespace WordHelperUnitTests
{
    public class MapWordHelperTest
    {
        [Fact]
        public void IsAnagram()
        {
            IWordHelper wordHelper = new MapWordHelper();

            Assert.True(wordHelper.IsAnagram("Tar", "Rat"));
        }

        [Fact]
        public void IsNotAnagram()
        {
            IWordHelper wordHelper = new MapWordHelper();

            Assert.False(wordHelper.IsAnagram("Star", "Rat"));
        }

        [Fact]
        public void IsPaldindrome()
        {
            IWordHelper wordHelper = new MapWordHelper();

            Assert.True(wordHelper.IsPalindrome("Anna"));
        }

        [Fact]
        public void IsNotPaldindrome()
        {
            IWordHelper wordHelper = new MapWordHelper();

            Assert.False(wordHelper.IsPalindrome("Banana"));
        }
    }
}
