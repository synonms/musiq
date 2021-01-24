using System.Collections.Generic;
using System.Linq;
using Synonms.Musiq.Domain.Enumerations;

namespace Synonms.Musiq.Domain.Extensions
{
    public static class IntonationExtensions
    {
        public static string ToPrettyString(this Intonation intonation)
        {
            switch (intonation)
            {
                case Intonation.A: return "A";
                case Intonation.AsBb: return "A#/Bb";
                case Intonation.B: return "B";
                case Intonation.C: return "C";
                case Intonation.CsDb: return "C#/Db";
                case Intonation.D: return "D";
                case Intonation.DsEb: return "D#/Eb";
                case Intonation.E: return "E";
                case Intonation.F: return "F";
                case Intonation.FsGb: return "F#/Gb";
                case Intonation.G: return "G";
                case Intonation.GsAb: return "G#/Ab";
                default: return "Unknown";
            }
        }

        public static string ToAudioSynthString(this Intonation intonation)
        {
            switch (intonation)
            {
                case Intonation.A: return "A";
                case Intonation.AsBb: return "A#";
                case Intonation.B: return "B";
                case Intonation.C: return "C";
                case Intonation.CsDb: return "C#";
                case Intonation.D: return "D";
                case Intonation.DsEb: return "D#";
                case Intonation.E: return "E";
                case Intonation.F: return "F";
                case Intonation.FsGb: return "F#";
                case Intonation.G: return "G";
                case Intonation.GsAb: return "G#";
                default: return "";
            }
        }

        public static IEnumerable<Intonation> GetChromaticOctave(this Intonation root)
        {
            var results = new List<Intonation>();

            for (var i = (int)root; i <= 12; i++)
            {
                results.Add((Intonation)i);
            }

            for (var i = 1; i < (int)root; i++)
            {
                results.Add((Intonation)i);
            }

            return results;
        }

        public static Intonation GetIntonation(this IEnumerable<Intonation> intonations, Degree degree) =>
            intonations.ElementAt((int)degree - 1);
    }
}
