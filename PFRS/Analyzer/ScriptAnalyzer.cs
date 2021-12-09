using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System.Reflection;

namespace Analyzer;
public class ScriptAnalyzer
{
    private List<Assembly> assemblies;
    private List<string> imports;
    public Globals globals;
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
            "Common.HardwareRepresentation"
        };

        globals = new Globals()
        {
            formula = new Formula(),
        };
        
    }

    public object CompileScript(string sourceCode)
    {
        try {
            return CSharpScript.RunAsync(
                sourceCode,
                globals: globals,
                options: ScriptOptions.Default.WithReferences(assemblies).AddImports(imports));
            }
        catch(Exception e)
        {
            return e;
        }
    }
}

/// <summary>
/// Global variables for formula scripts.
/// </summary>
public class Globals
{
    public Formula formula;
}
