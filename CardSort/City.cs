using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CardSort
{
    /// <summary>
    /// Описание города 
    /// </summary>
    public class City
    {
        /// <summary>
        /// Наименование города
        /// </summary>
        public string Name { get; private set; }

        public City(string name)
        {
            this.Name = name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (Object.ReferenceEquals(this, null))
                return false;
            if (Object.ReferenceEquals(obj, null))
                return false;

            var t1 = obj.GetType();
            var t2 = this.GetType();

            if (t1 != t2)
                return false;

            foreach (var prop in t2.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                var val1 = prop.GetValue(obj, null);
                var val2 = prop.GetValue(this, null);

                if (val1 == null &&
                    val2 == null)
                {
                    continue;
                }

                if (val1 == null ||
                    val2 == null ||
                    !val1.Equals(val2))
                {
                    return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
