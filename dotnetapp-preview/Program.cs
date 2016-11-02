using System;
using System.Runtime.InteropServices;

public static class Program
{
  public static void Main(string[] args) 
  {
        string message = "Dotnet-bot: Welcome to using .NET Core!";
          
        if (args.Length > 0) 
        {
          message = String.Join(" ",args);
        }

        Console.WriteLine(GetBot(message));
        Console.WriteLine("**Environment**");
        Console.WriteLine($"Platform: .NET Core 1.1");
        Console.WriteLine($"Bitness: {RuntimeInformation.OSArchitecture}");
        Console.WriteLine($"OS: {RuntimeInformation.OSDescription}");
        Console.WriteLine();
  }

  public static string GetBot(string message) 
  {
          string bot = $"\n        {message}";
          bot += @"
    __________________
                      \
                       \
                          ....
                          ....'
                           ....
                        ..........
                    .............'..'..
                 ................'..'.....
               .......'..........'..'..'....
              ........'..........'..'..'.....
             .'....'..'..........'..'.......'.
             .'..................'...   ......
             .  ......'.........         .....
             .                           ......
            ..    .            ..        ......
           ....       .                 .......
           ......  .......          ............
            ................  ......................
            ........................'................
           ......................'..'......    .......
        .........................'..'.....       .......
     ........    ..'.............'..'....      ..........
   ..'..'...      ...............'.......      ..........
  ...'......     ...... ..........  ......         .......
 ...........   .......              ........        ......
.......        '...'.'.              '.'.'.'         ....
.......       .....'..               ..'.....
   ..       ..........               ..'........
          ............               ..............
         .............               '..............
        ...........'..              .'.'............
       ...............              .'.'.............
      .............'..               ..'..'...........
      ...............                 .'..............
       .........                        ..............
        .....

";
  return bot;
  }
}
