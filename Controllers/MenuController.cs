using System;
using burgershack2.Services;

namespace burgershack2.Controllers
{
  public class MenuController
  {
    private MenuService _menuService { get; set; } = new MenuService();

    public void UserInput()
    {
      _menuService.getItems();
      Print();
      string choice = Console.ReadLine().ToLower();
      Console.Clear();

      switch (choice)
      {

        case "q":
          Environment.Exit(1);
          break;
        default:
          if (int.TryParse(choice, out int index))
          {

            _menuService.getItems(index - 1);
            Print();
          }
          else
          {
            System.Console.WriteLine("Invalid Key");
          }
          break;
      }

    }

    private void Print()
    {
      foreach (string message in _menuService.Messages)
      {
        System.Console.WriteLine(message);
      }
      _menuService.Messages.Clear();

    }
  }
}