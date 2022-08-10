using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Seeds
{
    internal class Sesame : IResource, ISeedProducing
    {
        private Guid _id = Guid.NewGuid();
        private double _seedProduced = 650;

        public string Type { get; } = "Sesame";

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double Harvest()
        {
            return _seedProduced;
        }

        public override string ToString()
        {
            return $"Sesame {this._shortId}.";
        }
    }
}
