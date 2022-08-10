using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using trestleBridge.Models.Facilities;
using trestleBridge.Interfaces;

namespace trestleBridge


{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();
        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();

        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();

        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Chicken":
                    ChickenHouses[index].AddResource((IResource)resource);
                    break;

                case "Duck":
                    DuckHouses[index].AddResource((IResource)resource);
                    break;

                case "Cow":
                    GrazingFields[index].AddResource(resource);
                    break;

                case "Goat":
                    GrazingFields[index].AddResource(resource);
                    break;

                case "Ostrich":
                    GrazingFields[index].AddResource(resource);
                    break;

                case "Pig":
                    GrazingFields[index].AddResource(resource);
                    break;

                case "Sheep":
                    GrazingFields[index].AddResource(resource);
                    break;

                case "Sesame":
                    PlowedFields[index].AddResource((IResource)resource);
                    break;
                
                case "Sunflower":
                    PlowedFields[index].AddResource((IResource)resource);
                    break;
                
                case "Wildflower":
                    NaturalFields[index].AddResource((IResource)resource);
                    break;
                
                default:
                    break;
            }
        }

        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
        }

        public void AddNaturalField(NaturalField field)
        {
            NaturalFields.Add(field);
        }

        public void AddPlowedField(PlowedField field)
        {
            PlowedFields.Add(field);
        }



        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));

            return report.ToString();
        }
    }
}
