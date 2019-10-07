using System;
namespace burgershack2.Services;

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

    }

    private void Print()
    {
      foreach (string message in _menuService.Messages)
      {
        System.Console.WriteLine(message);
      }
      _menuService.Messages.Clear();
      System.Console.WriteLine();

    }
  }
}