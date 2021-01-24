using System;
using System.Collections.Generic;
using Synonms.Musiq.Domain.Enumerations;

namespace Synonms.Musiq.UI.Blazor.Components
{
    public partial class Keyboard
    {
        private const string HiddenClass = "hidden";
        private const string ChordClass = "chord";
        private const string ScaleClass = "scale";

        public Keyboard()
        {
            ResetMarkers();
        }

        public Dictionary<Intonation, string> MarkerClasses { get; private set; }

        public void Refresh()
        {
            StateHasChanged();
        }

        public void SetScaleMarkers(IEnumerable<Intonation> intonations)
        {
            foreach (var intonation in intonations)
            {
                MarkerClasses[intonation] = ScaleClass;
            }
        }

        public void SetChordMarkers(IEnumerable<Intonation> intonations)
        {
            foreach (var intonation in intonations)
            {
                MarkerClasses[intonation] = ChordClass;
            }
        }

        public void ResetMarkers()
        {
            if (MarkerClasses is null)
            {
                MarkerClasses = new Dictionary<Intonation, string>();
            }

            foreach (Intonation intonation in Enum.GetValues(typeof(Intonation)))
            {
                if (!MarkerClasses.ContainsKey(intonation))
                {
                    MarkerClasses.Add(intonation, HiddenClass);
                }

                MarkerClasses[intonation] = HiddenClass;
            }
        }
    }
}
