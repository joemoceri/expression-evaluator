using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventRPI_I04
    {
        private readonly HL7V2Message message;
        private readonly HL7V271SegmentMSH msh;
private readonly HL7V271SegmentSFT sft;
private readonly HL7V271SegmentUAC uac;
private readonly HL7V271SegmentMSA msa;
private readonly HL7V271SegmentPID pid;
private readonly HL7V271SegmentNK1 nk1;
private readonly HL7V271SegmentNTE nte;


        public string Id { get { return @"RPI_I04"; } }
        public string MessageStructureId { get { return @"RPI_I04"; } }
        public string EventDescription { get { return @"Return Patient Demographic Data"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",

                    };
            }
        }

        public HL7V271TriggerEventRPI_I04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.nk1 = new HL7V271SegmentNK1(this.message);
this.nte = new HL7V271SegmentNTE(this.message);

        }
    }
}