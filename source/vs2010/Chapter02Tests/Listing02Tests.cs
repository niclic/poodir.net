using NUnit.Framework;

using Gear = Chapter02.Listing02.Gear;
using Wheel = Chapter02.Listing02.Wheel;

namespace Chapter02Tests
{
    [TestFixture]
    public class Listing02Tests : TestBase
    {
        [Test]
        public void GearInches_ExpectsDuckThatKnowsDiameter_CalculatesGearInches()
        {
            var wheel = new Wheel(RimDiameterInInches, TireDiameterInInches);

            var gear = new Gear(NumberOfChainringTeeth, NumberOfCogTeeth, wheel);

            Assert.AreEqual(ExpectedGearInches, gear.GearInches());
        }
    }
}
