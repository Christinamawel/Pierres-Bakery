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
      int freeBread = (WhiteBread + WheatBread + Sourdough) / 3;
      int costWhiteBread = WhiteBread * 5;
      int costWheatBread = WheatBread * 5;
      int costSourdough = Sourdough * 8;
      return (costWhiteBread + costWheatBread + costSourdough) - freeBread * 5;
    }

  }
}