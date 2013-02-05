using NUnit.Framework;

using Gear = Chapter01.Listing16.Gear;

namespace Chapter01Tests
{
    [TestFixture]
    public class Listing16Tests : TestBase
    {
        [Test]
        public void GearInches_WithDiameterMethodExtracted_StillCalculatesGearInches()
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
