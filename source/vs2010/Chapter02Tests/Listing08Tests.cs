using NUnit.Framework;

using Gear = Chapter02.Listing08.Gear;

namespace Chapter02Tests
{
    [TestFixture]
    public class Listing08Tests : TestBase
    {
        [Test]
        public void GearInches_UsingDiameterMethod_CalculatesGearInches()
        {
            var gear = new Gear(
                NumberOfChainringTeeth,
                NumberOfCogTeeth,
                RimDiameterInInches,
                TireDiameterInInches);

            Assert.AreEqual(ExpectedGearInches, gear.GearInches);
        }
    }
}
