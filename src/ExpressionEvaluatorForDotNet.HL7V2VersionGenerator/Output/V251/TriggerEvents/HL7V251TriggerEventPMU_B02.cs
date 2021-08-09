using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventPMU_B02
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentSFT sft{get; init;}
public HL7V251SegmentEVN evn{get; init;}
public HL7V251SegmentSTF stf{get; init;}
public HL7V251SegmentPRA pra{get; init;}
public HL7V251SegmentORG org{get; init;}
public HL7V251SegmentAFF aff{get; init;}
public HL7V251SegmentLAN lan{get; init;}
public HL7V251SegmentEDU edu{get; init;}
public HL7V251SegmentCER cer{get; init;}


        public string Id { get { return @"PMU_B02"; } }
        public string MessageStructureId { get { return @"PMU_B02"; } }
        public string EventDescription { get { return @"Add personnel record"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",

                    };
            }
        }

        public HL7V251TriggerEventPMU_B02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.evn = new HL7V251SegmentEVN(this.message);
this.stf = new HL7V251SegmentSTF(this.message);
this.pra = new HL7V251SegmentPRA(this.message);
this.org = new HL7V251SegmentORG(this.message);
this.aff = new HL7V251SegmentAFF(this.message);
this.lan = new HL7V251SegmentLAN(this.message);
this.edu = new HL7V251SegmentEDU(this.message);
this.cer = new HL7V251SegmentCER(this.message);

        }
    }
}
