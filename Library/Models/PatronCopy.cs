namespace Library.Models
{
  public class PatronCopy
  {
    public int PatronCopyId { get; set; }
    public int PatronId { get; set; }
    public int CopyId { get; set; }
    public virtual Patron Patron { get; set; }
    public virtual Copy Copy { get; set; }
  }
}