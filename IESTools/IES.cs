using System;
using System.Collections.Generic;

namespace IESTools
{
	public class IES
	{
		public SpecificationType identifier;

		public Dictionary<string, string> keywords;

		public int lampCount;
		public float lumensPerLamp;
		public float candelaMultiplier;
		public int verticalAnglesCount;
		public int horizontalAnglesCount;
		public PhotometryType photometryType;
		public Units units;
		public float sizeX;
		public float sizeY;
		public float sizeZ;

		public float ballastFactor;
		public float inputWatts;

		// 2d array of horizontal angles then vertical angles
		public AngleCandela[,] angleCandelas;

		public IES ()
		{
			keywords = new Dictionary<string, string> ();
		}
	}
}

