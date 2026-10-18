namespace Case_Management_Week2.Models
{
    public class OriginalCase
    {
        private int _id;
        private string _caseNumber;
        private string _name;
        private DateTime _date;

        public OriginalCase(int id,string caseNumber,string name,DateTime date) { 
            _id = id;
            _caseNumber = caseNumber;
            _name = name;
            _date = date;
        }
        public int getId()
        {
            return _id;
        }
        public string getCaseNumber() { 
           return _caseNumber;
        }
        public DateTime getDate() {
            return _date;
        }
        public string getName() {
            return _name;
        }
    }
}
