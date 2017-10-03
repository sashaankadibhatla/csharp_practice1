using System;
using Xunit;
using palindrome_program;
using  program5;

namespace practice_tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            palindrome  obj1=new palindrome();
            //Act
            string seq="12321";
            int result=obj1.palindrome_fun(seq);
            //Assert
            Assert.IsType<int>(result);
            Assert.Equal(4,result);
            Assert.NotEqual(5,result);
        }
        [Fact]
        public void Test2()
        {
            //Arrange
            sort_number obj2=new sort_number();
            //Act
            string seq1="12321456743222";
            int result1=obj2.sort_number_fun(seq1);
            //Assert
            Assert.IsType<int>(result1);
            Assert.Equal(24,result1);
            Assert.NotEqual(25,result1);
        }
    }
}
