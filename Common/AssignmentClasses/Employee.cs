namespace Common.AssignmentClasses
{
    public class Employee
    {
        public Employee(int id, string name, Security security, decimal salary
            , Gender gender, HiringDate hiringDate)
        {
            Id = id;
            Name = name;
            SecurityLevel = security;
            Salary = salary;
            Gender = gender;
            HiringDate = hiringDate;
        }
        private int _id;
        private Security _securityLevel;
        private decimal _salary;
        private Gender _gender;
        public int Id
        {
            get { return _id; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("The provided id is invalid");
                else
                    _id = value;
            }
        }
        public string Name { get; set; }
        public Security SecurityLevel
        {
            get { return _securityLevel; }
            set
            {
                if (Enum.IsDefined(typeof(Security), value))
                    _securityLevel = value;
                else
                    throw new ArgumentException("The provided security level is invalid");
            }
        }
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("The provided salary is invalid");
                else
                    _salary = value;
            }
        }
        public HiringDate HiringDate { get; set; }
        public Gender Gender
        {
            get { return _gender; }
            set
            {
                if (Enum.IsDefined(typeof(Gender), value))
                    _gender = value;
                else
                    throw new ArgumentException("The provided gender is invalid");
            }
        }

        public override string ToString()
        {
            return string.Format("{0}'s Salary = {1:C}", Name, Salary);
        }
    }
}
