using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventRER_RER
    {
        private readonly HL7V2Message message;
        private readonly HL7V23SegmentMSH msh;
private readonly HL7V23SegmentMSA msa;
private readonly HL7V23SegmentERR err;
private readonly HL7V23SegmentDSC dsc;


        public string Id { get { return @"RER_RER"; } }
        public string MessageStructureId { get { return @"RER_RER"; } }
        public string EventDescription { get { return @"Pharmacy/treatment encoded order information response"; } }

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

        public HL7V23TriggerEventRER_RER(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.err = new HL7V23SegmentERR(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}