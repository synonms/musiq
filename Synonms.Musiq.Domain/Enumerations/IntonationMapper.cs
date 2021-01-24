namespace Synonms.Musiq.Domain.Enumerations
{
    public static class IntonationMapper
    {
        public static Intonation From(int value)
        {
            switch (value)
            {
                case 1: return Intonation.A;
                case 2: return Intonation.AsBb;
                case 3: return Intonation.B;
                case 4: return Intonation.C;
                case 5: return Intonation.CsDb;
                case 6: return Intonation.D;
                case 7: return Intonation.DsEb;
                case 8: return Intonation.E;
                case 9: return Intonation.F;
                case 10: return Intonation.FsGb;
                case 11: return Intonation.G;
                case 12: return Intonation.GsAb;
                default: return Intonation.Unknown;
            }
        }
    }
}
