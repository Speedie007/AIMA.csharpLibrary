using AIMA.CSharpLibrary.Common.DataStructure.Graph.Interface;

namespace AIMA.CSharpLibrary.Common.DataStructure.Graph.Base
{
    /// <summary>
    /// Represents the base class for entities
    /// </summary>
    public abstract partial class NodeBaseContextEntity : IBaseEntity
    {
        public NodeBaseContextEntity()
        {
            Id = 0;
        }
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        public int Id { get; set; }
    }
}
