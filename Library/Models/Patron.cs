using System.Collections.Generic;

namespace Library.Models
{
  public class Patron
  {
    public Patron()
    {
      this.Copies = new HashSet<PatronCopy>();
    }
    public int PatronId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set;}
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<PatronCopy> Copies { get; set; }
  }
}