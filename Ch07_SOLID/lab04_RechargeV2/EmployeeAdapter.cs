namespace lab04_RechargeV2
{
    public class EmployeeAdapter : ISleeper
    {
        private Employee employee;

        public EmployeeAdapter(string id) 
        {
            this.employee = new Employee(id);
        }

        public void Sleep()
        {
            this.employee.Sleep();
        }


    }
}