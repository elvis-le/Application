using FPTBook.Interfaces;
using FPTBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FPTBook.Controllers
{
    public class AdminController : Controller
    {
        private readonly FptbookContext _context;
        private readonly IBookRepository _bookRepository;

        public AdminController(FptbookContext context, IBookRepository bookRepository)
        {
            _context = context;
            _bookRepository = bookRepository;
        }
        public async Task<IActionResult> Index()
        {
            var books = await _bookRepository.GetAll();
            return View(books);
        }

        public async Task<IActionResult> ManageCustomerAsync()
        {
            var customer = await _context.Users.ToListAsync();
            return View(customer);
        }

        public async Task<IActionResult> ManageBookAsync()
        {
            var books = await _bookRepository.GetAll();
            return View(books);
        }        
    }
}
