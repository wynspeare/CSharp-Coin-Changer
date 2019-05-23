using Xunit;
using System.Collections;
using System.Collections.Generic;


namespace coinChanger
{
    public class TestClass
    {
        [Fact]
        public void oneReturnsOnePenny()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Equal(new int[] { 1 }, myCoinChanger.calculateChange(1));
            Assert.Equal(new Dictionary<int, int> { { 1, 1 } }, myCoinChanger.countChange());            
            Assert.Equal("1 has been converted to the following coins:\nx1 1\n", myCoinChanger.displayChange(1));
        }

        [Fact]
        public void twoReturnsTwoPennies()
        {
            MakeChange myCoinChanger = new MakeChange();
            Assert.Equal(new int[] { 1, 1 }, myCoinChanger.calculateChange(2));
            Assert.Equal(new Dictionary<int, int> { { 1, 2 } }, myCoinChanger.countChange());
            Assert.Equal("2 has been converted to the following coins:\nx2 1\n", myCoinChanger.displayChange(2));
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
            Assert.Equal(new Dictionary<int, int> { { 5, 1 }, { 1, 1 } }, myCoinChanger.countChange());
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
            Assert.Equal(new Dictionary<int, int> { { 5, 1 }, { 1, 4 } }, myCoinChanger.countChange());

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
            Assert.Equal(new Dictionary<int, int> { { 10, 2 }, { 1, 4 }, { 25, 3 } }, myCoinChanger.countChange());
            Assert.Equal("99 has been converted to the following coins:\nx3 25\nx2 10\nx4 1\n", myCoinChanger.displayChange(99));
        }
    }
}