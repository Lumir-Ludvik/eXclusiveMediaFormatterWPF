using eXclusiveMediaFormatter.Formats.wav;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace eXclusiveMediaFormatterWPF.Conversions.MP3.Quantization
{
    class Quantization
    {
        public int quantizationStepSize { get; set; }
        private Wav file { get; set; }
        private double dbl { get; set; }
        private double ln { get; set; }
        private double idx { get; set; }

        Quantization(int size, Wav file)
        {
            quantizationStepSize = size;
            this.file = file;
        }

        private void Quaintize(double xr, int ix)
        {
            double stepts = Math.Pow(2.0, (quantizationStepSize) / 4);

            for (int i = file.data.Length; i >=0; i--) //sample per frame2
            {
                dbl = Math.Abs(xr(i)) / stepts;
                ln = Math.Log(dbl);
                if(ln < 10000)
                {
                    idx = int2idx(ln);
                    if(dbl < idx2dbl(idx + 1))
                    {
                        ix(i) = idx;
                    }
                    else
                    {
                        ix(i) = idx + 1;
                    }
                }
            }
        }
    }
}
