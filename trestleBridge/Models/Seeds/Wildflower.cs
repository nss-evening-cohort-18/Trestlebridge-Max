using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Seeds
{
    internal class Wildflower : IResource, IFlower, ICompostProducing
    {
        private Guid _id = Guid.NewGuid();
        private double _compostProduced = 30.3;

        public string Type { get; } = "Wildflower";

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

        public override string ToString()
        {
            return $"Wildflower {this._shortId}.";
        }
    }
}
