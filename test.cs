using System;
using Vector.Tools;
using Vector.CANoe.Runtime;
using Vector.CANoe.Sockets;
using Vector.CANoe.Threading;
using Vector.Diagnostics;
using Vector.Scripting.UI;
using Vector.CANoe.TFS;
using Vector.CANoe.VTS;
using NetworkDB;



public class test : TestModule
{
    public override void Main()
    {
        SimpleTest();
    }
    // Test cases need to be marked with an attribute:
    [TestCase("Simple Test")]
    public void SimpleTest()
    {
        CANFrame messsage = new CANFrame(0x88, 0x04);
        messsage.Send();


        Report.TestStep("Start engine:");
        Output.WriteLine("Firing up LiveTele");
    }
}