using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Sheep : IResource, IFeeding, IMeatProducing
    {
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 5.0;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public string Type { get; } = "Sheep";
        public double FeedPerDay { get; set; } = 4.0;

        // Methods

        public double Butcher()
        {
            return _meatProduced;
        }
        public override string ToString()
        {
            return $"Sheep {this._shortId}. BAAA";
        }

        public void Feed()
        {
            Console.WriteLine($"Sheep {this._shortId} just ate {this.FeedPerDay}kg of grass");
        }
    }
}
