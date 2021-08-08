using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventRPA_I10
    {
        private readonly HL7V2Message message;
        private readonly HL7V25SegmentMSH msh;
private readonly HL7V25SegmentSFT sft;
private readonly HL7V25SegmentMSA msa;
private readonly HL7V25SegmentRF1 rf1;
private readonly HL7V25SegmentPID pid;
private readonly HL7V25SegmentNK1 nk1;
private readonly HL7V25SegmentGT1 gt1;
private readonly HL7V25SegmentACC acc;
private readonly HL7V25SegmentDG1 dg1;
private readonly HL7V25SegmentDRG drg;
private readonly HL7V25SegmentAL1 al1;
private readonly HL7V25SegmentNTE nte;


        public string Id { get { return @"RPA_I10"; } }
        public string MessageStructureId { get { return @"RPA_I10"; } }
        public string EventDescription { get { return @"Request for resubmission of an authorization acknowledgement"; } }

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

        public HL7V25TriggerEventRPA_I10(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.rf1 = new HL7V25SegmentRF1(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.nk1 = new HL7V25SegmentNK1(this.message);
this.gt1 = new HL7V25SegmentGT1(this.message);
this.acc = new HL7V25SegmentACC(this.message);
this.dg1 = new HL7V25SegmentDG1(this.message);
this.drg = new HL7V25SegmentDRG(this.message);
this.al1 = new HL7V25SegmentAL1(this.message);
this.nte = new HL7V25SegmentNTE(this.message);

        }
    }
}
