using System.Collections.Generic;
using System.Linq;
using Synonms.Musiq.Domain.Enumerations;
using Synonms.Musiq.Domain.Extensions;
using Xunit;

namespace Synonms.Musiq.Domain.Tests.Extensions
{
    public class IntonationExtensionsTests
    {
        [Fact]
        public void GetChromaticOctave_GivenC_ThenReturnsOctave()
        {
            var intonations = Intonation.C.GetChromaticOctave().ToList();

            Assert.Equal(12, intonations.Count);
            Assert.Equal(Intonation.C, intonations[0]);
            Assert.Equal(Intonation.CsDb, intonations[1]);
            Assert.Equal(Intonation.D, intonations[2]);
            Assert.Equal(Intonation.DsEb, intonations[3]);
            Assert.Equal(Intonation.E, intonations[4]);
            Assert.Equal(Intonation.F, intonations[5]);
            Assert.Equal(Intonation.FsGb, intonations[6]);
            Assert.Equal(Intonation.G, intonations[7]);
            Assert.Equal(Intonation.GsAb, intonations[8]);
            Assert.Equal(Intonation.A, intonations[9]);
            Assert.Equal(Intonation.AsBb, intonations[10]);
            Assert.Equal(Intonation.B, intonations[11]);
        }

        [Fact]
        public void GetIntonation_GivenCMajor_ThenReturnsIntonation()
        {
            var intonations = new List<Intonation>
                { Intonation.C, Intonation.D, Intonation.E, Intonation.F, Intonation.G, Intonation.A, Intonation.B};

            Assert.Equal(Intonation.C, intonations.GetIntonation(Degree.I));
            Assert.Equal(Intonation.D, intonations.GetIntonation(Degree.II));
            Assert.Equal(Intonation.E, intonations.GetIntonation(Degree.III));
            Assert.Equal(Intonation.F, intonations.GetIntonation(Degree.IV));
            Assert.Equal(Intonation.G, intonations.GetIntonation(Degree.V));
            Assert.Equal(Intonation.A, intonations.GetIntonation(Degree.VI));
            Assert.Equal(Intonation.B, intonations.GetIntonation(Degree.VII));
        }
    }
}
