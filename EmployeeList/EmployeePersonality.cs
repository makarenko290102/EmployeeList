namespace EmployeeList
{
    public class EmployeePersonality
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string LineOfAction {  get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        //protected int PhoneConvert(int PhoneNumber)
        //{
        //    this.PhoneNumber = Convert.ToInt32(PhoneNumber);
        //    return PhoneNumber;
        //}
        public string Email { get; set; } = string.Empty.ToLower();
    }
}
