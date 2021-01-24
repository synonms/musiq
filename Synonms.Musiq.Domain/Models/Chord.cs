using System.Collections.Generic;
using System.Linq;
using Synonms.Musiq.Domain.Enumerations;
using Synonms.Musiq.Domain.Extensions;

namespace Synonms.Musiq.Domain
{
    public class Chord
    {
        private List<Interval> _intervals;

        public enum ChordComplexity
        {
            Triad,
            Seventh
        }

        public enum ChordType
        {
            Unknown = 0,
            MinorTriad,
            MajorTriad,
            AugmentedTriad,
            DiminishedTriad,
            MinorSeventh,
            MinorMajorSeventh,
            DiminishedSeventh,
            HalfDiminishedSeventh,
            DominantSeventh,
            MajorSeventh,
            AugmentedMajorSeventh,
            AugmentedSeventh
        }

        public Chord(Intonation root, ChordComplexity complexity, IEnumerable<Interval> intervals)
        {
            Root = root;
            _intervals = intervals.ToList();

            var octave = root.GetChromaticOctave().ToList();

            switch (complexity)
            {
                case ChordComplexity.Triad:
                    Intonations = new List<Intonation>
                    {
                        root,
                        octave[_intervals.GetChromaticIndex(Degree.III)],
                        octave[_intervals.GetChromaticIndex(Degree.V)]
                    };
                    Type = GetTriadType();
                    break;
                case ChordComplexity.Seventh:
                    Intonations = new List<Intonation>
                    {
                        root,
                        octave[_intervals.GetChromaticIndex(Degree.III)],
                        octave[_intervals.GetChromaticIndex(Degree.V)],
                        octave[_intervals.GetChromaticIndex(Degree.VII)]
                    };
                    Type = GetSeventhType();
                    break;
            }
        }

        public Intonation Root { get; set; }

        public ChordComplexity Complexity { get; set; }

        public ChordType Type { get; private set; }

        public IEnumerable<Intonation> Intonations { get; private set; }

        public override string ToString()
        {
            return $"{Root}{Type} [{string.Join(',', Intonations)}]";
        }

        private ChordType GetTriadType()
        {
            if (_intervals.GetComponentInterval(Degree.III) == ComponentInterval.MinorThird)
            {
                if (_intervals.GetComponentInterval(Degree.V) == ComponentInterval.PerfectFifth)
                {
                    return ChordType.MinorTriad;
                }
                else if (_intervals.GetComponentInterval(Degree.V) == ComponentInterval.DiminishedFifth)
                {
                    return ChordType.DiminishedTriad;
                }
            }
            else if (_intervals.GetComponentInterval(Degree.III) == ComponentInterval.MajorThird)
            {
                if (_intervals.GetComponentInterval(Degree.V) == ComponentInterval.PerfectFifth)
                {
                    return ChordType.MajorTriad;
                }
                else if (_intervals.GetComponentInterval(Degree.V) == ComponentInterval.AugmentedFifth)
                {
                    return ChordType.AugmentedTriad;
                }
            }

            return ChordType.Unknown;
        }

        private ChordType GetSeventhType()
        {
            if (_intervals.GetComponentInterval(Degree.III) == ComponentInterval.MinorThird)
            {
                if (_intervals.GetComponentInterval(Degree.V) == ComponentInterval.PerfectFifth)
                {
                    if (_intervals.GetComponentInterval(Degree.VII) == ComponentInterval.MinorSeventh)
                    {
                        return ChordType.MinorSeventh;
                    }
                    else if (_intervals.GetComponentInterval(Degree.VII) == ComponentInterval.MajorSeventh)
                    {
                        return ChordType.MinorMajorSeventh;
                    }
                }
                else if (_intervals.GetComponentInterval(Degree.V) == ComponentInterval.DiminishedFifth)
                {
                    if (_intervals.GetComponentInterval(Degree.VII) == ComponentInterval.DiminishedSeventh)
                    {
                        return ChordType.DiminishedSeventh;
                    }
                    else if (_intervals.GetComponentInterval(Degree.VII) == ComponentInterval.MinorSeventh)
                    {
                        return ChordType.HalfDiminishedSeventh;
                    }
                }
            }
            else if (_intervals.GetComponentInterval(Degree.III) == ComponentInterval.MajorThird)
            {
                if (_intervals.GetComponentInterval(Degree.V) == ComponentInterval.PerfectFifth)
                {
                    if (_intervals.GetComponentInterval(Degree.VII) == ComponentInterval.MinorSeventh)
                    {
                        return ChordType.DominantSeventh;
                    }
                    else if (_intervals.GetComponentInterval(Degree.VII) == ComponentInterval.MajorSeventh)
                    {
                        return ChordType.MajorSeventh;
                    }
                }
                else if (_intervals.GetComponentInterval(Degree.V) == ComponentInterval.AugmentedFifth)
                {
                    if (_intervals.GetComponentInterval(Degree.VII) == ComponentInterval.MajorSeventh)
                    {
                        return ChordType.AugmentedMajorSeventh;
                    }
                    else if (_intervals.GetComponentInterval(Degree.VII) == ComponentInterval.MinorSeventh)
                    {
                        return ChordType.AugmentedSeventh;
                    }
                }
            }

            return ChordType.Unknown;
        }
    }
}
