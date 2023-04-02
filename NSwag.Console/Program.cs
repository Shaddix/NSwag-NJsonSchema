using NSwag;
using NSwag.Commands;

Console.Write("NSwag command line tool for .NET Core, ");
var processor = new NSwagCommandProcessor(new CoreConsoleHost());
return await processor.ProcessAsync(args);