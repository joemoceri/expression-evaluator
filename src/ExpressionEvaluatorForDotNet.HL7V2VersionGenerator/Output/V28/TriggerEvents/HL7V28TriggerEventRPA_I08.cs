using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventRPA_I08
    {
        private readonly HL7V2Message message;
        private readonly HL7V28SegmentMSH msh;
private readonly HL7V28SegmentSFT sft;
private readonly HL7V28SegmentUAC uac;
private readonly HL7V28SegmentMSA msa;
private readonly HL7V28SegmentRF1 rf1;
private readonly HL7V28SegmentPID pid;
private readonly HL7V28SegmentNK1 nk1;
private readonly HL7V28SegmentGT1 gt1;
private readonly HL7V28SegmentACC acc;
private readonly HL7V28SegmentDG1 dg1;
private readonly HL7V28SegmentDRG drg;
private readonly HL7V28SegmentAL1 al1;
private readonly HL7V28SegmentNTE nte;


        public string Id { get { return @"RPA_I08"; } }
        public string MessageStructureId { get { return @"RPA_I08"; } }
        public string EventDescription { get { return @"Return patient authorization"; } }

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

        public HL7V28TriggerEventRPA_I08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.rf1 = new HL7V28SegmentRF1(this.message);
this.pid = new HL7V28SegmentPID(this.message);
this.nk1 = new HL7V28SegmentNK1(this.message);
this.gt1 = new HL7V28SegmentGT1(this.message);
this.acc = new HL7V28SegmentACC(this.message);
this.dg1 = new HL7V28SegmentDG1(this.message);
this.drg = new HL7V28SegmentDRG(this.message);
this.al1 = new HL7V28SegmentAL1(this.message);
this.nte = new HL7V28SegmentNTE(this.message);

        }
    }
}