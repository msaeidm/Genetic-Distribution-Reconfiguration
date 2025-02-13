using System;
using GeneticReconfiguration;
using Xunit;

namespace GeneticReconfigurationTests
{
    public class UnitTests
    {
        [Fact]
        public void TestFuzzyMembership()
        {
            double membership = FuzzyMembership.CalculateMembership(75, 100, 50);
            Assert.InRange(membership, 0.0, 1.0);
        }

        // Additional unit tests can be added for GAReconfiguration, GeneticOperators, etc.
    }
}
