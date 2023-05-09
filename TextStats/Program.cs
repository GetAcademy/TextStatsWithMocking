using System.Reflection.PortableExecutable;
using TextStats;

var fileLineReader = new FileLineReader("TextFile1.txt");
var keyboardLineReader = new KeyboardLineReader();
var webLineReader = new WebLineReader("https://www.vg.no/sport/i/WRknKG/ola-vigen-hattestad-foreslaar-at-alle-langrennsloepere-skal-med-like-ski");
var statService = new StatService(webLineReader);
var result = statService.GetStats("Terje");
Console.WriteLine(result);