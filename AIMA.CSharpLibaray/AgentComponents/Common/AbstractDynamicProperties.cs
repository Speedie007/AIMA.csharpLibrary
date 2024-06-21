using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;

namespace AIMA.CSharpLibrary.AgentComponents.Common
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class AbstractDynamicProperties : ICloneable, IComparer<AbstractDynamicProperties>
    {
        /// <summary>
        /// Data store for the Mapped Attributes.
        /// </summary>
        private Dictionary<object, object> DynamicAttributes;

        /// <summary>
        /// Constructor
        /// </summary>
        #region Cstor
        protected AbstractDynamicProperties()
        {
            DynamicAttributes = new Dictionary<object, object>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Bool Value indicating if there are any attributes configured/assigned.
        /// </summary>
        public virtual bool HasAttributes
        {
            get
            {
                return DynamicAttributes.Count > 0;
            }
        }
        /// <summary>
        /// By default, returns the simple name of the underlying class as given in the source code.the source code.
        /// </summary>
        /// <returns>return the simple name of the underlying Class or Enum</returns>
        public virtual Type DynamicAtrributeType()
        {
            return GetType();
        }
        /// <summary>
        /// Ge A representation of the object's current attributes in the form of A string.
        /// </summary>
        /// <returns>Returns A string representation of the object's current attributes</returns>
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
        /// <returns>An unmodifiable view of the object's PropertyKey Set</returns>
        public ImmutableHashSet<object> GetKeySet()
        {
            return DynamicAttributes.Keys.ToImmutableHashSet();
        }
        /// <summary>
        /// <para>
        /// Associates the specified value with the specified attribute PropertyKey.</para>
        /// <para>
        /// If the AbstractDynamicProperties previously contained A mapping for the attribute PropertyKey, the old value is replaced.
        /// </para>
        /// </summary>
        /// <param name="key">The attribute Key</param>
        /// <param name="value">The attribute Value</param>
        /// <returns>True if successfull, else false.</returns>
        public bool SetDynamicAttributeValue(object key, object value)
        {
            if (DynamicAttributes.ContainsKey(key))
            {
                DynamicAttributes[key] = value;
                return true;
            }
            else
                return DynamicAttributes.TryAdd<object, object>(key, value);

        }

        /// <summary>
        /// Retirvies the attibute value for A specified attribute PropertyKey.
        /// </summary>
        /// <param name="key">Attribute PropertyKey</param>
        /// <returns>Value of the specified attribute, or null if not found.</returns>
        public object GetAttributeValue(object key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            if (DynamicAttributes.TryGetValue(key, out object? attributeValue))
                return attributeValue;
            else return new();
        }

        /// <summary>
        /// Removes dynamic attribute with the specified PropertyKey.
        /// </summary>
        /// <param name="key">Attribute PropertyKey</param>
        /// <returns></returns>
        public bool RemoveDynamicAttribute(object key)
        {
            return DynamicAttributes.Remove(key);
        }


        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public object Clone()
        {
            AbstractDynamicProperties result;

            try
            {
                result = (AbstractDynamicProperties)MemberwiseClone();
                result.DynamicAttributes = new Dictionary<object, object>();
                foreach (var val in DynamicAttributes)
                    result.DynamicAttributes.Add(val.Key, val.Value);
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return new object();
        }


        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(DynamicAtrributeType().Name);
            sb.Append(GetDynamicAtrributesAvailable());

            return sb.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return obj != null && GetType() == obj.GetType()
               && DynamicAttributes.Equals(((AbstractDynamicProperties)obj).DynamicAttributes);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return DynamicAttributes.GetHashCode();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Compare(AbstractDynamicProperties? x, AbstractDynamicProperties? y)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
