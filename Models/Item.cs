using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace NetNova.Models
{
  public class Item
  {
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    [Required]
    public string OwnerId { get; set; }
    public IdentityUser Owner { get; set; }
  }

} //end of namespace
