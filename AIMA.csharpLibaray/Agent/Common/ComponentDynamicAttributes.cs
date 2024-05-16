using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;

namespace AIMA.csharpLibrary.Agent.Common
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class ComponentDynamicAttributes : ICloneable, IComparer<ComponentDynamicAttributes>
    {
        /// <summary>
        /// Data store for the Mapped Attributes.
        /// </summary>
        private Dictionary<object, object> DynamicAttributes;


        /// <summary>
        /// Constructor
        /// </summary>
        #region Cstor
        protected ComponentDynamicAttributes()
        {
            DynamicAttributes = new Dictionary<object, object>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// By default, returns the simple name of the underlying class as given in the source code.the source code.
        /// </summary>
        /// <returns>return the simple name of the underlying Class or Enum</returns>
        public virtual string DynamicAtrributeType()
        {
            return GetType().Name;
        }
        /// <summary>
        /// Ge a representation of the object's current attributes in the form of a string.
        /// </summary>
        /// <returns>Returns a string representation of the object's current attributes</returns>
        public virtual string GetDynamicAtrributesAvailable()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("[");
            bool first = true;
            foreach (var keyValuePair in DynamicAttributes)
            {
                if (first)
                    first = false;
                else
                    sb.Append(", ");

                sb.Append(keyValuePair.Key);
                sb.Append("=");
                sb.Append(keyValuePair.Value);
            }
            sb.Append("]");

            return sb.ToString();
        }

        /// <summary>
        /// Set of the Dynamic Attribute Keys.
        /// </summary>
        /// <returns>An unmodifiable view of the object's key set</returns>
        public ImmutableHashSet<object> getKeySet()
        {
            return DynamicAttributes.Keys.ToImmutableHashSet();
        }
        /// <summary>
        /// <para>
        /// Associates the specified value with the specified attribute key.</para>
        /// <para>
        /// If the ComponentDynamicAttributes previously contained a mapping for the attribute key, the old value is replaced.
        /// </para>
        /// </summary>
        /// <param name="key">The attribute Key</param>
        /// <param name="value">The attribute Value</param>
        /// <returns>True if successfull, else false.</returns>
        public bool SetDynamicAttributeValue(object key, object value)
        {
            if (!DynamicAttributes.ContainsKey(key))
            {
                DynamicAttributes[key] = value;
                return true;
            }
            else
                return DynamicAttributes.TryAdd<object, object>(key, value);

        }

        /// <summary>
        /// Retirvies the attibute value for a specified attribute key.
        /// </summary>
        /// <param name="key">Attribute key</param>
        /// <returns>Value of the specified attribute, or null if not found.</returns>
        public object? GetDynamicAttributeValue(object key)
        {
            if (DynamicAttributes.TryGetValue(key, out object? attributeKey))
                return attributeKey;
            else return default;
        }

        /// <summary>
        /// Removes dynamic attribute with the specified key.
        /// </summary>
        /// <param name="key">Attribute key</param>
        /// <returns></returns>
        public bool RemoveDynamicAttribute(object key)
        {
            return DynamicAttributes.Remove(key);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            ComponentDynamicAttributes result;

            try
            {
                result = (ComponentDynamicAttributes)MemberwiseClone();
                result.DynamicAttributes = new Dictionary<object, object>();
                foreach (var val in DynamicAttributes)
                    result.DynamicAttributes.Add(val.Key, val.Value);
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return default;
        }

        public int Compare(ComponentDynamicAttributes? x, ComponentDynamicAttributes? y)
        {
            throw new NotImplementedException();
        }

        public override string  ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(DynamicAtrributeType());
            sb.Append(GetDynamicAtrributesAvailable());

            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            return obj != null && GetType() == obj.GetType()
               && DynamicAttributes.Equals(((ComponentDynamicAttributes)obj).DynamicAttributes);
        }

        public override int GetHashCode()
        {
            return DynamicAttributes.GetHashCode();
        }

        #endregion

    }
}
