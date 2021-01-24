namespace Synonms.Musiq.Domain.Enumerations
{
    public static class ScaleMapper
    {
        public static Scale From(int value)
        {
            switch (value)
            {
                case 1: return Scale.Major;
                case 2: return Scale.HarmonicMajor;
                case 3: return Scale.MelodicMinor;
                case 4: return Scale.HarmonicMinor;
                default: return Scale.Unknown;
            }
        }
    }
}
