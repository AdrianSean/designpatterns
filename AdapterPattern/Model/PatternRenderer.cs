using AdapterPattern.Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Model
{
    public class PatternRenderer
    {
        private readonly IDataPatternRendererAdapater _dataPatternRenderer;

        public PatternRenderer() : this (new DataPatternRendererAdapter())
        {

        }


        public PatternRenderer(IDataPatternRendererAdapater dataPatternRenderer)
        {
            _dataPatternRenderer = dataPatternRenderer;
        }

        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            return _dataPatternRenderer.ListPatterns(patterns);
        }
    }

    public interface IDataPatternRendererAdapater
    {
        string ListPatterns(IEnumerable<Pattern> patterns);
    }

    public class DataPatternRendererAdapter : IDataPatternRendererAdapater
    {
        private DataRenderer _dataRender;

        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            var adapter = new PatternCollectionDbAdapter(patterns);
            _dataRender = new DataRenderer(adapter);

            var writer = new StringWriter();
            _dataRender.Render(writer);

            return writer.ToString();
        }




        internal class PatternCollectionDbAdapter : IDbDataAdapter
        {

            private readonly IEnumerable<Pattern> _patterns;

            public PatternCollectionDbAdapter(IEnumerable<Pattern> patterns)
            {
                _patterns = patterns;
            }

            public int Fill(DataSet dataSet)
            {
                var myDataTable = new DataTable();
                myDataTable.Columns.Add(new DataColumn("Id", typeof(int)));
                myDataTable.Columns.Add(new DataColumn("Name", typeof(string)));
                myDataTable.Columns.Add(new DataColumn("Description", typeof(string)));


                foreach (var pattern in _patterns)
                {
                    var myRow = myDataTable.NewRow();
                    myRow[0] = pattern.Id;
                    myRow[1] = pattern.Name;
                    myRow[2] = pattern.Description;
                    myDataTable.Rows.Add(myRow);
                }
                
                dataSet.Tables.Add(myDataTable);
                dataSet.AcceptChanges();

                return 1;
            }
            

            #region Not Implemented
            public IDbCommand DeleteCommand
            {
                get
                {
                    throw new NotImplementedException();
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            public IDbCommand InsertCommand
            {
                get
                {
                    throw new NotImplementedException();
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            public MissingMappingAction MissingMappingAction
            {
                get
                {
                    throw new NotImplementedException();
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            public MissingSchemaAction MissingSchemaAction
            {
                get
                {
                    throw new NotImplementedException();
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            public IDbCommand SelectCommand
            {
                get
                {
                    throw new NotImplementedException();
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            public ITableMappingCollection TableMappings
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public IDbCommand UpdateCommand
            {
                get
                {
                    throw new NotImplementedException();
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            

            public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
            {
                throw new NotImplementedException();
            }

            public IDataParameter[] GetFillParameters()
            {
                throw new NotImplementedException();
            }

            public int Update(DataSet dataSet)
            {
                throw new NotImplementedException();
            }

            #endregion
        }
    }
}
