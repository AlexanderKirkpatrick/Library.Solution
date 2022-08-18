using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.Authors = new HashSet<AuthorBook>();
      this.Copies = new HashSet<Copy>();
    }

    public int BookId { get; set; }
    public string Title { get; set; }
    public DateTime DatePublished { get; set; }
    public string Description { get; set; }
    public string Publisher { get; set; }

    public virtual ICollection<AuthorBook> Authors { get; set; }
    public virtual ICollection<Copy> Copies { get; set; }
    
  }

}