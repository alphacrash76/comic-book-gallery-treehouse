﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            ComicBook comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist { Name = "Dan Slott", Role = "Script"},
                    new Artist { Name = "Humberto Ramos", Role = "Pencils"},
                    new Artist { Name = "Victor Olazaba", Role = "Inks"},
                    new Artist { Name = "Edgar Delgado", Role = "Colors"},
                    new Artist { Name = "Chris Eliopoulos", Role = "Letters"},
                }
            };
            return View(comicBook);
        }
    }
}
