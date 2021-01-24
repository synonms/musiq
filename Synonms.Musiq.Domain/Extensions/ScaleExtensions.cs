using Synonms.Musiq.Domain.Enumerations;

namespace Synonms.Musiq.Domain.Extensions
{
    public static class ScaleExtensions
    {
        public static string ToString(this Scale scale)
        {
            switch (scale)
            {
                case Scale.Major: return "Major";
                case Scale.HarmonicMajor: return "Harmonic Major";
                case Scale.MelodicMinor: return "Melodic Minor";
                case Scale.HarmonicMinor: return "Harmonic Minor";
                default: return "Unknown";
            }
        }
    }
}
