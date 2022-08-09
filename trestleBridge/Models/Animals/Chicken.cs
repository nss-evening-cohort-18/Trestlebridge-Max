using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Chicken : IResource, IFeeding, IEgg, IFeathers, IMeatProducing
    {
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 7.5;
        private double _feathersProduced = 0.5;
        private double _eggsProduced = 1.7;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double FeedPerDay { get; set; } = 4.1;
        public string Type { get; } = "Goat";

        // Methods
        public void Feed()
        {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.FeedPerDay}kg of grass");
        }


        public override string ToString()
        {
            return $"Chicken {this._shortId}. BAWK";
        }


        public double GetEggs()
        {
            return _eggsProduced;
        }

        public double Pluck()
        {
            return _feathersProduced;
        }

        public double Butcher()
        {
            return _meatProduced;
        }
    }
}