using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eXclusiveMediaFormatter.Formats.wav
{
    class WavService : IWav
    {
        public Wav ReturnFormatData(byte[] rawData)
        {
            var wav = new Wav();
            var tmp = new List<byte>();
            uint fileSize = (uint)rawData.Length;

            for (uint i = 0; i < fileSize; i++)
            {
                tmp.Add(rawData[i]);

                switch(i + 1)
                {
                    case WavConstants.CHUNKID:
                        wav.ChunkID = tmp.ToArray();
                        tmp.Clear();
                        break;
                    case WavConstants.CHUNKSIZE:
                        wav.ChunkSize = tmp.ToArray();
                        tmp.Clear();
                        break;
                    case WavConstants.FORMAT:
                        wav.format = tmp.ToArray();
                        tmp.Clear();
                        break;
                    case WavConstants.SUBCHUNK1ID:
                        wav.subchunk1ID = tmp.ToArray();
                        tmp.Clear();
                        break;
                    case WavConstants.SUBCHUNK1SIZE:
                        wav.subchunk1Size = tmp.ToArray();
                        tmp.Clear();
                        break;
                    case WavConstants.AUDIOFORMAT:
                        wav.audioFormat = tmp.ToArray();
                        tmp.Clear();
                        break;
                    case WavConstants.NUMCHANNELS:
                        wav.numChannels = tmp.ToArray();
                        tmp.Clear();
                        break;
                    case WavConstants.SAMPLERATE:
                        wav.sampleRate = tmp.ToArray();
                        tmp.Clear();
                        break;
                    case WavConstants.BYTERATE:
                        wav.byteRate = tmp.ToArray();
                        tmp.Clear();
                        break;
                    case WavConstants.BLOCKALIGN:
                        wav.blockAlign = tmp.ToArray();
                        tmp.Clear();
                        break;
                    case WavConstants.BITSPERSAMPLE:
                        wav.bitsPerSample = tmp.ToArray();
                        tmp.Clear();
                        break;
                    case WavConstants.SUBCHUNK2ID:
                        wav.subchunk2ID = tmp.ToArray();
                        tmp.Clear();
                        break;
                    case WavConstants.SUBCHUNK2SIZE:
                        wav.subchunk2Size = tmp.ToArray();
                        tmp.Clear();
                        break;
                }
            }
            wav.data = tmp.ToArray();
            return wav;
        }
    }
}
