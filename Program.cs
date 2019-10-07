using System;
using burgershack2.Controllers;

namespace burgershack2
{
  class Program
  {
    static void Main(string[] args)
    {
      MenuController mc = new MenuController();
      while (true)
      {
        mc.UserInput();
      }
    }
  }
}
