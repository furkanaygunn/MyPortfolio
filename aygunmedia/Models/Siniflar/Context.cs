﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aygunmedia.Models.Siniflar
{
	public class Context : DbContext
	{
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<ikonlar> ikonlars { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}