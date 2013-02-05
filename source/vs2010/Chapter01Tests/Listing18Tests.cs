using NUnit.Framework;

using Wheel = Chapter01.Listing18.Wheel;
using Gear = Chapter01.Listing18.Gear;

namespace Chapter01Tests
{
    [TestFixture]
    public class Listing18Tests : TestBase
    {
        [Test]
        public void Circumference_OnWheelInstanceWithRimAndTire_CalculatesCircumference()
        {
            Assert.AreEqual(ExpectedWheelCircumference, CreateWheel().Circumference());
        }

        [Test]
        public void GearInches_OnValidGearInstance_CalculatesGearInches()
        {
            Assert.AreEqual(ExpectedGearInches, CreateGear().GearInches());
        }

        [Test]
        public void Ratio_OnValidGearInstance_CalculatesGearRatio()
        {
            Assert.AreEqual(ExpectedGearRatio, CreateGear().Ratio());
        }

        private Gear CreateGear()
        {
            return new Gear(NumberOfChainringTeeth, NumberOfCogTeeth, CreateWheel());
        }

        private Wheel CreateWheel()
        {
            return new Wheel(RimDiameterInInches, TireDiameterInInches);
        }
    }
}
