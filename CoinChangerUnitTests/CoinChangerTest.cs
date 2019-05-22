using Xunit;
using System.Collections;

namespace coinChanger
{
    public class TestClass
    {

        [Fact]
        public void oneContainsOnePenny()
        {
            Assert.Contains(1, MakeChange.calculateChange(1));
        }

        [Fact]
        public void oneReturnsOnePenny()
        {
            Assert.Equal(new int[] { 1 }, MakeChange.calculateChange(1));
        }
        
        [Fact]
        public void twoReturnsTwoPennies()
        {
            Assert.Equal(new int[] { 1, 1 }, MakeChange.calculateChange(2));
        }

        [Fact]
        public void fiveReturnsOneNickel()
        {
            Assert.Equal(new int[] { 5 }, MakeChange.calculateChange(5));
        }

        [Fact]
        public void sixReturnsOneNickelAndOnePenny()
        {
            Assert.Equal(new int[] { 5, 1 }, MakeChange.calculateChange(6));
        }

        [Fact]
        public void sevenReturnsOneNickelAndTwoPennies()
        {
            Assert.Equal(new int[] { 5, 1, 1 }, MakeChange.calculateChange(7));
        }

        [Fact]
        public void nineReturnsOneNickelAndFourPennies()
        {
            Assert.Equal(new int[] { 5, 1, 1, 1, 1 }, MakeChange.calculateChange(9));
        }

        [Fact]
        public void tenReturnsOneDime()
        {
            Assert.Equal(new int[] { 10 }, MakeChange.calculateChange(10));
        }
        
        [Fact]
        public void elevenReturnsOneDimeAndOnePenny()
        {
            Assert.Equal(new int[] { 10, 1 }, MakeChange.calculateChange(11));
        }

        [Fact]
        public void twentyfiveReturnsOneQuarter()
        {
            Assert.Equal(new int[] { 25 }, MakeChange.calculateChange(25));
        }

        [Fact]
        public void fiftyReturnsTwoQuarters()
        {
            Assert.Equal(new int[] { 25, 25 }, MakeChange.calculateChange(50));
        }

        [Fact]
        public void seventyFiveReturnsThreeQuarters()
        {
            Assert.Equal(new int[] { 25, 25, 25 }, MakeChange.calculateChange(75));
        }


        [Fact]
        public void twentyReturnsTwoDimes()
        {
            Assert.Equal(new int[] { 10, 10 }, MakeChange.calculateChange(20));
        }
        
        [Fact]
        public void ninetynineReturnsCorrectly()
        {
            Assert.Equal(new int[] { 25, 25, 25, 10, 10, 1, 1, 1, 1  }, MakeChange.calculateChange(99));
        }
    }
}