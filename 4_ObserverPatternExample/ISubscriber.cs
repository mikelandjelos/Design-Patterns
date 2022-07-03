﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternMyExample
{
    internal interface ISubscriber
    {
        void Update(Publisher publisher);
    }
}
