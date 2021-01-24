using System.Collections.Generic;
using Synonms.Musiq.Domain.Enumerations;

namespace Synonms.Musiq.Domain
{
    public static class ModeBuilder
    {
        public static IDictionary<Degree, Mode> Create(Scale scale)
        {
            switch (scale)
            {
                case Scale.Major: return CreateMajor();
                case Scale.HarmonicMajor: return CreateHarmonicMajor();
                case Scale.MelodicMinor: return CreateMelodicMinor();
                case Scale.HarmonicMinor: return CreateHarmonicMinor();
                default: return new Dictionary<Degree, Mode>();
            }
        }

        public static IDictionary<Degree, Mode> CreateMajor() =>
            new Dictionary<Degree, Mode>
            {
                {
                    Degree.I,
                    new Mode(
                        "Ionian",
                        Voicing.Major7,
                        new [] {
                            Interval.WholeStep,
                            Interval.WholeStep,
                            Interval.HalfStep,
                            Interval.WholeStep,
                            Interval.WholeStep,
                            Interval.WholeStep,
                            Interval.HalfStep
                        }
                    )
                },
                {
                    Degree.II,
                    new Mode(
                        "Dorian",
                        Voicing.Minor7,
                        new [] {
                            Interval.WholeStep,
                            Interval.HalfStep,
                            Interval.WholeStep,
                            Interval.WholeStep,
                            Interval.WholeStep,
                            Interval.HalfStep,
                            Interval.WholeStep
                        }
                    )
                },
                {
                    Degree.III,
                    new Mode(
                        "Phrygian",
                        Voicing.Minor7,
                        new [] {
                            Interval.HalfStep,
                            Interval.WholeStep,
                            Interval.WholeStep,
                            Interval.WholeStep,
                            Interval.HalfStep,
                            Interval.WholeStep,
                            Interval.WholeStep
                        }
                    )
                },
                {
                    Degree.IV,
                    new Mode(
                        "Lydian",
                        Voicing.Major7,
                        new [] {
                            Interval.WholeStep,
                            Interval.WholeStep,
                            Interval.WholeStep,
                            Interval.HalfStep,
                            Interval.WholeStep,
                            Interval.WholeStep,
                            Interval.HalfStep
                        }
                    )
                },
                {
                    Degree.V,
                    new Mode(
                        "Mixolydian",
                        Voicing.Dominant7,
                        new [] {
                            Interval.WholeStep,
                            Interval.WholeStep,
                            Interval.HalfStep,
                            Interval.WholeStep,
                            Interval.WholeStep,
                            Interval.HalfStep,
                            Interval.WholeStep
                        }
                    )
                },
                {
                    Degree.VI,
                    new Mode(
                        "Aeolian (nat. minor)",
                        Voicing.Minor7,
                        new [] {
                            Interval.WholeStep,
                            Interval.HalfStep,
                            Interval.WholeStep,
                            Interval.WholeStep,
                            Interval.HalfStep,
                            Interval.WholeStep,
                            Interval.WholeStep
                        }
                    )
                },
                {
                    Degree.VII,
                    new Mode(
                        "Locrian",
                        Voicing.Minor7b5,
                        new [] {
                            Interval.HalfStep,
                            Interval.WholeStep,
                            Interval.WholeStep,
                            Interval.HalfStep,
                            Interval.WholeStep,
                            Interval.WholeStep,
                            Interval.WholeStep
                        }
                    )
                }
            };

        public static IDictionary<Degree, Mode> CreateHarmonicMajor() =>
                new Dictionary<Degree, Mode>
                {
                    {
                        Degree.I,
                            new Mode(
                                "Harmonic Major",
                                Voicing.Major7,
                                new [] {
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeHalfStep,
                                    Interval.HalfStep
                                }
                            )
                    },
                    {
                        Degree.II,
                            new Mode(
                                "Dorian b5",
                                Voicing.Minor7b5,
                                new [] {
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeHalfStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep
                                }
                        )
                    },
                    {
                        Degree.III,
                            new Mode(
                                "Phrygian b4",
                                Voicing.Minor7,
                                new [] {
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeHalfStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep
                                }
                            )
                    },
                    {
                        Degree.IV,
                            new Mode(
                                "Lydian b3",
                                Voicing.MinorMaj7,
                                new [] {
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeHalfStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep
                                }
                            )
                    },
                    {
                        Degree.V,
                            new Mode(
                                "Mixolydian b2",
                                Voicing.Dominant7,
                                new [] {
                                    Interval.HalfStep,
                                    Interval.WholeHalfStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep
                                }
                            )
                    },
                    {
                        Degree.VI,
                            new Mode(
                                "Lydian Augmented #2",
                                Voicing.Major7s5,
                                new [] {
                                    Interval.WholeHalfStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep
                                }
                            )
                    },
                    {
                        Degree.VII,
                            new Mode(
                                "Locrian bb7",
                                Voicing.Diminished7,
                                new [] {
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.WholeHalfStep
                                }
                            )
                    }
                };


        public static IDictionary<Degree, Mode> CreateMelodicMinor() =>
                new Dictionary<Degree, Mode>
                {
                    {
                        Degree.I,
                            new Mode(
                                "Melodic Minor",
                                Voicing.MinorMaj7,
                                new [] {
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep
                                }
                            )
                    },
                    {
                        Degree.II,
                            new Mode(
                                "Dorian b2",
                                Voicing.Minor7,
                                new [] {
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep
                                }
                            )
                    },
                    {
                        Degree.III,
                            new Mode(
                                "Lydian Augmented",
                                Voicing.Major7s5,
                                new [] {
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep
                                }
                            )
                    },
                    {
                        Degree.IV,
                            new Mode(
                                "Lydian Dominant",
                                Voicing.Dominant7,
                                new [] {
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep
                                }
                            )
                    },
                    {
                        Degree.V,
                            new Mode(
                                "Aeolian Dominant",
                                Voicing.Dominant7,
                                new [] {
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep
                                }
                            )
                    },
                    {
                        Degree.VI,
                            new Mode(
                                "Half Diminished",
                                Voicing.Minor7b5,
                                new [] {
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep
                                }
                            )
                    },
                    {
                        Degree.VII,
                            new Mode(
                                "Alt",
                                Voicing.Minor7b5,
                                new [] {
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep
                                }
                            )
                    }
                };

        public static IDictionary<Degree, Mode> CreateHarmonicMinor() =>
                new Dictionary<Degree, Mode>
                {
                    {
                        Degree.I,
                            new Mode(
                                "Harmonic Minor",
                                Voicing.MinorMaj7,
                                new [] {
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeHalfStep,
                                    Interval.HalfStep
                                }
                            )
                    },
                    {
                        Degree.II,
                            new Mode(
                                "Locrian nat. 6",
                                Voicing.Minor7b5,
                                new [] {
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeHalfStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep
                                }
                            )
                    },
                    {
                        Degree.III,
                            new Mode(
                                "Major #5",
                                Voicing.Major7s5,
                                new [] {
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeHalfStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep
                                }
                            )
                    },
                    {
                        Degree.IV,
                            new Mode(
                                "Dorian #4",
                                Voicing.Minor7,
                                new [] {
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeHalfStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep
                                }
                            )
                    },
                    {
                        Degree.V,
                            new Mode(
                                "Phrygian Dominant",
                                Voicing.Dominant7,
                                new [] {
                                    Interval.HalfStep,
                                    Interval.WholeHalfStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep
                                }
                            )
                    },
                    {
                        Degree.VI,
                            new Mode(
                                "Lydian #2",
                                Voicing.Major7,
                                new [] {
                                    Interval.WholeHalfStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep
                                }
                            )
                    },
                    {
                        Degree.VII,
                            new Mode(
                                "Alt Dominant bb7",
                                Voicing.Diminished7,
                                new [] {
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeStep,
                                    Interval.WholeStep,
                                    Interval.HalfStep,
                                    Interval.WholeHalfStep
                                }
                            )
                    }
                };
    }
}
