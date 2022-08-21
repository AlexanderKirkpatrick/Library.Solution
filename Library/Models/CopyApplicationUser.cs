using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace Library.Models
{
  public class CopyApplicationUser
  {
    public int CopyApplicationUserId { get; set; }
    public int CopyId { get; set; }
    public virtual Copy Copy { get; set; }
    public string ApplicationUserId { get; set; }
    public virtual ApplicationUser ApplicationUser { get; set; }
    public DateTime CheckoutDate { get; set; }
    public DateTime DueDate { get; set; }
    public Boolean Returned { get; set; } = false;
  }
} 