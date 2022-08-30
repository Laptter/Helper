namespace Helper.DapperHelperSample.Models
{
    internal class Employee
    {
        public int Employee_ID { get; set; }
        public string Fisrt_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Phone_Number { get; set; }
        public DateTime Hire_Date { get; set; }
        public string Job_Id { get; set; }
        public double Salary { get; set; }
        public double Commission_Pct { get; set; }
        public int Manager_Id { get; set; }
        public int Department_Id { get; set; }
    }
}
