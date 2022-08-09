using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Seeds
{
    internal class Sunflower : IResource, ISeedProducing, ICompostProducing
    {
        private Guid _id = Guid.NewGuid();
        private double _seedProduced = 650;
        private double _compostProduced = 21.6;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double Collect()
        {
            return _compostProduced;
        }

        public double Harvest()
        {
            return _seedProduced;
        }

        public override string ToString()
        {
            return $"Sunflower {this._shortId}.";
        }
    }
}
