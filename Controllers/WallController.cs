using Catstagram.Data;
using Catstagram.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catstagram.Controllers
{
    public class WallController : Controller
    {
        private readonly AppDbContext _context;
        public WallController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Posts.ToList();
            return View(data);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Image,AuthorName,AuthorEmail,Comments,DateAdded")] Post post)
        {
            if (!ModelState.IsValid)
            {
                return View(post);
            }

            post.DateAdded = DateTime.Now;
            post.ExtractHashtags();


            _context.Posts.Add(post);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));

        }


        public IActionResult FilterByHashtag(string hashtag)
        {
            var filteredPosts = _context.Posts.Where(p => p.Comments.Contains(hashtag)).ToList();
            ViewBag.Hashtag = hashtag;
            return View(filteredPosts);
        }

    }
}
