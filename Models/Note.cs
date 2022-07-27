using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oppimispäiväkirja_versio1.Models
{
    public class Note
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public string NoteText { get; set; }

        public Note()
        {

        }


    }
}
