using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trestleBridge.Interfaces
{
<<<<<<<< HEAD:trestleBridge/Interfaces/IFeeding.cs
    public interface IFeeding
========

    public interface IFeed
>>>>>>>> Seeds:trestleBridge/Interfaces/IFeed.cs
    {
        double FeedPerDay { get; set; }
        string Type { get; }
        void Feed();
    }
}
