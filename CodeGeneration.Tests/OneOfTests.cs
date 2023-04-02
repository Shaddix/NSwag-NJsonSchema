using NJsonSchema.CodeGeneration.TypeScript;
using NSwag;
using NSwag.CodeGeneration.TypeScript;

namespace CodeGeneration.Tests;

[UsesVerify]
public class OneOfTests
{

    [Fact]
    public async Task BasicExample()
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
    
    [Fact]
    public async Task PetStoreExample()
    {
        // Arrange
        var document = await OpenApiDocument.FromFileAsync("pet-store.json");
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
