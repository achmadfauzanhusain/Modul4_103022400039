using System;

class Program
{
    static void Main(string[] args)
    {
        MesinKopi mesin = new MesinKopi();

        mesin.PowerOn();          
        mesin.StartBrew();         
        mesin.FinishBrew();        
        mesin.StartMaintenance();  
        mesin.FinishMaintenance();
        mesin.PowerOff();         

        mesin.StartBrew();
    }
}