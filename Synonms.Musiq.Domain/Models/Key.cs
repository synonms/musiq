using System.Collections.Generic;
using System.Linq;
using System.Text;
using Synonms.Musiq.Domain.Enumerations;
using Synonms.Musiq.Domain.Extensions;

namespace Synonms.Musiq.Domain
{
    public class Key
    {
        public Key(Intonation root, Scale scale, IDictionary<Degree, Mode> modes)
        {
            Root = root;
            Scale = scale;
            Modes = modes;
        }

        public string Name => $"{Root} {Scale}";

        public Intonation Root { get; set; }

        public Scale Scale { get; set; }

        public IDictionary<Degree, Mode> Modes { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(Name);

            foreach (var (degree, mode) in Modes)
            {
                var modeIntonations = mode.Intervals.GetIntonations(Root);

                builder.AppendLine($"{degree} - {mode.Name}");

                WriteNote(builder, modeIntonations.ElementAt(0));
                WriteNote(builder, modeIntonations.ElementAt(1));
                WriteNote(builder, modeIntonations.ElementAt(2));
                WriteNote(builder, modeIntonations.ElementAt(3));
                WriteNote(builder, modeIntonations.ElementAt(4));
                WriteNote(builder, modeIntonations.ElementAt(5));
                WriteNote(builder, modeIntonations.ElementAt(6));
                builder.Append("\r\n");
                WriteTriad(builder, mode, Degree.I);
                WriteTriad(builder, mode, Degree.II);
                WriteTriad(builder, mode, Degree.III);
                WriteTriad(builder, mode, Degree.IV);
                WriteTriad(builder, mode, Degree.V);
                WriteTriad(builder, mode, Degree.VI);
                WriteTriad(builder, mode, Degree.VII);
                builder.Append("\r\n");
                WriteSeventh(builder, mode, Degree.I);
                WriteSeventh(builder, mode, Degree.II);
                WriteSeventh(builder, mode, Degree.III);
                WriteSeventh(builder, mode, Degree.IV);
                WriteSeventh(builder, mode, Degree.V);
                WriteSeventh(builder, mode, Degree.VI);
                WriteSeventh(builder, mode, Degree.VII);
                builder.Append("\r\n");
            }

            return builder.ToString();
        }

        private void WriteNote(StringBuilder builder, Intonation intonation)
        {
            builder.Append($"{intonation}".PadRight(20));
        }

        private void WriteTriad(StringBuilder builder, Mode mode, Degree degree)
        {
            var chord = mode.Intervals.GetTriadChord(Root, degree);
            builder.Append($"{chord}".PadRight(20));
        }

        private void WriteSeventh(StringBuilder builder, Mode mode, Degree degree)
        {
            var chord = mode.Intervals.GetSeventhChord(Root, degree);
            builder.Append($"{chord}".PadRight(20));
        }
    }
}
