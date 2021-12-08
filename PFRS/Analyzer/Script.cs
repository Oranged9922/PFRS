namespace Analyzer;
public class Script
{
    public bool Saved { get => this.Contents == this.WorkingContents; }
    public string Contents;
    public int ID { get; set; }
    public object Name { get; set; }
    public string WorkingContents { get; set; }

    public string Path;
    public Script(int ID, string Path, string fileContent)
    {
        this.ID = ID;
        this.Path = Path;
        this.Contents = fileContent;
        this.Name = Path.Split("\\")[^1];
        this.WorkingContents = this.Contents;
    }

}

