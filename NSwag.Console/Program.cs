using NSwag;
using NSwag.Commands;

Console.Write("NSwag command line tool for .NET Core " + RuntimeUtilities.CurrentRuntime + ", ");
var processor = new NSwagCommandProcessor(new CoreConsoleHost());
return await processor.ProcessAsync(args);