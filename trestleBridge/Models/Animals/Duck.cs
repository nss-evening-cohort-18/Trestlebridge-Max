using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Duck : IResource, IFeeding, IEgg, IFeathers
    {
        private Guid _id = Guid.NewGuid();

        private double _feathersProduced = 0.75;
        private int _eggsProduced = 6;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double FeedPerDay { get; set; } = 4.1;
        public string Type { get; } = "Duck";

        // Methods
        public void Feed()
        {
            Console.WriteLine($"Duck {this._shortId} just ate {this.FeedPerDay}kg of grass");
        }


        public override string ToString()
        {
            return $"Duck {this._shortId}. BAACK";
        }


        public double GetEggs()
        {
            return _eggsProduced;
        }

        public double Pluck()
        {
            return _feathersProduced;
        }

    }
}