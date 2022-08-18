using System.Collections.Generic;

namespace Library.Models
{
  public class Patron
  {
    public Patron()
    {
      this.Copies = new HashSet<CopyPatron>();
    }
    public int PatronId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set;}
    public ApplicationUser User { get; set; }
    public ICollection<CopyPatron> Copys { get; set; }
  }
}