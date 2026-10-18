using Case_Management_Week2.Models;

namespace Case_Management_Week2.Data
{
    public class CaseData
    {
        public static List<OriginalCase> originalCases = new List<OriginalCase>
        {
            new OriginalCase(1, "1001", "State vs John Doe", DateTime.Now.Date),
            new OriginalCase(2, "1002", "State vs Michael Smith", DateTime.Now.Date),
            new OriginalCase(3, "1003", "Ace vs David Mokoena", DateTime.Now.Date),
            new OriginalCase(4, "1004", "John vs David Mokoena", DateTime.Now.Date),
            new OriginalCase(5, "1005", "William vs David Mokoena", DateTime.Now.Date),
            new OriginalCase(6, "1006", "Jack vs David Mokoena", DateTime.Now.Date),
             new OriginalCase(7, "1007", "Jacob vs David Mokoena", DateTime.Now.Date)
        };
        public static CourtCase courtCase;
    }
}
