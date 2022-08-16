using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oppimispäiväkirja_versio1.Models
{
	public class Topic
	{ 
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public double? EstimatedTimeToMaster { get; set; }
		public double? TimeSpent { get; set; }
		public string Source { get; set; }
		public DateTime? StartLearningDate { get; set; }
		public bool InProgress { get; set; }
		public DateTime? CompletionDate { get; set; }


		public Topic()
        {

        }
	}
	
}
