using NJsonSchema.CodeGeneration.TypeScript;
using NSwag;
using NSwag.CodeGeneration.TypeScript;

namespace CodeGeneration.Tests;

[UsesVerify]
public class OneOfTests
{

    [Theory]
    [InlineData("test1.json")]
    [InlineData("inheritance-allof.json")]
    [InlineData("inheritance-oneof2.json")]
    [InlineData("inheritance-oneof3.json")]
    [InlineData("inheritance-oneof.json")]
    [InlineData("inheritance-oneof-multiple.json")]
    [InlineData("pet-store.json")]
    [InlineData("json-in-query.json")]
    public async Task Sample(string file)
    {
        // Arrange
        var document = await OpenApiDocument.FromFileAsync(file);
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
        await VerifyHelper.Verify(code, settings => settings.UseFileName(file));
    }
}
