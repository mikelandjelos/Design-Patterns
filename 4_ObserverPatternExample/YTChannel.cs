using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternMyExample
{
    // Pitanje: Da li je narusen SRP?

    /// <summary>
    /// Channel's can subscribe to other channel's
    /// and also have a list of subscribers and videos.
    /// </summary>
    internal class YTChannel : Publisher, ISubscriber
    {
        private string username;
        public List<string> videos;
        private DateTime lastUpdated;

        public YTChannel(string _username)
        {
            username = _username;
            videos = new List<string>();
            lastUpdated = DateTime.MinValue;
        }

        public DateTime LastUpdated
            { get => lastUpdated; }

        public int SubscriberCount
            { get => subscribers.Count; }

        public string NewVideo
        {
            set
            { 
                videos.Add(value);
                lastUpdated = DateTime.Now;
                PublishmentNotification();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Username: " + username +
                ",\nSubscribers: " + SubscriberCount);
            foreach (string video in videos)
                sb.AppendLine(video);
            return sb.ToString();
        }

        public void Update(Publisher ytChannel)
        {
            YTChannel _ytChannel 
                = ytChannel as YTChannel;
            if (_ytChannel == null)
                return;
            Console.WriteLine("Subscriber {0} has been updated"
                + " about a new video {1} from channel {2}, at {3}.",
                this.username, _ytChannel.videos.Last<string>(),
                _ytChannel.username, _ytChannel.lastUpdated);
        }
    }
}
