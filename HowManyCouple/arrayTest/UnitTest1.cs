using System;
using Xunit;
using array;

namespace arrayTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] numbersTest = {2,4,6,8,10,12,14,16,18,20};
            int nTest = 6; 
            int result = Program.HowManyCouples(numbersTest,nTest);
        }
    }
}
