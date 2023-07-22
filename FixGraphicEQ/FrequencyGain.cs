namespace FixGraphicEQ;

// Class to store frequency and gain values, simplest way I could think of to store an int with a float
public class FrequencyGain {
    public FrequencyGain(int frequency, float gain) {
        Frequency = frequency;
        Gain = gain;
    }

    public int Frequency { get; set; }
    public float Gain { get; set; }
}