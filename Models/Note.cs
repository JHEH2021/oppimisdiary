using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oppimispäiväkirja_versio1.Models
{
    public class Note 
    {
        public int Id { get; set; }
        public string NoteText { get; set; }
        public Topic Topic { get; set; }
        

        public Note()
        {

        }

       
        public Note(int id, string noteText, Topic topic)
        {
            Id = id;
            NoteText = noteText;
            Topic = topic;
        }

        public Note(Topic topic)
        {
            Topic = topic;
        }

       
    }
  

  
}
