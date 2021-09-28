using System;
using System.Collections.Generic;
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
        public void reverseOrder_given_wizList_return_JRRR_Tolkien_JK_Rowling_George_Lucas_and_wizards_InDescending()
        {
            //Arrange
            var sauron = ("J.R.R. Tolkien","Sauron"); 
            var sirius = ("J. K. Rowling", "Sirius Black");      
            var severus = ("J. K. Rowling", "Severus Snape");     
            var rubeus = ("J. K. Rowling", "Rubeus Hagrid");       
            var ron = ("J. K. Rowling", "Ron Weasly");      
            var mad = ("J. K. Rowling", "Mad Eye Moody");      
            var luna = ("J. K. Rowling", "Luna Lovegood");      
            var lucious = ("J. K. Rowling", "Lucious Malfoy");      
            var lord = ("J. K. Rowling", "Lord Voldemort");      
            var hermione = ("J. K. Rowling", "Hermione Granger");      
            var harry = ("J. K. Rowling", "Harry James Potter");      
            var ginny = ("J. K. Rowling", "Ginny Weasly");      
            var draco = ("J. K. Rowling", "Draco Malfoy");      
            var dobby = ("J. K. Rowling", "Dobby");      
            var cedric = ("J. K. Rowling", "Cedric Diggory");      
            var bellatrix = ("J. K. Rowling", "Bellatrix Lestrange");      
            var albus = ("J. K. Rowling", "Albus Dumbledore");      
            var darth = ("George Lucas", "Darth Vader");

            var tempExpectedOrder = new[]
            {
                sauron, sirius, severus, rubeus, ron, mad, luna, lucious, lord, hermione, harry, ginny, draco, dobby,
                cedric, bellatrix, albus, darth
            };
            IEnumerable<IGrouping<string, string>> expectedOrder =
                tempExpectedOrder.GroupBy(c => (c.Item1), c => (c.Item2));
                

            //Act
            var groupedWiz = Queries.reverseOrderWizNamesGroupedByCNameThenWName();

            //Assert
            Assert.Equal(expectedOrder, groupedWiz);
        }

    }
}
