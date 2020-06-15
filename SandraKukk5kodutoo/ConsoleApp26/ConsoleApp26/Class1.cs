using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class TVremote
    {
        int volume, channel;
        bool isOn;

        public TVremote()
        {
            isOn = false;
            volume = 0;
            channel = 1;
        }

        public void TurnOn()
        {
            isOn = true;
        }

        public void TurnOff()
        {
            isOn = false;
        }

        public void IncreaseVolume()
        {
            if (isOn && volume <= 12)
            {
                volume += 3;
                Console.WriteLine("Changed the volume from {0} to {1}", volume - 3, volume);
            }
            else
            {
                Console.WriteLine("Cannot change volume");
            }
        }

        public void DecreaseVolume()
        {
            if (isOn && volume >= 3)
            {
                volume -= 3;
                Console.WriteLine("Changed the volume from {0} to {1}", volume + 3, volume);
            }
            else
            {
                Console.WriteLine("Cannot change volume");
            }

        }

        
        public void ChangeChannelBack()
        {
            if (isOn && channel>1 && channel<=100)
            {
                channel -= 1;
                Console.WriteLine("Changed the channel from {0} to {1}", channel + 1, channel);
            }
            else
            {
                Console.WriteLine("Cannot change channel");
            }

        }

        public void ChangeChannelForward()
        {
            if (isOn && channel >= 1 && channel < 100)
            {
                channel += 1;
                Console.WriteLine("Changed the channel from {0} to {1}", channel - 1, channel);
            }
            else
            {
                Console.WriteLine("Cannot change channel");
            }

        }
        
        public void ChangeChannel(int newchannel)
        {
            if (isOn && newchannel >= 1 && newchannel <= 100)
            {
                
                Console.WriteLine("Changed the channel from {0} to {1}", channel, newchannel);
                channel = newchannel;
            }
            else
            {
                Console.WriteLine("Cannot change channel");
            }

        }
    }
}
