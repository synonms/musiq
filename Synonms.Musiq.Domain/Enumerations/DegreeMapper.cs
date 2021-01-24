namespace Synonms.Musiq.Domain.Enumerations
{
    public static class DegreeMapper
    {
        public static Degree From(int value)
        {
            switch (value)
            {
                case 1: return Degree.I;
                case 2: return Degree.II;
                case 3: return Degree.III;
                case 4: return Degree.IV;
                case 5: return Degree.V;
                case 6: return Degree.VI;
                case 7: return Degree.VII;
                default: return Degree.Unknown;
            }
        }
    }
}
