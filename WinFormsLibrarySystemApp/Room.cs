﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrarySystemApp
{
    public class Room
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public List<Librarian> Librarians { get; set; } = new();
    }
}
