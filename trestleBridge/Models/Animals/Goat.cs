using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Goat : IResource, IFeeding, ICompost
    {
        private Guid _id = Guid.NewGuid();
        private double _compostProduced = 7.5;
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
            Console.WriteLine($"Goat {this._shortId} just ate {this.FeedPerDay}kg of grass");
        }

   
        public override string ToString()
        {
            return $"Goat {this._shortId}. BAAA!";
        }

        public double Collect()
        {
            return _compostProduced;
        }
    }
}
