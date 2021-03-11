using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BismNormalizer.TabularCompare.TabularMetadata
{
    /// <summary>
    /// Represents a collection of Relationship objects.
    /// </summary>
    public class ColumnCollection : List<Column>
    {
        /// <summary>
        /// Find an object in the collection by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Relationship object if found. Null if not found.</returns>
        public Column FindByName(string name)
        {
            foreach (Column column in this)
            {
                if (column.Name == name)
                {
                    return column;
                }
            }
            return null;
        }

        /// <summary>
        /// Find an object in the collection by internal name.
        /// </summary>
        /// <param name="internalName"></param>
        /// <returns>Relationship object if found. Null if not found.</returns>
        public Column FindByInternalName(string internalName)
        {
            foreach (Column column in this)
            {
                if (column.InternalName == internalName)
                {
                    return column;
                }
            }
            return null;
        }

        /// <summary>
        /// A Boolean specifying whether the collection contains object by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>True if the object is found, or False if it's not found.</returns>
        public bool ContainsName(string name)
        {
            foreach (Column column in this)
            {
                if (column.Name == name.Trim())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// A Boolean specifying whether the collection contains object by internal name.
        /// </summary>
        /// <param name="internalName"></param>
        /// <returns>True if the object is found, or False if it's not found.</returns>
        public bool ContainsInternalName(string internalName)
        {
            foreach (Column column in this)
            {
                if (column.InternalName == internalName)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Removes an object from the collection by its name.
        /// </summary>
        /// <param name="internalName"></param>
        /// <returns>True if the object was removed, or False if was not found.</returns>
        public bool RemoveByName(string name)
        {
            foreach (Column column in this)
            {
                if (column.Name == name)
                {
                    this.Remove(column);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Removes an object from the collection by its internal name.
        /// </summary>
        /// <param name="internalName"></param>
        /// <returns>True if the object was removed, or False if was not found.</returns>
        public bool RemoveByInternalName(string internalName)
        {
            foreach (Column column in this)
            {
                if (column.InternalName == internalName)
                {
                    this.Remove(column);
                    return true;
                }
            }
            return false;
        }
    }
}
