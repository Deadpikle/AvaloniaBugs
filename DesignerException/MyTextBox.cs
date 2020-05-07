using Avalonia.Controls;
using Avalonia.Styling;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignerException
{
	class MyTextBox : TextBox, IStyleable
	{
		Type IStyleable.StyleKey => typeof(TextBox);

	}
}
