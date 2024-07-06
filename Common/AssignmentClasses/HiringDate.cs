namespace Common.AssignmentClasses
{
    public class HiringDate
    {
        public HiringDate(byte day, byte month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        private byte _day;
        private byte _month;
        private int _year;
        public byte Day
        {
            get { return _day; }
            set
            {
                if (value > 31)
                    throw new ArgumentException("The provided hiring day is invalid");
                else
                    _day = value;
            }
        }
        public byte Month
        {
            get { return _month; }
            set
            {
                if (value > 12)
                    throw new ArgumentException("The provided hiring month is invalid");
                else
                    _month = value;
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value > DateTime.Now.Year)
                    throw new ArgumentException("The provided hiring year is invalid");
                else
                    _year = value;
            }
        }
    }
}
