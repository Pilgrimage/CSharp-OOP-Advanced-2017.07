namespace lab04_RechargeV2
{
    public class Program
    {
        public static void Main()
        {
            // using Adapter pattern

            IRechargeable robot = new RobotAdapter("id", 23);
            ISleeper employee = new EmployeeAdapter( "pesho");
            RechargeStation rechargeStation = new RechargeStation();
            //rechargeStation.Recharge(employee);
            rechargeStation.Recharge(robot);

        }
    }
}
