﻿using Microsoft.Maui.Graphics;

namespace Microsoft.Maui.Controls
{
	/// <include file="../../../docs/Microsoft.Maui.Controls/ProgressBar.xml" path="Type[@FullName='Microsoft.Maui.Controls.ProgressBar']/Docs" />
	public partial class ProgressBar : IProgress
	{
		Color IProgress.ProgressColor
		{
			get => ProgressColor ??
				DefaultStyles.GetColor(this, ProgressColorProperty)?.Value as Color;
		}
	}
}