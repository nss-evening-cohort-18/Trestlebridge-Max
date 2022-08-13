using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Facilities
{
    public class PlowedField : IFacility<IResource>
    {
        private int _capacity = 65;
        private Guid _id = Guid.NewGuid();

        private List<IResource> _plants = new List<IResource>();
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public void AddResource(IResource plant)
        {
            _plants.Add(plant);
        }

        public void AddResource(List<IResource> plants)
        {
            _plants.Add((IResource)plants);
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Plowed field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));
            return output.ToString();
        }
    }
}

