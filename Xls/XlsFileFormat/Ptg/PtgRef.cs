using System.Diagnostics;
using b2xtranslator.StructuredStorage.Reader;
using b2xtranslator.Tools;

namespace b2xtranslator.Spreadsheet.XlsFileFormat.Ptg
{
    public class PtgRef : AbstractPtg
    {
        public const PtgNumber ID = PtgNumber.PtgRef;

        public ushort rw;
        public ushort col;

        public bool colRelative;
        public bool rwRelative; 

        public PtgRef(IStreamReader reader, PtgNumber ptgid)
            :
            base(reader, ptgid)
        {
            Debug.Assert(this.Id == ID);
            this.Length = 5;
            this.rw = this.Reader.ReadUInt16(); 
            this.col = this.Reader.ReadUInt16();
            this.colRelative = Utils.BitmaskToBool(this.col, 0x4000);
            this.rwRelative = Utils.BitmaskToBool(this.col, 0x8000);

            this.col = (ushort)(this.col & 0x3FFF);
            

            this.type = PtgType.Operand;
            this.popSize = 1;
        }
    }
}
