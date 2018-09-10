using System.Diagnostics;
using b2xtranslator.StructuredStorage.Reader;

namespace b2xtranslator.Spreadsheet.XlsFileFormat.Ptg
{
    public class PtgAttrSpace : AbstractPtg
    {
        public const Ptg0x19Sub ID = Ptg0x19Sub.PtgAttrSpace;

        public PtgAttrSpace(IStreamReader reader, Ptg0x19Sub ptgid)
            :
            base(reader, ptgid)
        {
            Debug.Assert((Ptg0x19Sub)this.Id == ID);
            this.Length = 4;
            this.Data = "Space";
            this.type = PtgType.Operator;
            this.popSize = 1;
            this.Reader.ReadBytes(2);
        }
    }
}


