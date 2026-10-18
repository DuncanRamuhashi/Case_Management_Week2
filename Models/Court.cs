namespace Case_Management_Week2.Models
{
    public class Court
    {
        private int _id;
        private string _name;
        private string _location;

        public Court(int id, string name, string location) { 
           _id = id;
            _name = name;
            _location = location;
        }
        public int getId()
        {
            return _id;
        }
        public string getName() { 
        return _name;
        }
        public string getLocation() { 
         return _location;
        }
    }
}
