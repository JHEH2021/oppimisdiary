using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oppimispäiväkirja_versio1.Models
{
    public class Note 
    {
        [Key]
        public int Id { get; set; }
        public string NoteText { get; set; }
        public virtual int Topic { get; set;  }
        [ForeignKey("Topic")]
        public virtual Topic Topics { get; set; } //viittaa näkymään Topics

        public Note()
        {

        }

       
        //public Note(int id, string noteText, Topic topic) //tässä Topic topic databaseen/topic-olioon
        //{
        //    Id = id;
        //    NoteText = noteText;
        //    Topic = topic.Id;
        //}

        //public Note(Topic topic)
        //{
        //    Topic = topic.Id;
        //}

       
    }
  

  
}