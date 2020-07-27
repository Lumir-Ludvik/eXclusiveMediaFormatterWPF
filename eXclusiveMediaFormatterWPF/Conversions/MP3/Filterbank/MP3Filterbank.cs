using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using eXclusiveMediaFormatter.Formats.wav;

namespace eXclusiveMediaFormatter.Conversions.MP3.Filterbank
{
    class MP3Filterbank
    {
        public Wav ReadFile(string path)
        {
            if(File.Exists(path))
            {
                var file = File.ReadAllBytes(path);
                var formatData = new WavService().ReturnFormatData(file);
                return formatData;
            }
            return null;
        }
    }
}
