﻿using DC.Models;

namespace DC.DTO.RequestDTO
{
	public class PostRequestDto
	{
		public long Id { get; set; }

		public long IssueId { get; set; }

		public string Content { get; set; }
	}
}
