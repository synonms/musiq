function initialiseKeyboard() {
    Synth.setVolume(0.5);
}

function playNote(soundProfile, note, octave, durationInSeconds) {
    Synth.play(soundProfile, note, octave, durationInSeconds);
}