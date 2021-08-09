using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventOSR_Q06
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentMSA msa{get; init;}
public HL7V251SegmentERR err{get; init;}
public HL7V251SegmentSFT sft{get; init;}
public HL7V251SegmentNTE nte{get; init;}
public HL7V251SegmentQRD qrd{get; init;}
public HL7V251SegmentQRF qrf{get; init;}
public HL7V251SegmentDSC dsc{get; init;}


        public string Id { get { return @"OSR_Q06"; } }
        public string MessageStructureId { get { return @"OSR_Q06"; } }
        public string EventDescription { get { return @"Query Response for Order Status"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V251TriggerEventOSR_Q06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.err = new HL7V251SegmentERR(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.nte = new HL7V251SegmentNTE(this.message);
this.qrd = new HL7V251SegmentQRD(this.message);
this.qrf = new HL7V251SegmentQRF(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}
