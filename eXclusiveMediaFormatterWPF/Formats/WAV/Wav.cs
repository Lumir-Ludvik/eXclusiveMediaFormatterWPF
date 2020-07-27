using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eXclusiveMediaFormatter.Formats.wav
{
    class Wav
    {
        public byte[] ChunkID { get; set; }
        public byte[] ChunkSize { get; set; }
        public byte[] format { get; set; }
        public byte[] subchunk1ID { get; set; }
        public byte[] subchunk1Size { get; set; }
        public byte[] audioFormat { get; set; }
        public byte[] numChannels { get; set; }
        public byte[] sampleRate { get; set; }
        public byte[] byteRate { get; set; }
        public byte[] blockAlign { get; set; }
        public byte[] bitsPerSample { get; set; }
        public byte[] subchunk2ID { get; set; }
        public byte[] subchunk2Size { get; set; }
        public byte[] data { get; set; }
    }
}
