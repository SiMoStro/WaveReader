using System.IO;

namespace WaveReader
{
    public class WaveFileFormat
    {
        public string WaveID; // "WAVE"

        internal void Read(BinaryReader br)
        {
            WaveID = new string(br.ReadChars(4));
        }
    }
}
