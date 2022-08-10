using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Facilities
{
    internal class NaturalField : IFacility<IResource>
    {
        private int _capacity = 60;
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
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource(List<IResource> plant)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Natural field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));
            return output.ToString();
        }
    }
}