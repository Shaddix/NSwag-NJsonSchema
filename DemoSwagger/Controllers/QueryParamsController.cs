using DemoSwagger;
using DemoSwagger.FromQueryJson;
using Microsoft.AspNetCore.Mvc;

[Route("query-params")]
[ApiController]

public class QueryParamsController
{
    [HttpGet("One")]
    public void One([FromQuery]DummyDto param)
    {
    }
    
    [HttpGet("JsonInQueryParams")]
    public void JsonInQueryParams([FromJsonQuery]DummyDto param)
    {
    }
}