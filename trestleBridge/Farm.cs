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
                    ChickenHouse[index].AddResource((IFeeding)resource);
                    break;

                case "Duck":
                    DuckHouse[index].AddResource((IFeeding)resource);
                    break;

                case "Cow":
                    GrazingFields[index].AddResource((IFeeding)resource);
                    break;

                case "Goat":
                    GrazingFields[index].AddResource((IFeeding)resource);
                    break;

                case "Ostrich":
                    GrazingFields[index].AddResource((IFeeding)resource);
                    break;

                case "Pig":
                    GrazingFields[index].AddResource((IFeeding)resource);
                    break;

                case "Sheep":
                    GrazingFields[index].AddResource((IFeeding)resource);
                    break;

                default:
                    break;
            }
        }

        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));

            return report.ToString();
        }
    }
}
