using System.Collections.Generic;
using burgersack.Models;

namespace burgershack2.Services
{
  public class MenuService
  {
    public List<MenuItem> Menu { get; private set; }
    public List<string> Messages { get; set; }

    public void Setup()
    {
      Entree burger = new Entree("Big Boy Burger", 10.99, "The biggest burger for the biggest boy");
      Entree salad = new Entree("Western Salad", 3.99, "It can be cheap because nobody will buy it anyways.");
      Entree steak = new Entree("Lightly Grill Steak", 24.99, "Evolve Arms");

      Menu.AddRange(new MenuItem[] { burger, salad, steak });
    }

    public void getItems(int index)
    {
      Messages.Add("Available Items");
      for (int i = 0; i < Menu.Count; i++)
      {
        MenuItem m = Menu[index];
        Messages.Add(m.GetTemplate());

      }
    }

    public void getItems()
    {
      Messages.Add("Available Items");
      for (int i = 0; i < Menu.Count; i++)
      {
        MenuItem m = Menu[i];
        Messages.Add($"{i + 1}: {m.Title} - {m.Price}");
      }
      Messages.Add("Type a number to see details or Q to quit");
    }
    public MenuService()
    {
      Messages = new List<string>();
      Menu = new List<MenuItem>();
      Setup();
    }

  }
}