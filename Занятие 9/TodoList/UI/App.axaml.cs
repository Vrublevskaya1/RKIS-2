﻿using Avalonia;

namespace TodoList.UI
{
	public partial class App : Application
	{
		public override void OnFrameworkInitializationCompleted()
		{
			new MainWindow().Show();
			base.OnFrameworkInitializationCompleted();
		}
	}
}