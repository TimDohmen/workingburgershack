namespace burgershack2.Models
{
  public class Drinks : MenuItem
  {

    public string Picture { get; set; }

    public int Size { get; set; }
    public override string GetTemplate()
    {
      string template = $@"
  {Picture}

Item: {Title}

Size : {Size} oz
Cost: {Price:c}
Description: {Description}

";
      return template;
    }
    public Drinks(string title, double price, string desc, string picture, int size) : base(title, price, desc)
    {
      Picture = picture;
      Size = size;
    }
  }
}