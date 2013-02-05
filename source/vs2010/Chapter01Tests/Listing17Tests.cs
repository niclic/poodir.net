using NUnit.Framework;

using Gear = Chapter01.Listing17.Gear;

namespace Chapter01Tests
{
    [TestFixture]
    public class Listing17Tests : TestBase
    {
        [Test]
        public void GearInches_WithDiameterMethodOnWheelObject_StillCalculatesGearInches()
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