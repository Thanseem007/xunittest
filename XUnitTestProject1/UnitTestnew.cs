using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTestnew
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1 , 1);
        }
        [Fact]
        public void Test2()
        {
            Assert.IsType<int>(1);
        }
    }
}
