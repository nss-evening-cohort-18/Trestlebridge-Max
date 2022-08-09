using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trestleBridge.Interfaces
{
    public interface IFeeding
    {
        double FeedPerDay { get; set; }
        string Type { get; }
        void Feed();
    }
}
