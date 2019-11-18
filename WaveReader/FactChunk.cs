using System;
using System.IO;

namespace WaveReader
{
    public class FactChunk
    {
        public string ChunkID; // "fact"
        public Int32 ChunkSize;
        public Int32 SampleLength;

        internal void Read(BinaryReader br)
        {
            ChunkID = new string(br.ReadChars(4));
            ChunkSize = br.ReadInt32();
            SampleLength = br.ReadInt32();
        }
    }
}
