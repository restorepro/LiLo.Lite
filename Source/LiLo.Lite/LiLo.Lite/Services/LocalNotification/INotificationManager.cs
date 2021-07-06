﻿// <copyright file="INotificationManager.cs" company="InternetWideWorld.com">
// Copyright (c) George Leithead, InternetWideWorld.com
// </copyright>

namespace LiLo.Lite.Services.LocalNotification
{
	using System;

	/// <summary>Local Notification manager interface.</summary>
	public interface INotificationManager
	{
		/// <summary>Notification received event.</summary>
		event EventHandler NotificationReceived;

		/// <summary>Initialise notification manager.</summary>
		void Initialize();

		/// <summary>Receive notification.</summary>
		/// <param name="title">Title.</param>
		/// <param name="message">Message.</param>
		void ReceiveNotification(string title, string message);

		/// <summary>Send notification.</summary>
		/// <param name="title">Title.</param>
		/// <param name="message">Message.</param>
		/// <param name="notifyTime">Notification date and time.</param>
		void SendNotification(string title, string message, DateTime? notifyTime = null);
	}
}