namespace Case_Management_Week2.Models
{
    public class Charge
    {
        private int _id;
        private string _name;

        public Charge(int id, string name) { 
              _id = id;
            _name = name;
        }
        public string getName() { 
         return _name;
        }
        public int getId() { 
         return _id;
        }
        public void setName(string name)
        {
            _name = name;
        }
    }
}
