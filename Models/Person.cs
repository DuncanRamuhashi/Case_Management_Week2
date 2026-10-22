namespace Case_Management_Week2.Models
{
    public abstract class Person : IGetter
    {
        private string _id;
        private string _name;

        public Person(string id, string name) {

            _id = id;
            _name = name;
        }
        public string getId() { 
        return _id;

        }
        public string getName() {
            return _name;
        }
        public void setName(string name) { 
          _name = name;
        }
    }
}
