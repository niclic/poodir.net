using NUnit.Framework;

using Gear = Chapter02.Listing05.Gear;

namespace Chapter02Tests
{
    [TestFixture]
    public class Listing05Tests : TestBase
    {
        [Test]
        public void GearInches_CallsGetWheelMethod_CalculatesGearInches()
        {
            var gear = new Gear(
                NumberOfChainringTeeth,
                NumberOfCogTeeth,
                RimDiameterInInches,
                TireDiameterInInches);

            Assert.AreEqual(ExpectedGearInches, gear.GearInches());
        }
    }
}
