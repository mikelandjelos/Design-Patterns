using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternMyExample
{
    internal abstract class Publisher
    {

        protected List<ISubscriber> subscribers;

        public Publisher(ISubscriber[] _subscribers = null)
        {
            subscribers = new List<ISubscriber>();
            if (_subscribers != null)
                subscribers.AddRange(_subscribers);
        }

        public ISubscriber NewSubscriber
        { 
            set => subscribers.Add(value);
        }

        public void Subscribe(ISubscriber subscriber)
            => NewSubscriber = subscriber;

        public bool Unsubscribe(ISubscriber subscriber)
            => subscribers.Remove(subscriber);

        public void PublishmentNotification()
        {
            foreach (ISubscriber subscriber in subscribers)
                subscriber.Update(this);
        }

    }
}
