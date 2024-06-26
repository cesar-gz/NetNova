using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NetNova.Data;
using NetNova.Models;

namespace NetNova.Pages.Items
{
  public class IndexModel : PageModel
  {
    private readonly ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext context)
    {
      _context = context;
    }

    public IList<Item> Items { get; set; } = default!;

    public async Task OnGetAsync()
    {
      if (_context.Items != null)
      {
        Items = await _context.Items.ToListAsync();
      }
    }
  }
}
