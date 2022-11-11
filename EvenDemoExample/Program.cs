using EvenDemoExample;

DemoClass demoObject = new DemoClass();
demoObject.OnMaximum += MaximumReached;

for(int incrementValue = 0; incrementValue <= 15; incrementValue++)
{
    demoObject.SetValue(incrementValue);
}

static void MaximumReached(object source, EventDemo e)
    => Console.WriteLine(e.GetInfo());

Console.ReadLine();