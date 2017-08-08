using NUnit.Framework;

[TestFixture]
public class HeroTests
{

    private const int AxeAttack = 10;
    private const int AxeDurability = 10;
    private const int DummyHealth = 10;
    private const int DummyExp = 10;

    //private const string Name;
    //private const int Experience;
    private Axe weapon;
    private Dummy dummy;

    [SetUp]
    public void TestInit()
    {
        //Arrange
        this.weapon = new Axe(AxeAttack, AxeDurability);
        this.dummy = new Dummy(DummyHealth, DummyExp);
    }









    [Test]
    public void TestMethod()
    {
        // TODO: Add your test code here
        Assert.Pass("Your first passing test");
    }
}
