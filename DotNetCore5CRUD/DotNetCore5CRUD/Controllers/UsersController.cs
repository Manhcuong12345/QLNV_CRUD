
using DotNetCore5CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5CRUD.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IToastNotification _toastNotification;
        private new List<string> _allowedExtenstions = new List<string> { ".jpg", ".png" };
        private long _maxAllowedPosterSize = 1048576;

        public UsersController(ApplicationDbContext context, IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;
        }


        public async Task<IActionResult> Index()
        {
            var users = await _context.User.OrderByDescending(m => m.Id).ToListAsync();
            return View(users);
        }

        public async Task<IActionResult> Create()
        {
            var viewModel = new User
            {
               // Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync()
            };

            return View("UserForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User model)
        {
            if (!ModelState.IsValid)
            {
               // model.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
                return View("UserForm", model);
            }

            var files = Request.Form.Files;

            if (!files.Any())
            {
                //model.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
                ModelState.AddModelError("Poster", "Please select movie poster!");
                return View("UserForm", model);
            }

            var poster = files.FirstOrDefault();

            if (!_allowedExtenstions.Contains(Path.GetExtension(poster.FileName).ToLower()))
            {
               // model.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
                ModelState.AddModelError("Poster", "Only .PNG, .JPG images are allowed!");
                return View("UserForm", model);
            }

            if (poster.Length > _maxAllowedPosterSize)
            {
//model.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
                ModelState.AddModelError("Poster", "Poster cannot be more than 1 MB!");
                return View("UserForm", model);
            }

            using var dataStream = new MemoryStream();

            await poster.CopyToAsync(dataStream);

            var users = new User
            {
                Title = model.Title,
                //GenreId = model.GenreId,
                Year = model.Year,
                UserName = model.UserName,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                Poster = dataStream.ToArray()
            };

            _context.User.Add(users);
            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Movie created successfully");
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return BadRequest();

            var users = await _context.User.FindAsync(id);

            if (users == null)
                return NotFound();

            var viewModel = new User
            {
                Id = users.Id,
                Title = users.Title,
                PhoneNumber = users.PhoneNumber,
                UserName = users.UserName,
                Year = users.Year,
                Email = users.Email,
                Address = users.Address,
                Poster = users.Poster
                
            };

            return View("UserForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(User model)
        {
            //if (!ModelState.IsValid)
            //{
            //    model.UserName = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
            //    return View("MovieForm", model);
            //}

            var user = await _context.User.FindAsync(model.Id);

            if (user == null)
                return NotFound();

            var files = Request.Form.Files;

            if (files.Any())
            {
                var poster = files.FirstOrDefault();

                using var dataStream = new MemoryStream();

                await poster.CopyToAsync(dataStream);

                model.Poster = dataStream.ToArray();

                if (!_allowedExtenstions.Contains(Path.GetExtension(poster.FileName).ToLower()))
                {
                    //model.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
                    ModelState.AddModelError("Poster", "Only .PNG, .JPG images are allowed!");
                    return View("UserForm", model);
                }

                if (poster.Length > _maxAllowedPosterSize)
                {
                   // model.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
                    ModelState.AddModelError("Poster", "Poster cannot be more than 1 MB!");
                    return View("UserForm", model);
                }


                user.Poster = model.Poster;
            }

            user.Title = model.Title;
            user.Year = model.Year;
            user.UserName = model.UserName;
            user.Address = model.Address;
            user.PhoneNumber = model.PhoneNumber;
            user.Email = model.Email;

            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Movie updated successfully");
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return BadRequest();

           var user = await _context.User.SingleOrDefaultAsync(m => m.Id == id);

            if (user == null)
                return NotFound();

            return View(user);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();

            var user = await _context.User.FindAsync(id);

            if (user == null)
                return NotFound();

            _context.User.Remove(user);
            _context.SaveChanges();

            return Ok();
        }
    }
}