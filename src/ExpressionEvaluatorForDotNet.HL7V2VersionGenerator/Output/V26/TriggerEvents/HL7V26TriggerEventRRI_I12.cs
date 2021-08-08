using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventRRI_I12
    {
        private readonly HL7V2Message message;
        private readonly HL7V26SegmentMSH msh;
private readonly HL7V26SegmentSFT sft;
private readonly HL7V26SegmentUAC uac;
private readonly HL7V26SegmentMSA msa;
private readonly HL7V26SegmentRF1 rf1;
private readonly HL7V26SegmentPID pid;
private readonly HL7V26SegmentACC acc;
private readonly HL7V26SegmentDG1 dg1;
private readonly HL7V26SegmentDRG drg;
private readonly HL7V26SegmentAL1 al1;
private readonly HL7V26SegmentNTE nte;


        public string Id { get { return @"RRI_I12"; } }
        public string MessageStructureId { get { return @"RRI_I12"; } }
        public string EventDescription { get { return @"Patient Referral Response"; } }

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

        public HL7V26TriggerEventRRI_I12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.rf1 = new HL7V26SegmentRF1(this.message);
this.pid = new HL7V26SegmentPID(this.message);
this.acc = new HL7V26SegmentACC(this.message);
this.dg1 = new HL7V26SegmentDG1(this.message);
this.drg = new HL7V26SegmentDRG(this.message);
this.al1 = new HL7V26SegmentAL1(this.message);
this.nte = new HL7V26SegmentNTE(this.message);

        }
    }
}