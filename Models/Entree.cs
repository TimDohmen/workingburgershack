namespace burgershack2.Models
{
  public class Entree : MenuItem
  {

    public string Toppings { get; set; }
    public string Picture { get; set; }

    public override string GetTemplate()
    {
      string template = $@"
  {Picture}

Item: {Title}

Toppings : {Toppings}
Cost: {Price:c}
Description: {Description}

";
      return template;
    }

    public Entree(string title, double price, string desc, string picture, string toppings) : base(title, price, desc)
    {
      Picture = picture;
      Toppings = toppings;
    }
  }
}