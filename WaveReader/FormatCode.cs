namespace WaveReader
{
    public enum FormatCode
    {
        Unknown = 0x0000,
        PCM = 0x0001,
        PCM_Compressed = 0x0002,
        IEEE = 0x0003,
        ALaw = 0x0006,
        MLaw = 0x0007,
        IMA_ADPCM = 0x0011,
        ITU_G_723_ADPCM = 0x0016,
        GSM_6_10 = 0x0031,
        ITU_G_721_ADPCM = 0x0040,
        MPEG = 0x0050,
        Extensible = 0xFFFE
    }
}
