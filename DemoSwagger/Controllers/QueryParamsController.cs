using System.Text.Json;
using DemoSwagger;
using DemoSwagger.FromQueryJson;
using Microsoft.AspNetCore.Mvc;

[Route("query-params")]
[ApiController]

public class QueryParamsController
{
    [HttpGet("One")]
    public string One([FromQuery]DummyDto param)
    {
        return JsonSerializer.Serialize(param);
    }
    
    [HttpGet("JsonInQueryParams")]
    public string JsonInQueryParams([FromJsonQuery]DummyDto param)
    {
        return JsonSerializer.Serialize(param);
    }
    
    [HttpGet("NestedJsonInQuery")]
    public string NestedJsonInQuery(NestedJsonInQuery paramWithNested)
    {
        return JsonSerializer.Serialize(paramWithNested);
    }
    
    [HttpGet("DictionaryInQueryParams")]
    public string DictionaryInQueryParams([FromQuery]Dictionary<string, string> param)
    {
        return JsonSerializer.Serialize(param);
    }
}