namespace lab04_Recharge
{
    public class Program
    {
        public static void Main()
        {
            // Refactoring library 

            IRechargeable robot = new Robot("id", 23);
            Employee employee = new Employee("pesho");
            RechargeStation rechargeStation = new RechargeStation();
            //rechargeStation.Recharge(employee);
            rechargeStation.Recharge(robot);
        }
    }
}
