using System.Collections.Generic;
using System.Linq;
using Synonms.Musiq.Domain.Enumerations;
using Synonms.Musiq.Domain.Extensions;
using Xunit;

namespace Synonms.Musiq.Domain.Tests.Extensions
{
    public class IntervalExtensionsTests
    {
        private List<Interval> intervals = new List<Interval>
        {
            Interval.WholeStep,
            Interval.WholeStep,
            Interval.HalfStep,
            Interval.WholeStep,
            Interval.WholeStep,
            Interval.WholeStep,
            Interval.HalfStep,
        };

        [Fact]
        public void GetChromaticIndex_GivenDegree_ThenReturnsIndex()
        {
            Assert.Equal(0, intervals.GetChromaticIndex(Degree.I));
            Assert.Equal(2, intervals.GetChromaticIndex(Degree.II));
            Assert.Equal(4, intervals.GetChromaticIndex(Degree.III));
            Assert.Equal(5, intervals.GetChromaticIndex(Degree.IV));
            Assert.Equal(7, intervals.GetChromaticIndex(Degree.V));
            Assert.Equal(9, intervals.GetChromaticIndex(Degree.VI));
            Assert.Equal(11, intervals.GetChromaticIndex(Degree.VII));
        }

        [Fact]
        public void GetComponentInterval_Given_Then()
        {
            // TODO
        }

        [Fact]
        public void GetOffset_GivenFirstDegree_ThenReturnsShiftedIntervals()
        {
            var offsetIntervals = intervals.GetOffset(Degree.I).ToList();

            Assert.Equal(7, offsetIntervals.Count);
            Assert.Equal(Interval.WholeStep, offsetIntervals[0]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[1]);
            Assert.Equal(Interval.HalfStep, offsetIntervals[2]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[3]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[4]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[5]);
            Assert.Equal(Interval.HalfStep, offsetIntervals[6]);
        }

        [Fact]
        public void GetOffset_GivenSecondDegree_ThenReturnsShiftedIntervals()
        {
            var offsetIntervals = intervals.GetOffset(Degree.II).ToList();

            Assert.Equal(7, offsetIntervals.Count);
            Assert.Equal(Interval.WholeStep, offsetIntervals[0]);
            Assert.Equal(Interval.HalfStep, offsetIntervals[1]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[2]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[3]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[4]);
            Assert.Equal(Interval.HalfStep, offsetIntervals[5]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[6]);
        }

        [Fact]
        public void GetOffset_GivenThirdDegree_ThenReturnsShiftedIntervals()
        {
            var offsetIntervals = intervals.GetOffset(Degree.III).ToList();

            Assert.Equal(7, offsetIntervals.Count);
            Assert.Equal(Interval.HalfStep, offsetIntervals[0]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[1]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[2]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[3]);
            Assert.Equal(Interval.HalfStep, offsetIntervals[4]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[5]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[6]);
        }

        [Fact]
        public void GetOffset_GivenFourthDegree_ThenReturnsShiftedIntervals()
        {
            var offsetIntervals = intervals.GetOffset(Degree.IV).ToList();

            Assert.Equal(7, offsetIntervals.Count);
            Assert.Equal(Interval.WholeStep, offsetIntervals[0]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[1]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[2]);
            Assert.Equal(Interval.HalfStep, offsetIntervals[3]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[4]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[5]);
            Assert.Equal(Interval.HalfStep, offsetIntervals[6]);
        }

        [Fact]
        public void GetOffset_GivenFifthDegree_ThenReturnsShiftedIntervals()
        {
            var offsetIntervals = intervals.GetOffset(Degree.V).ToList();

            Assert.Equal(7, offsetIntervals.Count);
            Assert.Equal(Interval.WholeStep, offsetIntervals[0]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[1]);
            Assert.Equal(Interval.HalfStep, offsetIntervals[2]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[3]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[4]);
            Assert.Equal(Interval.HalfStep, offsetIntervals[5]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[6]);
        }

        [Fact]
        public void GetOffset_GivenSixthDegree_ThenReturnsShiftedIntervals()
        {
            var offsetIntervals = intervals.GetOffset(Degree.VI).ToList();

            Assert.Equal(7, offsetIntervals.Count);
            Assert.Equal(Interval.WholeStep, offsetIntervals[0]);
            Assert.Equal(Interval.HalfStep, offsetIntervals[1]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[2]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[3]);
            Assert.Equal(Interval.HalfStep, offsetIntervals[4]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[5]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[6]);
        }

        [Fact]
        public void GetOffset_GivenSeventhDegree_ThenReturnsShiftedIntervals()
        {
            var offsetIntervals = intervals.GetOffset(Degree.VII).ToList();

            Assert.Equal(7, offsetIntervals.Count);
            Assert.Equal(Interval.HalfStep, offsetIntervals[0]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[1]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[2]);
            Assert.Equal(Interval.HalfStep, offsetIntervals[3]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[4]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[5]);
            Assert.Equal(Interval.WholeStep, offsetIntervals[6]);
        }

        [Fact]
        public void GetIntonations_GivenMajorIntervals_AndCRoot_ThenReturnsCMajorNotes()
        {
            var intonations = intervals.GetIntonations(Intonation.C).ToList();

            Assert.Equal(7, intonations.Count);
            Assert.Equal(Intonation.C, intonations[0]);
            Assert.Equal(Intonation.D, intonations[1]);
            Assert.Equal(Intonation.E, intonations[2]);
            Assert.Equal(Intonation.F, intonations[3]);
            Assert.Equal(Intonation.G, intonations[4]);
            Assert.Equal(Intonation.A, intonations[5]);
            Assert.Equal(Intonation.B, intonations[6]);
        }

        [Fact]
        public void GetIntonation_GivenMajorIntervals_AndCRoot_ThenReturnsCMajorNotes()
        {
            Assert.Equal(Intonation.C, intervals.GetIntonation(Intonation.C, Degree.I));
            Assert.Equal(Intonation.D, intervals.GetIntonation(Intonation.C, Degree.II));
            Assert.Equal(Intonation.E, intervals.GetIntonation(Intonation.C, Degree.III));
            Assert.Equal(Intonation.F, intervals.GetIntonation(Intonation.C, Degree.IV));
            Assert.Equal(Intonation.G, intervals.GetIntonation(Intonation.C, Degree.V));
            Assert.Equal(Intonation.A, intervals.GetIntonation(Intonation.C, Degree.VI));
            Assert.Equal(Intonation.B, intervals.GetIntonation(Intonation.C, Degree.VII));
        }

        [Fact]
        public void GetTriadChord_GivenCMajor_AndIDegree_ThenReturnsCMajor()
        {
            var chord = intervals.GetTriadChord(Intonation.C, Degree.I);
            var intonations = chord.Intonations.ToList();

            Assert.Equal(Intonation.C, intonations[0]);
            Assert.Equal(Intonation.E, intonations[1]);
            Assert.Equal(Intonation.G, intonations[2]);
        }

        [Fact]
        public void GetTriadChord_GivenCMajor_AndIIDegree_ThenReturnsDMinor()
        {
            var chord = intervals.GetTriadChord(Intonation.C, Degree.II);
            var intonations = chord.Intonations.ToList();

            Assert.Equal(Intonation.D, intonations[0]);
            Assert.Equal(Intonation.F, intonations[1]);
            Assert.Equal(Intonation.A, intonations[2]);
        }

        [Fact]
        public void GetTriadChord_GivenCMajor_AndIIIDegree_ThenReturnsEMinor()
        {
            var chord = intervals.GetTriadChord(Intonation.C, Degree.III);
            var intonations = chord.Intonations.ToList();

            Assert.Equal(Intonation.E, intonations[0]);
            Assert.Equal(Intonation.G, intonations[1]);
            Assert.Equal(Intonation.B, intonations[2]);
        }

        [Fact]
        public void GetTriadChord_GivenCMajor_AndIVDegree_ThenReturnsFMajor()
        {
            var chord = intervals.GetTriadChord(Intonation.C, Degree.IV);
            var intonations = chord.Intonations.ToList();

            Assert.Equal(Intonation.F, intonations[0]);
            Assert.Equal(Intonation.A, intonations[1]);
            Assert.Equal(Intonation.C, intonations[2]);
        }

        [Fact]
        public void GetTriadChord_GivenCMajor_AndVDegree_ThenReturnsGMajor()
        {
            var chord = intervals.GetTriadChord(Intonation.C, Degree.V);
            var intonations = chord.Intonations.ToList();

            Assert.Equal(Intonation.G, intonations[0]);
            Assert.Equal(Intonation.B, intonations[1]);
            Assert.Equal(Intonation.D, intonations[2]);
        }

        [Fact]
        public void GetTriadChord_GivenCMajor_AndVIDegree_ThenReturnsAMinor()
        {
            var chord = intervals.GetTriadChord(Intonation.C, Degree.VI);
            var intonations = chord.Intonations.ToList();

            Assert.Equal(Intonation.A, intonations[0]);
            Assert.Equal(Intonation.C, intonations[1]);
            Assert.Equal(Intonation.E, intonations[2]);
        }

        [Fact]
        public void GetTriadChord_GivenCMajor_AndIIDegree_ThenReturnsBDiminished()
        {
            var chord = intervals.GetTriadChord(Intonation.C, Degree.VII);
            var intonations = chord.Intonations.ToList();

            Assert.Equal(Intonation.B, intonations[0]);
            Assert.Equal(Intonation.D, intonations[1]);
            Assert.Equal(Intonation.F, intonations[2]);
        }

        [Fact]
        public void GetSeventhChord_GivenCMajor_AndIDegree_ThenReturnsCMajor7()
        {
            var chord = intervals.GetSeventhChord(Intonation.C, Degree.I);
            var intonations = chord.Intonations.ToList();

            Assert.Equal(Intonation.C, intonations[0]);
            Assert.Equal(Intonation.E, intonations[1]);
            Assert.Equal(Intonation.G, intonations[2]);
            Assert.Equal(Intonation.B, intonations[3]);
        }

        [Fact]
        public void GetSeventhChord_GivenCMajor_AndIIDegree_ThenReturnsDMinor7()
        {
            var chord = intervals.GetSeventhChord(Intonation.C, Degree.II);
            var intonations = chord.Intonations.ToList();

            Assert.Equal(Intonation.D, intonations[0]);
            Assert.Equal(Intonation.F, intonations[1]);
            Assert.Equal(Intonation.A, intonations[2]);
            Assert.Equal(Intonation.C, intonations[3]);
        }

        [Fact]
        public void GetSeventhChord_GivenCMajor_AndIIIDegree_ThenReturnsEMinor7()
        {
            var chord = intervals.GetSeventhChord(Intonation.C, Degree.III);
            var intonations = chord.Intonations.ToList();

            Assert.Equal(Intonation.E, intonations[0]);
            Assert.Equal(Intonation.G, intonations[1]);
            Assert.Equal(Intonation.B, intonations[2]);
            Assert.Equal(Intonation.D, intonations[3]);
        }

        [Fact]
        public void GetSeventhChord_GivenCMajor_AndIVDegree_ThenReturnsFMajor7()
        {
            var chord = intervals.GetSeventhChord(Intonation.C, Degree.IV);
            var intonations = chord.Intonations.ToList();

            Assert.Equal(Intonation.F, intonations[0]);
            Assert.Equal(Intonation.A, intonations[1]);
            Assert.Equal(Intonation.C, intonations[2]);
            Assert.Equal(Intonation.E, intonations[3]);
        }

        [Fact]
        public void GetSeventhChord_GivenCMajor_AndVDegree_ThenReturnsGMajor7()
        {
            var chord = intervals.GetSeventhChord(Intonation.C, Degree.V);
            var intonations = chord.Intonations.ToList();

            Assert.Equal(Intonation.G, intonations[0]);
            Assert.Equal(Intonation.B, intonations[1]);
            Assert.Equal(Intonation.D, intonations[2]);
            Assert.Equal(Intonation.F, intonations[3]);
        }

        [Fact]
        public void GetSeventhChord_GivenCMajor_AndVIDegree_ThenReturnsAMinor7()
        {
            var chord = intervals.GetSeventhChord(Intonation.C, Degree.VI);
            var intonations = chord.Intonations.ToList();

            Assert.Equal(Intonation.A, intonations[0]);
            Assert.Equal(Intonation.C, intonations[1]);
            Assert.Equal(Intonation.E, intonations[2]);
            Assert.Equal(Intonation.G, intonations[3]);
        }

        [Fact]
        public void GetSeventhChord_GivenCMajor_AndIIDegree_ThenReturnsBDiminished7()
        {
            var chord = intervals.GetSeventhChord(Intonation.C, Degree.VII);
            var intonations = chord.Intonations.ToList();

            Assert.Equal(Intonation.B, intonations[0]);
            Assert.Equal(Intonation.D, intonations[1]);
            Assert.Equal(Intonation.F, intonations[2]);
            Assert.Equal(Intonation.A, intonations[3]);
        }
    }
}
