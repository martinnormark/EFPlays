﻿using System;

namespace EFPlays.Model
{
	public class User
	{
		public int Id { get; set; }

		public string EMail { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string PhoneNumber { get; set; }

		public DateTime DateOfBirth { get; set; }
	}
}