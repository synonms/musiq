using System.Collections.Generic;
using Synonms.Musiq.Domain.Enumerations;
using Synonms.Musiq.Domain.Extensions;

namespace Synonms.Musiq.Domain
{
    public class Mode
    {
        public Mode(string name, Voicing voicing, IEnumerable<Interval> intervals)
        {
            Name = name;
            Voicing = voicing;
            Intervals = intervals;
        }

        public string Name { get; set; }

        public Voicing Voicing { get; set; }

        public IEnumerable<Interval> Intervals { get; set; }

        public IEnumerable<Intonation> GetIntonations(Intonation root) =>
            Intervals.GetIntonations(root);
    }
}
