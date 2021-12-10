namespace BreadOrder.Models
{
  public class Bread
  {
    public int WhiteBread { get; set; }
    public int WheatBread { get; set; }
    public int Sourdough { get; set; }

    public Bread(int whiteBread, int wheatBread, int sourdough)
    {
      WhiteBread = whiteBread;
      WheatBread = wheatBread;
      Sourdough = sourdough;
    }

    public int TotalPrice()
    {
      int freeBread = WhiteBread / 3;
      return WhiteBread * 5 - freeBread * 5;
    }

  }
}