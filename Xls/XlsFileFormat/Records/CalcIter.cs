using System.Diagnostics;
using b2xtranslator.StructuredStorage.Reader;

namespace b2xtranslator.Spreadsheet.XlsFileFormat.Records
{
    /// <summary>
    /// NOTE: This record is named ITERATION in the old version of the specification
    /// </summary>
    [BiffRecord(RecordType.CalcIter)] 
    public class CalcIter : BiffRecord
    {
        public const RecordType ID = RecordType.CalcIter;

        public CalcIter(IStreamReader reader, RecordType id, ushort length)
            : base(reader, id, length)
        {
            // assert that the correct record type is instantiated
            Debug.Assert(this.Id == ID);

            // initialize class members from stream
            // TODO: place code here
            
            // assert that the correct number of bytes has been read from the stream
            Debug.Assert(this.Offset + this.Length == this.Reader.BaseStream.Position); 
        }
    }
}
