using NUnit.Framework;

using Gear = Chapter02.Listing04.Gear;

namespace Chapter02Tests
{
    [TestFixture]
    public class Listing04Tests : TestBase
    {
        [Test]
        public void GearInches_WhenWheelIsCreatedInGearConstructor_CalculatesGearInches()
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
