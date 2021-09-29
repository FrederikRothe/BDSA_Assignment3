using System;
using Xunit;
using BDSA2021.Assignment03;

namespace BDSA2021.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void flatten_given_Nested_Array_of_ints_1_2_3_4_and_5_6_7_8_return_1_2_3_4_5_6_7_8()
        {   
            //arrange
            var input = new [] {new int[] {1,2,3,4}, new int[] {5,6,7,8}};

            //act
            var output = Extensions.flatten(input);

            //assert
            Assert.Equal(new int[]{1,2,3,4,5,6,7,8}, output);
        }

        [Fact]
        public void numbersDivisbleBy7AndGreaterThan42_given_An_Array_of_ints_7_8_42_55_56_63_64_70_return_a_56_63_70()
        {
            //arrange
            var input = new int[] {7,8,42,55,56,63,64,70};

            //act
            var output = Extensions.numbersDivisbleBy7AndGreaterThan42(input);

            //assert

            Assert.Equal(new int[]{56,63,70}, output);
        } 

        [Fact]
        public void findLeapYears_given_array_of_ints_40_400_100_102_1600_2000_1900_return_40_400_1600_2000()
        {
            //arrange
            var input = new int[] {40, 400, 100, 102, 1600, 2000, 1900};

            //act
            var output = Extensions.findLeapYears(input);

            //assert
            Assert.Equal(new int[] {40, 400, 1600, 2000}, output);
        }

        [Fact]
        public void isSecure_given_Unsecure_Uri_Return_false()
        {
            //arrange
            var input = new Uri("http://www.erdetfredag.dk/");

            //act
            var output = Extensions.isSecure(input);

            //assert
            Assert.False(output);
        }

        [Fact]
        public void WordCount_given_string_With_Hej_med_dig_123_and_various_arithmetic_operators_return_3()
        {
            //arrange
            var input = "Hej med dig 123 %%% ?? =! ";

            //act
            var output = Extensions.WordCount(input);

            //assert
            Assert.Equal(3, output);
        }
    }
}
