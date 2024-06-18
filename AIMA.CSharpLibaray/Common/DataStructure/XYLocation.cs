using AIMA.CSharpLibrary.Common.Enumerations;

namespace AIMA.CSharpLibrary.Common.DataStructure
{
    /// <summary>
    /// <remarks>
    /// Note: If looking at A rectangle - the coordinate (x=0, y=0) will be the top Left hand corner.
    /// </remarks>
    /// <para>
    /// Author:Ravi Mohan
    /// </para>
    /// <para>
    /// Author:Mike Stampone
    /// </para>
    /// <para>
    /// Author:Brendan Wood (Bsc. IT) - Complied C# Implementation - Supplemental
    /// </para>
    /// <para>Date Created: 11 May 2024 - Date Last Updated: 26 May 2024</para>
    /// </summary>
    public class XYLocation
    {
        #region Properties
        /// <summary>
        /// Returns the X coordinate of the location in integer precision.
        /// </summary>
        public int CurrentXCoOrdinate { get; private set; }
        /// <summary>
        /// Returns the Y coordinate of the location in integer precision.
        /// </summary>
        public int CurrentYCoOrdinate { get; private set; }
        #endregion

        #region Cstor
        /// <summary>
        /// <para>Constructs and initializes A location at the specified (<em>x</em>,<em>y</em>) location in the coordinate space.</para>
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        public XYLocation(int x, int y)
        {
            CurrentXCoOrdinate = x;
            CurrentYCoOrdinate = y;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the location one unit Left of this location.
        /// </summary>
        /// <returns>A new location one unit Left of this location</returns>
        public XYLocation West()
        {
            return new XYLocation(CurrentXCoOrdinate - 1, CurrentYCoOrdinate);
        }

        /// <summary>
        /// Returns the location one unit Right of this location.
        /// </summary>
        /// <returns>A new location one unit Right of this location.</returns>
        public XYLocation East()
        {
            return new XYLocation(CurrentXCoOrdinate + 1, CurrentYCoOrdinate);
        }

        /// <summary>
        /// Returns the location one unit ahead(Up),from this location.
        /// </summary>
        /// <returns>A new location one unit ahead(Up), from this location.</returns>
        public XYLocation North()
        {
            return new XYLocation(CurrentXCoOrdinate, CurrentYCoOrdinate - 1);
        }

        /// <summary>
        /// Returns the location one unit behind(Down), from this location.
        /// </summary>
        /// <returns>A new location one unit behind(Down), from this location.</returns>
        public XYLocation South()
        {
            return new XYLocation(CurrentXCoOrdinate, CurrentYCoOrdinate + 1);
        }

        /// <summary>
        /// Returns the location one unit Left of this location.
        /// </summary>
        /// <returns>A new location one unit Left of this location.</returns>
        public XYLocation Left()
        {
            return West();
        }

        /// <summary>
        /// Returns the location one unit Right of this location.
        /// </summary>
        /// <returns>A new location one unit Right of this location.</returns>
        public XYLocation Right()
        {
            return East();
        }

        /// <summary>
        /// Returns the location one unit ahead(Up),from this location.
        /// </summary>
        /// <returns>A new location one unit ahead(Up), from this location.</returns>
        public XYLocation Up()
        {
            return North();
        }

        /// <summary>
        /// Returns the location one unit behind(Down), from this location.
        /// </summary>
        /// <returns>A new location one unit behind(Down), from this location.</returns>
        public XYLocation Down()
        {
            return South();
        }

        /// <summary>
        /// Returns the location one unit from this location in the specified direction.
        /// </summary>
        /// <param name="direction">A new the location one unit from this location in the specified</param>
        /// <returns></returns>
        /// <exception cref="SystemException"></exception>
        public XYLocation LocationAt(CardinalDirection direction)
        {
            if (direction.Equals(CardinalDirection.North))
            {
                return North();
            }
            if (direction.Equals(CardinalDirection.South))
            {
                return South();
            }
            if (direction.Equals(CardinalDirection.East))
            {
                return East();
            }
            if (direction.Equals(CardinalDirection.West))
            {
                return West();
            }
            else
            {
                throw new NotImplementedException("Direction not yet implemented On the DOTO: List." + direction.ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (null == obj || !(obj is XYLocation))
            {
                return base.Equals(obj);
            }
            XYLocation anotherLoc = (XYLocation)obj;
            return ((anotherLoc.CurrentXCoOrdinate == CurrentXCoOrdinate) && (anotherLoc.CurrentYCoOrdinate == CurrentYCoOrdinate));
        }

        /// <summary>
        /// <para>Uses A Tuple object to ensure hte order of the hash code generation is consistant.</para>
        /// <remarks>
        /// See: https://learn.microsoft.com/en-us/dotnet/fundamentals/runtime-libraries/system-object-gethashcode</remarks>
        /// </summary>
        /// <returns>Hash Code for the XY Location</returns>
        public override int GetHashCode()
        {
            return Tuple.Create(CurrentXCoOrdinate, CurrentYCoOrdinate).GetHashCode(); ;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $"[X:{CurrentXCoOrdinate},Y:{CurrentYCoOrdinate}]";
        }
        #endregion

    }
}

