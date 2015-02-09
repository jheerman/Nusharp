﻿using System.Configuration;
namespace Nusharp.Core
{
	public class Config
	{
		public static string PackageRepositoryPath { get; set; }
		public static string Uri { get; set; }
		public static string Username { get; set; }
		public static string Password { get; set; }
		public static int Port { get; set; }

		public static void LoadFromAppSettings()
		{
			PackageRepositoryPath = ConfigurationManager.AppSettings["packageRepositoryPath"];
			Uri = ConfigurationManager.AppSettings["uri"];
			Port = int.Parse(ConfigurationManager.AppSettings["port"] ?? "1338");

			Username = ConfigurationManager.AppSettings["username"];
			Password = ConfigurationManager.AppSettings["password"];
		}
	}
}
