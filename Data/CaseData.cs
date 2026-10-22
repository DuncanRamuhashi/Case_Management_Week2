using Case_Management_Week2.Models;

namespace Case_Management_Week2.Data
{
    public class CaseData
    {
        public static List<OriginalCase> originalCases = new List<OriginalCase>
        {
          new OriginalCase(1, "1001", "State vs Thabo Mokoena", DateTime.Now.Date),
new OriginalCase(2, "1002", "State vs Sipho Nkosi", DateTime.Now.Date),
new OriginalCase(3, "1003", "Nomsa Dlamini vs Peter Khumalo", DateTime.Now.Date),
new OriginalCase(4, "1004", "Lerato Molefe vs Kabelo Maseko", DateTime.Now.Date),
new OriginalCase(5, "1005", "Pieter van der Merwe vs Johan Botha", DateTime.Now.Date),
new OriginalCase(6, "1006", "Ayanda Ndlovu vs Sibusiso Zulu", DateTime.Now.Date),


        };
        public static CourtCase courtCase;
    }
}
