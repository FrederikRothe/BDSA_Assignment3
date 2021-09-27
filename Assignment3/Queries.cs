using System;
using System.Collections.Generic;
using System.Linq;
namespace BDSA2021.Assignment03
{
    public class Queries
    {
        public static IEnumerable<string> allWizByRowling()
        {
            var wizards = Wizard.Wizards.Value;
            
            return wizards.Where(c => c.Creator=="J. K. Rowling").Select(c => c.Name);
        }

        public static int? firstSithLord()
        {
            var wizards = Wizard.Wizards.Value;

            return wizards.Where(c => c.Name.Contains("Darth")).OrderByDescending(c => c.Year).Select(c => c.Year).First();
        }

        public static IEnumerable<Tuple<string, int?>> uniqueWiz()
        {
            var wizards = Wizard.Wizards.Value;

            return wizards.Where(c => c.Creator=="J. K. Rowling").Select(c => Tuple.Create(c.Name,c.Year));
        }

        public static IEnumerable<IGrouping<string,string>> reverseOrderWizNamesGroupedByCNameThenWName()
        {
            var wizards = Wizard.Wizards.Value;
            
            return wizards.OrderByDescending(c => c.Creator).ThenByDescending(c => c.Name).GroupBy(c => (c.Creator), c => c.Name);
        }
    }
}
