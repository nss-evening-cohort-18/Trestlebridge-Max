using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trestleBridge.Interfaces
{

    public interface IFeed
    {
        double FeedPerDay { get; set; }
        string Type { get; }
        void Feed();
    }
}
