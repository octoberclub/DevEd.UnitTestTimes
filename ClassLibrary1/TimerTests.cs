using System;
using System.Threading.Tasks;
using NUnit.Framework;

public class TimeoutLogger
{
	[Test] public void TestTimer ()
	{
	    bool wasCalled=false;
	    var t=Start(()=>wasCalled=true);
	    t.Wait();
        
        Assert.IsTrue(wasCalled);
	}

    private Task Start(Action a)
    {
        return Task.Delay(1000).ContinueWith((task => a()));
    }
}
