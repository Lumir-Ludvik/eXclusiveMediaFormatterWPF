using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eXclusiveMediaFormatter.Formats.wav
{
    static class WavConstants
    {
        public const uint CHUNKID = 4;
        public const uint CHUNKSIZE = 8;
        public const uint FORMAT = 12;
        public const uint SUBCHUNK1ID = 16;
        public const uint SUBCHUNK1SIZE = 20;
        public const uint AUDIOFORMAT = 22;
        public const uint NUMCHANNELS = 24;
        public const uint SAMPLERATE = 28;
        public const uint BYTERATE = 32;
        public const uint BLOCKALIGN = 34;
        public const uint BITSPERSAMPLE = 36;
        public const uint SUBCHUNK2ID = 40;
        public const uint SUBCHUNK2SIZE = 44;
    }
}
