using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventPEX_P07
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentSFT sft{get; init;}
public HL7V251SegmentEVN evn{get; init;}
public HL7V251SegmentPID pid{get; init;}
public HL7V251SegmentPD1 pd1{get; init;}
public HL7V251SegmentNTE nte{get; init;}


        public string Id { get { return @"PEX_P07"; } }
        public string MessageStructureId { get { return @"PEX_P07"; } }
        public string EventDescription { get { return @"Unsolicited initial individual product experience report"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V251TriggerEventPEX_P07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.evn = new HL7V251SegmentEVN(this.message);
this.pid = new HL7V251SegmentPID(this.message);
this.pd1 = new HL7V251SegmentPD1(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}
