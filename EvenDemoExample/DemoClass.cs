using EvenDemoExample;

public class DemoClass
{
    public event MyEventHandler? OnMaximum;
    private int Maximum = 10;

    public void SetValue(int value)
    {
        if (OnMaximum != null && value > Maximum)
            OnMaximum(this, 
                new EventDemo("You've entered " + value + ", but the maximum is " + Maximum));
    }
}