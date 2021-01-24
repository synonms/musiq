using Synonms.Musiq.Domain.Enumerations;

namespace Synonms.Musiq.Domain.Extensions
{
    public static class DegreeExtensions
    {
        public static string ToString(this Degree degree)
        {
            switch (degree)
            {
                case Degree.I: return "I";
                case Degree.II: return "II";
                case Degree.III: return "III";
                case Degree.IV: return "IV";
                case Degree.V: return "V";
                case Degree.VI: return "VI";
                case Degree.VII: return "VII";
                default: return "Unknown";
            }
        }
    }
}
