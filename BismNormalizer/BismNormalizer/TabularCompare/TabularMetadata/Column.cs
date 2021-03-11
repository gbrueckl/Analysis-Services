using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tom = Microsoft.AnalysisServices.Tabular;

namespace BismNormalizer.TabularCompare.TabularMetadata
{
    /// <summary>
    /// Abstraction of a tabular model relationship with properties and methods for comparison purposes.
    /// </summary>
    public class Column : TabularObject
    {
        private Table _parentTable;
        private Tom.Column _tomColumn;

        /// <summary>
        /// Initializes a new instance of the Relationship class using multiple parameters.
        /// </summary>
        /// <param name="table">Table object that the Relationship belongs to.</param>
        /// <param name="tomRelationship">Tabular Object Model SingleColumnRelationship object abtstracted by the Relationship class.</param>
        /// <param name="copiedFromSource">Boolean indicating whether the relationship was copied from the source TabularModel object.</param>
        /// <param name="modifiedInternalName">Boolean indicating whether the TOM Relationship object Name property was changed to avoid name conflict.</param>
        /// <param name="oldInternalName">If the TOM Relationship object Name property was changed, this parameter shows the old value.</param>
        public Column(Table parentTable, Tom.Column tomColumn) 
            : base(tomColumn, parentTable.Name)
        {
            _parentTable = parentTable;
            _tomColumn = tomColumn;
        }

        /// <summary>
        /// Table object that the Relationship oject belongs to.
        /// </summary>
        public Table ParentTable => _parentTable;

        /// <summary>
        /// Tabular Object Model SingleColumnRelationship object abtstracted by the Relationship class.
        /// </summary>
        public Tom.Column TomColumn
        {
            get { return _tomColumn; }
            set { _tomColumn = value; }
        }

        /// <summary>
        /// Name of the Relationship object. Uses a friendly format.
        /// </summary>
        public override string Name => _tomColumn.Name;

        /// <summary>
        /// The TOM Relationship object Name property, which is not displayed to users as its of GUID format.
        /// </summary>
        public override string InternalName => _tomColumn.Name;

        /// <summary>
        /// Name of the from table for the Relationship object.
        /// </summary>
        public Tom.DataType DataType => _tomColumn.DataType;

        /// <summary>
        /// Name of the to table for the Relationship object.
        /// </summary>
        public string SourceProviderType => _tomColumn.SourceProviderType;


        public override string ToString() => $"'{base.ParentName}'[{Name}]";
    }
}
