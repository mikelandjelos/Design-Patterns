using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ObserverPatternMyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            YTChannel channel1 = new YTChannel("Channel1");
            YTChannel channel2 = new YTChannel("Channel2");
            YTChannel channel3 = new YTChannel("Channel3");
            YTChannel channel4 = new YTChannel("Channel4");

            channel1.NewSubscriber = channel2;
            channel1.NewSubscriber = channel3;
            channel1.NewSubscriber = channel4;

            channel2.NewSubscriber = channel1;

            channel1.NewVideo = "Video11";
            Thread.Sleep(3000);

            channel1.NewVideo = "Video12";
            Thread.Sleep(3000);
  
            channel1.NewVideo = "Video13";
            Thread.Sleep(3000);

            channel2.NewVideo = "Video21";
            Thread.Sleep(3000);

            channel3.NewVideo = "Video31";
            Thread.Sleep(3000);

        }
    }
}
