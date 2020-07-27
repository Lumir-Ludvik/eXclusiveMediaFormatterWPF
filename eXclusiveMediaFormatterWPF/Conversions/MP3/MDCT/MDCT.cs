using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eXclusiveMediaFormatterWPF.Conversions.MP3.MDCT
{
    class MDCT
    {
		/* 
	 * Computes the unscaled DCT type II on the specified array, returning a new array.
	 * The array length can be any value, starting from zero. The returned array has the same length.
	 * For the formula, see https://en.wikipedia.org/wiki/Discrete_cosine_transform#DCT-II .
	 */
		public static double[] Transform(double[] vector)
		{
			if (vector == null)
				throw new NullReferenceException();
			double[] result = new double[vector.Length];
			double factor = Math.PI / vector.Length;
			for (int i = 0; i < vector.Length; i++)
			{
				double sum = 0;
				for (int j = 0; j < vector.Length; j++)
					sum += vector[j] * Math.Cos((j + 0.5) * i * factor);
				result[i] = sum;
			}
			return result;
		}


		/* 
		 * Computes the unscaled DCT type III on the specified array, returning a new array.
		 * The array length can be any value, starting from zero. The returned array has the same length.
		 * For the formula, see https://en.wikipedia.org/wiki/Discrete_cosine_transform#DCT-III .
		 */
		public static double[] InverseTransform(double[] vector)
		{
			if (vector == null)
				throw new NullReferenceException();
			double[] result = new double[vector.Length];
			double factor = Math.PI / vector.Length;
			for (int i = 0; i < vector.Length; i++)
			{
				double sum = vector[0] / 2;
				for (int j = 1; j < vector.Length; j++)
					sum += vector[j] * Math.Cos(j * (i + 0.5) * factor);
				result[i] = sum;
			}
			return result;
		}

	}
}
