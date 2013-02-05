using NUnit.Framework;

using Gear = Chapter01.Listing02.Gear;

namespace Chapter01Tests
{
    [TestFixture]
    public class Listing02Tests : TestBase
    {
        [Test]
        public void Ratio_OnValidGearInstance_CalculatesGearRatio()
        {
            var gear = new Gear(NumberOfChainringTeeth, NumberOfCogTeeth);

            Assert.AreEqual(ExpectedGearRatio, gear.Ratio());
        }
    }
}
