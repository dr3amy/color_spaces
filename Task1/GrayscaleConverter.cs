using System;
using System.Drawing;

namespace color_spaces
{
    class GrayscaleConverter
    {
		private readonly Bitmap _originalImage;
		private Bitmap _palBitmap;
		private Bitmap _hdtvBitmap;
		private Bitmap _diffBitmap;
		private int[] _palIntensity;
		private int[] _hdtvIntensity;

		public GrayscaleConverter(Bitmap originalImage) 
		{
			_originalImage = originalImage;
		}

		public void ConvertToGrayscale()
		{
			var pal = new Bitmap(_originalImage.Width, _originalImage.Height);
			var hdtv = new Bitmap(_originalImage.Width, _originalImage.Height);
			var diffImage = new Bitmap(_originalImage.Width, _originalImage.Height);
			var palIntensity = new int[256];
			var hdTvIntensity = new int[256];
			for (var x = 0; x < _originalImage.Width; x++)
			{
				for (var y = 0; y < _originalImage.Height; y++)
				{
					var currentPixelColor = _originalImage.GetPixel(x, y);

					var hdTvValue = Convert.ToInt32(0.2126 * currentPixelColor.R + 0.7152 * currentPixelColor.G + 0.0722 * currentPixelColor.B);
					var palValue = Convert.ToInt32(0.299 * currentPixelColor.R + 0.587 * currentPixelColor.G + 0.114 * currentPixelColor.B);
					var diff = 255 - Math.Abs(palValue - hdTvValue);

					palIntensity[palValue]++;
					hdTvIntensity[hdTvValue]++;

					hdtv.SetPixel(x, y, Color.FromArgb(hdTvValue, hdTvValue, hdTvValue));
					pal.SetPixel(x, y, Color.FromArgb(palValue, palValue, palValue));
					diffImage.SetPixel(x, y, Color.FromArgb(diff, diff, diff));
				}
			}
			_hdtvBitmap = hdtv;
			_palBitmap = pal;
			_diffBitmap = diffImage;
			_palIntensity = palIntensity;
			_hdtvIntensity = hdTvIntensity;
		}

		public Bitmap GetPalBitmap() 
		{
			return _palBitmap;
		}

		public Bitmap GetHdTvBitmap()
		{
			return _hdtvBitmap;
		}

		public Bitmap GetDiffBitmap()
		{
			return _diffBitmap;
		}

		public int[] GetPalIntensity()
		{
			return _palIntensity;
		}

		public int[] GetHdTvIntensity()
		{
			return _hdtvIntensity;
		}

    }
}