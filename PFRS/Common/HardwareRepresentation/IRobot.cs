namespace Common.HardwareRepresentation;
public interface IRobot
{
    public Dictionary<string,object> Properties { get; set; }
    public Dictionary<string,object> Methods { get; set; }

    public void AddProperty((string propertyName, object property) keyValue);
    public void AddMethod((string methodName, object method) keyValue);
}

