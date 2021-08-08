using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventRCL_I06
    {
        private readonly HL7V2Message message;
        private readonly HL7V27SegmentMSH msh;
private readonly HL7V27SegmentSFT sft;
private readonly HL7V27SegmentUAC uac;
private readonly HL7V27SegmentMSA msa;
private readonly HL7V27SegmentQRD qrd;
private readonly HL7V27SegmentQRF qrf;
private readonly HL7V27SegmentPID pid;
private readonly HL7V27SegmentDG1 dg1;
private readonly HL7V27SegmentDRG drg;
private readonly HL7V27SegmentAL1 al1;
private readonly HL7V27SegmentNTE nte;
private readonly HL7V27SegmentDSP dsp;
private readonly HL7V27SegmentDSC dsc;


        public string Id { get { return @"RCL_I06"; } }
        public string MessageStructureId { get { return @"RCL_I06"; } }
        public string EventDescription { get { return @"Return clinical list"; } }

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

        public HL7V27TriggerEventRCL_I06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.msa = new HL7V27SegmentMSA(this.message);
this.qrd = new HL7V27SegmentQRD(this.message);
this.qrf = new HL7V27SegmentQRF(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.dg1 = new HL7V27SegmentDG1(this.message);
this.drg = new HL7V27SegmentDRG(this.message);
this.al1 = new HL7V27SegmentAL1(this.message);
this.nte = new HL7V27SegmentNTE(this.message);
this.dsp = new HL7V27SegmentDSP(this.message);
this.dsc = new HL7V27SegmentDSC(this.message);

        }
    }
}