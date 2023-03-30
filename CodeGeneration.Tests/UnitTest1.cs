using NJsonSchema.CodeGeneration.TypeScript;
using NSwag;
using NSwag.CodeGeneration.TypeScript;

namespace CodeGeneration.Tests;

[UsesVerify]
public class UnitTest1
{

    [Fact]
    public async Task Tst1()
    {
        // Arrange
        var document = await OpenApiDocument.FromFileAsync("test1.json");
        var clientGenerator = new TypeScriptClientGenerator(
            document,
            new TypeScriptClientGeneratorSettings
            {
                TypeScriptGeneratorSettings =
                {
                    TypeScriptVersion = 4.3m,
                    NullValue = TypeScriptNullValue.Undefined
                }
            }
        );

        // Act
        var code = clientGenerator.GenerateFile();

        // Assert
        await VerifyHelper.Verify(code);
    }
}
