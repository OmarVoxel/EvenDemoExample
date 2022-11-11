namespace EvenDemoExample;

public delegate void MyEventHandler(object source, EventDemo e);

public class EventDemo : EventArgs
{
    private readonly string _eventInfo;
    public EventDemo(string text) => _eventInfo = text;
    public string GetInfo() => _eventInfo;
}