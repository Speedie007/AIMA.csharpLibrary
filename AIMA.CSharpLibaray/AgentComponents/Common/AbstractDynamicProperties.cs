﻿using AIMA.CSharpLibrary.Common.Extensions;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;

namespace AIMA.CSharpLibrary.AgentComponents.Common
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class BaseDynamicProperties : ICloneable, IComparer<BaseDynamicProperties>
    {
        /// <summary>
        /// Data store for the Mapped Attributes.
        /// </summary>
        private Dictionary<object, object> DynamicAttributes;

        /// <summary>
        /// Constructor
        /// </summary>
        #region Cstor
        protected BaseDynamicProperties()
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
        public virtual Type DynamicAttributeType()
        {
            return GetType();
        }
        /// <summary>
        /// Ge A representation of the object's current attributes in the form of A string.
        /// </summary>
        /// <returns>Returns A string representation of the object's current attributes</returns>
        public virtual string GetDynamicAttributesAvailable()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("[");
            bool first = true;
            foreach (var keyValuePair in DynamicAttributes)
            {
                if (first)
                    first = false;
                else
                    sb.AppendLine(", ");

                sb.Append(keyValuePair.Key.ToString());
                sb.Append("=");
                sb.Append(keyValuePair.Value.ToString());
            }
            sb.AppendLine("]");
         

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
        /// If the BaseDynamicProperties previously contained A mapping for the attribute PropertyKey, the old value is replaced.
        /// </para>
        /// </summary>
        /// <param name="key">The attribute Key</param>
        /// <param name="value">The attribute Value</param>
        /// <returns>True if successful, else false.</returns>
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
        /// Retrieves the attribute value for A specified attribute PropertyKey.
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
            BaseDynamicProperties result;

            try
            {
                result = (BaseDynamicProperties)MemberwiseClone();
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

            sb.AppendLine(DynamicAttributeType().Name);
            sb.Append(GetDynamicAttributesAvailable());

            return sb.ToString().FormatStringToHaveSpaces();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return obj != null && GetType() == obj.GetType()
               && DynamicAttributes.Equals(((BaseDynamicProperties)obj).DynamicAttributes);
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
        public int Compare(BaseDynamicProperties? x, BaseDynamicProperties? y)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
