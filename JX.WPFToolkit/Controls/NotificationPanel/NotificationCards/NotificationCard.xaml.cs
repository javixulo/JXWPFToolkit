﻿using System.Windows;

namespace JX.WPFToolkit.Controls.NotificationPanel.NotificationCards
{
	public partial class NotificationCard : NotificationCardBase
	{
		public static readonly DependencyProperty CardContentProperty = DependencyProperty.Register("CardContent", typeof(string), typeof(NotificationCard));

		public string CardContent
		{
			get { return (string)GetValue(CardContentProperty); }
			set { SetValue(CardContentProperty, value); }
		}

		public NotificationCard()
		{
			InitializeComponent();
		}
	}
}
