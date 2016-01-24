using OOADExercise.Exercise_2.Enums;
using System.Collections.Generic;

namespace OOADExercise.Exercise_2_4___RicksGuitarInventory
{
    public class InstrumentSpec
    {
        private Dictionary<string, object> properties;

        public InstrumentSpec(Dictionary<string, object> properties) { 
            if (properties == null)
            {
                this.properties = new Dictionary<string, object>();
            }
            else
            {
                this.properties = new Dictionary<string, object>(properties);
            }
        }

        public InstrumentSpec() { }

        public object getProperty(string propertyName)
        {
            return this.properties[propertyName];
        }

        public Dictionary<string, object> getProperties()
        {
            return this.properties;
        }

        public virtual bool matches(InstrumentSpec otherSpec)
        {
            List<string> keyList = new List<string>(otherSpec.getProperties().Keys);
            foreach (string key in keyList)
            {
                if (!properties[key].Equals(otherSpec.getProperty(key)))
                    return false;
            }
            return true;

        }
    }
}