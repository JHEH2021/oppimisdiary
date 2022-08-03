using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oppimispäiväkirja_versio1.Models;

    public class Oppimispäiväkirja_versio1Context : DbContext
    {
        public Oppimispäiväkirja_versio1Context (DbContextOptions<Oppimispäiväkirja_versio1Context> options)
            : base(options)
        {
        }

        public DbSet<Oppimispäiväkirja_versio1.Models.Topic> Topic { get; set; }

        public DbSet<Oppimispäiväkirja_versio1.Models.Note> Note { get; set; }

        public DbSet<Oppimispäiväkirja_versio1.Models.ToDo> ToDo { get; set; }

        
    }
