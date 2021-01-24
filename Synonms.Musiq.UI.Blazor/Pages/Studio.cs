using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Synonms.Musiq.Domain;
using Synonms.Musiq.Domain.Enumerations;
using Synonms.Musiq.Domain.Extensions;
using Synonms.Musiq.UI.Blazor.Components;

namespace Synonms.Musiq.UI.Blazor.Pages
{
    public class Selection
    {
        [Required]
        public Intonation? Root { get; set; }

        [Required]
        public Scale? Scale { get; set; }

        public Key Key { get; private set; }

        public Degree? SelectedDegree { get; set; }

        public void Update()
        {
            if (Root is null) return;
            if (Scale is null) return;

            Key = new Key(Root.Value, Scale.Value, ModeBuilder.Create(Scale.Value));
        }
    }

    public partial class Studio
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        public Studio()
        {
            InitialiseIntonations();
            InitialiseScales();
        }

        public List<Intonation> Intonations { get; set; }

        public List<Scale> Scales { get; set; }

        public Keyboard Keyboard { get; set; }

        public string SelectionMessage { get; set; } = "Make selection";

        public Selection Selection { get; set; } = new Selection();

        protected void SelectMode(Degree degree)
        {
            Selection.SelectedDegree = degree;

            Keyboard.ResetMarkers();
            Keyboard.SetScaleMarkers(Selection.Key.Modes[degree].GetIntonations(Selection.Key.Root));
            Keyboard.Refresh();

            //            StateHasChanged();
        }

        protected void PlayChord(Chord chord)
        {
            var octaveOffset = 4;
            var octave = 0;
            var durationInSeconds = 2;

            var noteTasks = new List<Task>();

            for (var noteIndex = 0; noteIndex < chord.Intonations.Count(); ++noteIndex)
            {
                var note = chord.Intonations.ElementAt(noteIndex).ToAudioSynthString();
                noteTasks.Add(JSRuntime.InvokeVoidAsync("playNote", 0, note, octave + octaveOffset, durationInSeconds).AsTask());
            }

            Task.WaitAll(noteTasks.ToArray(), CancellationToken.None);
        }

        protected Task HandleValidSubmitAsync()
        {
            Selection.Update();

            SelectionMessage = Selection.Key.ToString();

            return Task.CompletedTask;
        }

        protected Task HandleInvalidSubmitAsync()
        {
            SelectionMessage = "Make selection";

            return Task.CompletedTask;
        }

        private void InitialiseIntonations()
        {
            Intonations = new List<Intonation>
            {
                Intonation.A,
                Intonation.AsBb,
                Intonation.B,
                Intonation.C,
                Intonation.CsDb,
                Intonation.D,
                Intonation.DsEb,
                Intonation.E,
                Intonation.F,
                Intonation.FsGb,
                Intonation.G,
                Intonation.GsAb
            };
        }

        private void InitialiseScales()
        {
            Scales = new List<Scale>
            {
                Scale.Major,
                Scale.HarmonicMajor,
                Scale.MelodicMinor,
                Scale.HarmonicMinor
            };
        }
    }
}
