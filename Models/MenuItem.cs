namespace burgershack2.Models
{
  public abstract class MenuItem
  {
    public string Title { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }


    public virtual string GetTemplate()
    {
      string template = $@"
Item: {Title}
Cost: {Price:c}
Description: {Description}
";
      return template;
    }

    public MenuItem(string title, double price, string desc)
    {
      Title = title;
      Price = price;
      Description = desc;
    }
  }
}