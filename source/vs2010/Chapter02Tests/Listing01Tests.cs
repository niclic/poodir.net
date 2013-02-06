using NUnit.Framework;

using Gear = Chapter02.Listing01.Gear;

namespace Chapter02Tests
{
    [TestFixture]
    public class Listing01Tests : TestBase
    {
        [Test]
        public void GearInches_WithGearDependantOnWheel_CalculatesGearInches()
        {
            var gear = new Gear(
                NumberOfChainringTeeth, 
                NumberOfCogTeeth, 
                RimDiameterInInches, 
                TireDiameterInInches
                );

            Assert.AreEqual(ExpectedGearInches, gear.GearInches());
        }
    }

    public abstract class TestBase
    {
        protected readonly int NumberOfChainringTeeth = 52;   // number of teeth in chainring
        protected readonly int NumberOfCogTeeth = 11;         // number of teeth in cog

        protected readonly int RimDiameterInInches = 26;         // diameter of wheel rim in inches
        protected readonly double TireDiameterInInches = 1.5d;   // diameter of tire in inches

        protected readonly double ExpectedGearRatio = 4.7272727272727275d;   // gear ratio = chainring / cog
        protected readonly double ExpectedGearInches = 137.09090909090909d;  // gear inches = (rim diameter + (tire diameter * 2)) * gear ratio
        protected readonly double ExpectedWheelCircumference = 91.106186954104d;     // wheel diameter * PI
    }
}
