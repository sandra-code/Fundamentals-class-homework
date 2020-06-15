using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Linen linenMachine = new Linen();
            linenMachine.TurnOn();
            linenMachine.DoIroning(90);
            linenMachine.DoIroning("cotton");
            linenMachine.DoIroning(218);
            linenMachine.Descale();
            linenMachine.DoIroning(300);
            linenMachine.DoIroning("wool");
            Console.WriteLine("");

            Regular regularMachine = new Regular();
            regularMachine.TurnOn();
            regularMachine.DoIroning(150);
            regularMachine.DoIroning("cotton");
            regularMachine.DoIroning(187);
            linenMachine.Descale();
            regularMachine.UseSteam();
            regularMachine.UseSteam();
            regularMachine.DoIroning(141);
            Console.WriteLine("");

            Premium premiumMachine = new Premium();
            premiumMachine.TurnOn();
            premiumMachine.DoIroning(150);
            premiumMachine.DoIroning("cotton");
            premiumMachine.UseSteam();
            premiumMachine.DoIroning("silk");
            premiumMachine.UseSteam();
            Console.WriteLine("");

            Console.ReadLine();
        }
    }

    interface IIron
    {
        void Descale();
        void DoIroning(int temperature);
        void DoIroning(string machineType);
        void UseSteam();
        void TurnOn();
        void TurnOff();
    }

    class Linen : IIron
    {
        internal string machineType;
        internal string program;
        internal int temperature;
        internal int usageCounter;
        internal bool isOn;
        internal bool isSteamOn;
        internal int steamCounter;
        internal bool isLightOn;

        public Linen()
        {
            machineType = "Linen";
            isOn = false;
            isSteamOn = true;
        }

        public void TurnOn()
        {
            isOn = true;
        }

        public void TurnOff()
        {
            isOn = false;
        }

        public virtual void DoIroning(int temp)
        {
            if (isOn && temp >= 90 && temp < 120)
            {
                program = "synthetics program";
                Console.WriteLine("{0} machine is ironing with {1}", machineType, program);
                usageCounter++;
                UseSteam();

            }
            else if (isOn && temp >= 120 && temp < 150)
            {
                program = "silk program";
                Console.WriteLine("{0} machine is ironing with {1}", machineType, program);
                usageCounter++;
                UseSteam();
            }
            else if (isOn && temp >= 150 && temp < 200)
            {
                program = "cotton program";
                Console.WriteLine("{0} machine is ironing with {1}", machineType, program);
                usageCounter++;
                UseSteam();
            }
            else if (isOn && temp >= 200 && temp < 231)
            {
                program = "linen program";
                Console.WriteLine("{0} machine is ironing with {1}", machineType, program);
                usageCounter++;
                UseSteam();
            }
            else
            {
                Console.WriteLine("Invalid temperature range for ironing");
            }

            if (isOn == false)
            {
                Console.WriteLine("Iron is turned off");
            }


        }

        public virtual void DoIroning(string _program)
        {
            program = _program;
            Random rnd = new Random();

            if (isOn && program.Contains("synthetics"))
            {
                temperature = rnd.Next(90, 120);
                Console.WriteLine("{0} machine is ironing with {1} degrees", machineType, temperature);
                usageCounter++;
                UseSteam();
            }
            else if (isOn && program.Contains("silk"))
            {
                temperature = rnd.Next(120, 150);
                Console.WriteLine("{0} machine is ironing with {1} degrees", machineType, temperature);
                usageCounter++;
                UseSteam();
            }
            else if (isOn && program.Contains("cotton"))
            {
                temperature = rnd.Next(150, 200);
                Console.WriteLine("{0} machine is ironing with {1} degrees", machineType, temperature);
                usageCounter++;
                UseSteam();
            }
            else if (isOn && program.Contains("linen"))
            {
                temperature = rnd.Next(200, 231);
                Console.WriteLine("{0} machine is ironing with {1} degrees", machineType, temperature);
                usageCounter++;
                UseSteam();
            }
           
            else if (isOn == false)
            {
                Console.WriteLine("Iron is turned off");
            }
            else
            {
                Console.WriteLine("We do not have a program for ironing {0}", program);
            }
        }

        public void Descale()
        {
            usageCounter = 0;
            Console.WriteLine("Machine is cleaned");
        }


        public virtual void UseSteam()
        {
            if (isOn && isSteamOn && !program.Contains("synthetics"))
            {
                Console.WriteLine("Ironing with steam");
            }
            else if (isOn == false)
            {
            }
            else
            {
                Console.WriteLine("Cannot use steam");
            }
            if (isOn && usageCounter % 3 == 0)
            {
                Console.WriteLine("Machine has been used 3 times and needs cleaning");
            }
        }
    }

    class Regular : Linen
    {
        public Regular() : base()
        {
            machineType = "Regular";
            isOn = false;
            isSteamOn = false;
            isLightOn = false;

        }

        public override void DoIroning(int temp)
        {
            if (isOn && temp >= 90 && temp < 120)
            {
                program = "synthetics program";
                Console.WriteLine("{0} machine is ironing with {1}", machineType, program);
                usageCounter++;
            }
            else if (isOn && temp >= 120 && temp < 150)
            {
                program = "silk program";
                Console.WriteLine("{0} machine is ironing with {1}", machineType, program);
                usageCounter++;
            }
            else if (isOn && temp >= 150 && temp < 200)
            {
                program = "cotton program";
                Console.WriteLine("{0} machine is ironing with {1}", machineType, program);
                usageCounter++;
            }
            else
            {
                Console.WriteLine("Invalid temperature range for ironing");
            }

            if (isOn == false)
            {
                Console.WriteLine("Iron is turned off");
            }
            if (machineType=="Regular" && isOn && usageCounter % 3 == 0)
            {
                Console.WriteLine("Machine has been used 3 times and needs cleaning");
            }
            else if (machineType == "Premium" && isOn && usageCounter % 3 == 0)
            {
                Descale();
            }
        }

        public override void DoIroning(string _program)
        {
            program = _program;
            Random rnd = new Random();

            if (isOn && program.Contains("synthetics"))
            {
                temperature = rnd.Next(90, 120);
                Console.WriteLine("{0} machine is ironing with {1} degrees", machineType, temperature);
                usageCounter++;
            }
            else if (isOn && program.Contains("silk"))
            {
                temperature = rnd.Next(120, 150);
                Console.WriteLine("{0} machine is ironing with {1} degrees", machineType, temperature);
                usageCounter++;
            }
            else if (isOn && program.Contains("cotton"))
            {
                temperature = rnd.Next(150, 200);
                Console.WriteLine("{0} machine is ironing with {1} degrees", machineType, temperature);
                usageCounter++;
            }
            else if (isOn == false)
            {
                Console.WriteLine("Iron is turned off");
            }
            else
            {
                Console.WriteLine("We do not have a program for ironing {0}", program);
            }

            if (machineType == "Regular" && isOn && usageCounter % 3 == 0)
            {
                Console.WriteLine("Machine has been used 3 times and needs cleaning");
            }
            else if(machineType=="Premium" && isOn && usageCounter % 3 == 0)
            {
                Descale();
            }
        }

        public override void UseSteam()
        {
            steamCounter = 0;
            if (isOn && isSteamOn == false && !program.Contains("synthetics"))
            {
                isSteamOn = true;
                Console.WriteLine("Ironing with steam");
                steamCounter++;
            }
            else if (isSteamOn == true)
            {
                Console.WriteLine("Steam is already on");
            }
            else if (isOn == false)
            {
            }
            else
            {
                Console.WriteLine("Cannot use steam");
            }
            if (isOn && machineType == "Premium" && steamCounter % 2 == 0)
            {
                isLightOn = true;
                Console.WriteLine("Light is turned on");
            }
        }
    }
    class Premium : Regular
    {
        public Premium() : base()
        {
            machineType = "Premium";
            isOn = false;
            isLightOn = false;
            isSteamOn = false;
        }
    }
}   


