namespace Common.DemoClasses
{
    public class Employee
    {
        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        private int _id;
        private string? _name;
        private decimal _salary;
        public int Id
        {
            get { return _id; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid Id");
                else
                    _id = value;
            }
        }
        public string? Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public int GetEmployeeId() => _id;
        public void SetEmployeeId(int id)
        {

            if (id <= 0)
                throw new ArgumentException("Invalid Id");
            else
                _id = id;
        }
        public override string ToString()
        {
            return $"Employee {Name} with id {Id} has a salary {Salary} EGP";
        }

    }
}
