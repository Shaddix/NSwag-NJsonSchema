using DemoSwagger.FromQueryJson;

namespace DemoSwagger;

public class NestedJsonInQuery
{
    [FromJsonQuery]
    public DummyDto Dummy { get; set; }
    
    public string Tst { get; set; }
}