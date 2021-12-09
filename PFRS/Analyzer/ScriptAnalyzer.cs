using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System.Reflection;

namespace Analyzer;
public class ScriptAnalyzer
{
    private readonly List<Assembly> assemblies;
    private readonly List<string> imports;
    public ScriptAnalyzer()
    {
        assemblies = new();
        // add all assemblies
        assemblies.Add(Assembly.GetExecutingAssembly());
        var assemblyNames = Assembly.GetExecutingAssembly().GetReferencedAssemblies();
        foreach (var assemblyName in assemblyNames)
            assemblies.Add(Assembly.Load(assemblyName));

        imports = new()
        {
            "System",
            "PFRS",
            "Common.HardwareRepresentation"
        };


    }

    public Task CompileScript(string sourceCode)
    {
        return CSharpScript.RunAsync(
            sourceCode,
            globals: null,
            options: ScriptOptions.Default.WithReferences(assemblies).AddImports(imports));
    }
}

/// <summary>
/// Global variables for formula scripts.
/// </summary>
public class Globals
{
    /// <summary>
    /// Optional text parameter (usually from form's 'Params:' field).
    /// </summary>
    public string param;

    /// <summary>
    /// Parameter map for passing values in/out of the script.
    /// </summary>
    public Dictionary<string, object> context;
}
