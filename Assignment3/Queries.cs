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

        public static IEnumerable<string> allWizByRowlingLINQ()
        {
            var wizards = Wizard.Wizards.Value;

            var wizs = from w in wizards
                        where w.Creator.Contains("J. K. Rowling")
                        select w.Name;

            return wizs;
        }

        public static int? firstSithLord()
        {
            var wizards = Wizard.Wizards.Value;

            return wizards.Where(c => c.Name.Contains("Darth")).OrderByDescending(c => c.Year).Select(c => c.Year).First();
        }

        public static int? firstSithLordLINQ()
        {
            var wizards = Wizard.Wizards.Value;

            var darth = (from w in wizards
                        where w.Name.Contains("Darth")
                        orderby w.Year descending
                        select w.Year).First();
            return darth;
        }

        public static IEnumerable<Tuple<string, int?>> uniqueWiz()
        {
            var wizards = Wizard.Wizards.Value;

            return wizards.Where(c => c.Creator=="J. K. Rowling").Select(c => Tuple.Create(c.Name,c.Year));
        }

        public static IEnumerable<Tuple<string, int?>> uniqueWizLINQ()
        {
            var wizards = Wizard.Wizards.Value;

            var unique = from w in wizards
                        where w.Creator.Contains("J. K. Rowling")
                        select Tuple.Create(w.Name, w.Year);

            return unique;
        }

        public static IEnumerable<IGrouping<string,string>> reverseOrderWizNamesGroupedByCNameThenWName()
        {
            var wizards = Wizard.Wizards.Value;
            
            return wizards.OrderByDescending(c => c.Creator).ThenByDescending(c => c.Name).GroupBy(c => (c.Creator), c => c.Name);
        }

        public static IEnumerable<string> reverseOrderWizNamesGroupedByCNameThenWNameLINQ()
        {
            var wizards = Wizard.Wizards.Value;

            var groups = from w in wizards
                        orderby w.Creator descending
                        orderby w.Name descending
                        group w by new {w.Creator, w.Name} into g
                        select g.Key.Name;
            return groups;
        }
    }
}
