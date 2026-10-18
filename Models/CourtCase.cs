using System.Data;

namespace Case_Management_Week2.Models
{
    public class CourtCase
    {
        private int _id;
        private string _status;
        private OriginalCase _originalCase;

        private Court _court;
        private Judge _judge;
        private Prosecutor _prosecutor;
        private List<Charge> _charges = new List<Charge>();
        private Dictionary<string, Defendant> _defendants = new Dictionary<string, Defendant>();

        public CourtCase(int id)
        {

            _id = id;
            _status = "Open";
        }
        public void addCharge(Charge c) { 
           _charges.Add(c);
        }
        public void addDefendant(string id,Defendant d) {
            _defendants.Add(id,d);
        }
        public void assignOriginalCase(OriginalCase originalCase) { 
          _originalCase = originalCase;
        }
        public void assignCourt(int id, string name, string location) { 
          _court = new Court(id,name,location);

            updateStatus("Trial");

        }
        public int getId()
        {
            return _id;
        }
        public void assignJudge(string id, string name) {
            _judge = new Judge(id, name);
        }
        public void assignProsecutor(string id, string name)
        {
            _prosecutor = new Prosecutor(id, name);
        }
        public void updateStatus(string status)
        {
           _status = status;
        }
        public string getStatus() { 
        return _status;

        }
        public string getCaseNumber() { 
          return _originalCase.getCaseNumber();
        }

        public string getCaseName() { 
          return _originalCase.getName();
        }
        
        public Court getCourt() {
            return _court;
        }

        public Judge getJudge() {
            return _judge;
        }
        public Prosecutor getProsecutor() {
            return _prosecutor;
        }
        public List<Charge> getCharges() {
            return _charges;
        }
        public Dictionary<string, Defendant> getDefendants() {
            return _defendants;
        }

    }
}
