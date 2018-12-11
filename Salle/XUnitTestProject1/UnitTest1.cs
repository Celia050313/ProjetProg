using System;
using Xunit;
using Model;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        public int wd = Map.GetWidth();
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, wd);
        }
    }
}
