using System;
using System.Collections.Generic;
using System.Linq;
using Synonms.Musiq.Domain.Enumerations;

namespace Synonms.Musiq.Domain.Extensions
{
    public static class IntervalExtensions
    {
        public static int GetChromaticIndex(this IEnumerable<Interval> intervals, Degree degree)
        {
            if (degree == Degree.Unknown)
            {
                throw new ArgumentOutOfRangeException("Invalid degree");
            }

            var offset = (int)degree - 1;

            if (offset > intervals.Count())
            {
                throw new ArgumentOutOfRangeException("Not enough intervals for specified degree");
            }

            var index = 0;

            for (int i = 0; i < offset; i++)
            {
                index += (int)intervals.ElementAt(i);
            }

            return index;
        }

        public static ComponentInterval GetComponentInterval(this IEnumerable<Interval> intervals, Degree degree) =>
            (ComponentInterval)intervals.GetChromaticIndex(degree);

        public static IEnumerable<Interval> GetOffset(this IEnumerable<Interval> intervals, Degree degree)
        {
            if (degree == Degree.Unknown)
            {
                throw new ArgumentOutOfRangeException("Invalid degree");
            }

            var offset = (int)degree - 1;

            if (offset >= intervals.Count())
            {
                throw new ArgumentOutOfRangeException("Not enough intervals for specified degree");
            }

            var results = new List<Interval>();

            for (int i = offset; i < intervals.Count(); i++)
            {
                results.Add(intervals.ElementAt(i));
            }

            for (int i = 0; i < offset; i++)
            {
                results.Add(intervals.ElementAt(i));
            }

            return results;
        }

        public static IEnumerable<Intonation> GetIntonations(this IEnumerable<Interval> intervals, Intonation root)
        {
            var octave = root.GetChromaticOctave().ToList();

            var results = new List<Intonation>();
            results.Add(root);

            var index = 0;
            foreach (var interval in intervals)
            {
                index += (int)interval;

                if (index >= octave.Count) continue;

                results.Add(octave[index]);
            }

            return results;
        }

        public static Intonation GetIntonation(this IEnumerable<Interval> intervals, Intonation root, Degree degree) =>
            root.GetChromaticOctave().ElementAt(intervals.GetChromaticIndex(degree));

        public static Chord GetTriadChord(this IEnumerable<Interval> intervals, Intonation root, Degree degree)
        {
            var offsetRoot = intervals.GetIntonation(root, degree);
            var offsetIntervals = intervals.GetOffset(degree);

            return new Chord(offsetRoot, Chord.ChordComplexity.Triad, offsetIntervals);
        }

        public static Chord GetSeventhChord(this IEnumerable<Interval> intervals, Intonation root, Degree degree)
        {
            var offsetRoot = intervals.GetIntonation(root, degree);
            var offsetIntervals = intervals.GetOffset(degree);

            return new Chord(offsetRoot, Chord.ChordComplexity.Seventh, offsetIntervals);
        }
    }
}










