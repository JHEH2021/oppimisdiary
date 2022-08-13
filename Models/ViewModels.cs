using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oppimispäiväkirja_versio1.Models
{
    public class ViewModels
    {
        [NotMapped] public List<Topic> Topics { get; set; }
        [NotMapped] public List<Note> Notes { get; set; }
        [NotMapped] public Topic Topic { get; set; }
        [NotMapped] public Note Note { get; set; }
    }
}
