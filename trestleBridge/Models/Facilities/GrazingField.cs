using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Facilities
{
    public class GrazingField : IFacility<IResource>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<IResource> _animals = new List<IResource>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IResource animal)
        {
            _animals.Add(animal);
        }

        public void AddResource(List<IResource> animals)
        {
            _animals.Add((IResource)animals);
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));
            return output.ToString();
        }
    }
}
