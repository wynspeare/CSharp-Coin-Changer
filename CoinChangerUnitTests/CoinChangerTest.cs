using Xunit;
using System.Collections;

namespace coinChanger
{
    public class TestClass
    {

        [Fact]
        public void oneContainsOnePenny()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Contains(1, myCoinChanger.calculateChange(1));
        }

        [Fact]
        public void oneReturnsOnePenny()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Equal(new int[] { 1 }, myCoinChanger.calculateChange(1));
        }
        
        [Fact]
        public void twoReturnsTwoPennies()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Equal(new int[] { 1, 1 }, myCoinChanger.calculateChange(2));
        }

        [Fact]
        public void fiveReturnsOneNickel()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Equal(new int[] { 5 }, myCoinChanger.calculateChange(5));
        }

        [Fact]
        public void sixReturnsOneNickelAndOnePenny()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Equal(new int[] { 5, 1 }, myCoinChanger.calculateChange(6));
        }

        [Fact]
        public void sevenReturnsOneNickelAndTwoPennies()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Equal(new int[] { 5, 1, 1 }, myCoinChanger.calculateChange(7));
        }

        [Fact]
        public void nineReturnsOneNickelAndFourPennies()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Equal(new int[] { 5, 1, 1, 1, 1 }, myCoinChanger.calculateChange(9));
        }

        [Fact]
        public void tenReturnsOneDime()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Equal(new int[] { 10 }, myCoinChanger.calculateChange(10));
        }
        
        [Fact]
        public void elevenReturnsOneDimeAndOnePenny()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Equal(new int[] { 10, 1 }, myCoinChanger.calculateChange(11));
        }

        [Fact]
        public void twentyfiveReturnsOneQuarter()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Equal(new int[] { 25 }, myCoinChanger.calculateChange(25));
        }

        [Fact]
        public void fiftyReturnsTwoQuarters()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Equal(new int[] { 25, 25 }, myCoinChanger.calculateChange(50));
        }

        [Fact]
        public void seventyFiveReturnsThreeQuarters()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Equal(new int[] { 25, 25, 25 }, myCoinChanger.calculateChange(75));
        }

        [Fact]
        public void twentyReturnsTwoDimes()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Equal(new int[] { 10, 10 }, myCoinChanger.calculateChange(20));
        }
        
        [Fact]
        public void ninetynineReturnsCorrectly()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Equal(new int[] { 25, 25, 25, 10, 10, 1, 1, 1, 1  }, myCoinChanger.calculateChange(99));
        }
    }
}