using NUnit.Framework;

using Gear = Chapter01.Listing03.Gear;

namespace Chapter01Tests
{
    [TestFixture]
    public class Listing03Tests : TestBase
    {
        [Test]
        public void GearInches_OnValidGearInstance_CalculatesGearInches()
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
