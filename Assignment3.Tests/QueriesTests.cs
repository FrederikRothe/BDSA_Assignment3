using System;
using Xunit;
using System.Linq;
using BDSA2021.Assignment03;

namespace BDSA2021.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void allWizByRowling_Given_15_rowlingWiz()
        {
            //Arrange
            var wizards = Wizard.Wizards.Value;
            int expectedAmount = 16;

            //Act
            var rowlingWiz = Queries.allWizByRowling().Count();

            //Assert
            Assert.Equal(rowlingWiz,expectedAmount);
        }

        [Fact]
        public void firstSithLord_given_dart_1977()
        {
            //Arrange
            var wizards = Wizard.Wizards.Value;
            int? expectedYear = 1977;
            //Act
            var firstSithYear = Queries.firstSithLord();
            //Assert
            Assert.Equal(firstSithYear,expectedYear);
        }

        [Fact]
        public void uniqueWiz_given_wizList()
        {
            //Arrange
            var wizards = Wizard.Wizards.Value;
            var expectedOutput = 16;
            //Act
            var uniqeWizses = Queries.uniqueWiz().Count();
            //Assert
            Assert.Equal(uniqeWizses,expectedOutput);
        }

        [Fact]
        public void reverseOrder_given_wizList()
        {
            //Arrange
            var wizards = Wizard.Wizards.Value;

            //Act
            var groupedWiz = Queries.reverseOrderWizNamesGroupedByCNameThenWName();

            //Assert
        }

    }
}
