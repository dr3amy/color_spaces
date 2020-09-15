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
		private int _minDiff = int.MaxValue;

		public GrayscaleConverter(Bitmap originalImage) 
		{
			_originalImage = originalImage;
		}

		public void ConvertToGrayscale()
		{
			var pal = new Bitmap(_originalImage.Width, _originalImage.Height);
			var hdtv = new Bitmap(_originalImage.Width, _originalImage.Height);
			var palIntensity = new int[256];
			var hdTvIntensity = new int[256];
			for (var x = 0; x < _originalImage.Width; x++)
			{
				for (var y = 0; y < _originalImage.Height; y++)
				{
					var currentPixelColor = _originalImage.GetPixel(x, y);

					var hdTvValue = Convert.ToInt32(0.2126 * currentPixelColor.R + 0.7152 * currentPixelColor.G + 0.0722 * currentPixelColor.B);
					var palValue = Convert.ToInt32(0.299 * currentPixelColor.R + 0.587 * currentPixelColor.G + 0.114 * currentPixelColor.B);
					var diff = palValue - hdTvValue;
					_minDiff = Math.Min(diff, _minDiff); 
					
					palIntensity[palValue]++;
					hdTvIntensity[hdTvValue]++;

					hdtv.SetPixel(x, y, Color.FromArgb(hdTvValue, hdTvValue, hdTvValue));
					pal.SetPixel(x, y, Color.FromArgb(palValue, palValue, palValue));
				}
			}
			_hdtvBitmap = hdtv;
			_palBitmap = pal;
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
			if (_diffBitmap == null)
			{
				_diffBitmap = CalcDiff();
			}

			return _diffBitmap;
		}

		private Bitmap CalcDiff()
		{
			var diffImage = new Bitmap(_originalImage.Width, _originalImage.Height);
			for (var x = 0; x < _originalImage.Width; x++)
			{
				for (var y = 0; y < _originalImage.Height; y++)
				{
					var palValue = _palBitmap.GetPixel(x, y).R;
					var hdtvValue = _hdtvBitmap.GetPixel(x, y).R;
					var diff = palValue - hdtvValue - _minDiff;
					diffImage.SetPixel(x, y, Color.FromArgb(diff, diff, diff));
				}
			}

			return diffImage;
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