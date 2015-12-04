using System;
using System.Threading.Tasks;
using NUnit.Framework;

public class TimeoutLogger
{
	[Test] public void TestTimer ()
	{
	    bool wasCalled=false;
	    Start(()=>wasCalled=true);
	    
        Assert.IsTrue(wasCalled);
	}

    private void Start(Action a)
    {
        Task.Delay(10).ContinueWith((task => a()));
    }
}
