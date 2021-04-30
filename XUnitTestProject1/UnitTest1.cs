using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(1==1);
;        }
        [Fact]
        public void Test2()
        {
            Assert.True(1 != 3);
            
        }
        [Fact]
        public void Test3()
        {
            Assert.True(1 != 2);

        }
    }
}
