﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	public class ScienceExperiment : IScored
	{
		public string Hypothesis { get; set; }
		public string Materials { get; set; }
		public string Method { get; set; }
		public string Conclusion { get; set; }
		public float Score { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float MaximumScore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
