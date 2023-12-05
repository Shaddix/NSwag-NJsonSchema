using NJsonSchema.CodeGeneration.TypeScript;
using NSwag;
using NSwag.CodeGeneration.CSharp;
using NSwag.CodeGeneration.TypeScript;

namespace CodeGeneration.Tests;

[UsesVerify]
public class ToCsharp
{

    [Theory]
    [InlineData("atlas-openapi.json")]
    public async Task Sample(string file)
    {
        // Arrange
        var document = await OpenApiDocument.FromFileAsync(file);
        var clientGenerator = new CSharpClientGenerator(
            document,
            new CSharpClientGeneratorSettings()
            {
            }
        );

        // Act
        var code = clientGenerator.GenerateFile();

        // Assert
        await VerifyHelper.Verify(code, settings => settings.UseFileName(file));
    }
}
