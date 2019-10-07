using System.Collections.Generic;
using burgershack2.Models;

namespace burgershack2.Services
{
  public class MenuService
  {
    public List<MenuItem> Menu { get; private set; }
    public List<string> Messages { get; set; }

    public void Setup()
    {
      Entree burger = new Entree("Big Boy Burger", 10.99, "The biggest burger for the biggest boy", $@"
 _                               
| |                              
| |__  _   _ _ __ __ _  ___ _ __ 
| '_ \| | | | '__/ _` |/ _ \ '__|
| |_) | |_| | | | (_| |  __/ |   
|_.__/ \__,_|_|  \__, |\___|_|   
                  __/ |          
                 |___/  ", "Bacon, Onion Rings, Ham, More Bacon");
      Entree salad = new Entree("Western Salad", 3.99, "It can be cheap because nobody will buy it anyways.", $@"
           _           _     
          | |         | |    
 ___  __ _| | __ _  __| |___ 
/ __|/ _` | |/ _` |/ _` / __|
\__ \ (_| | | (_| | (_| \__ \
|___/\__,_|_|\__,_|\__,_|___/
                             ", "Bacon, More Bacon, Steak bits");
      Entree steak = new Entree("Lightly Grill Steak", 24.99, "Evolve Arms", $@"
     _             _    
    | |           | |   
 ___| |_ ___  __ _| | __
/ __| __/ _ \/ _` | |/ /
\__ \ ||  __/ (_| |   < 
|___/\__\___|\__,_|_|\_\", "Track marks dirt");

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