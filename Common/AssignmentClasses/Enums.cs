namespace Common.AssignmentClasses
{
    public enum Gender : byte
    {
        Male = 0,
        Female = 1
    }
    public enum Security : byte
    {
        Guest = 2,
        Developer = 4,
        Secretary = 6,
        Dba = 8,
        SecurityOfficer = Guest | Developer | Secretary | Dba
    }
}
