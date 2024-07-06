namespace Common.DemoClasses
{
    public struct Structs
    {
        //structs can have fields, properties and functions
        private int _id;
        private string _name;
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        internal string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public string GetName() => _name;
        public void SetName(string name) => _name = name;
        //protected string Name { get; set; } //invalid as struct doesn't support inheritance

    }
}
