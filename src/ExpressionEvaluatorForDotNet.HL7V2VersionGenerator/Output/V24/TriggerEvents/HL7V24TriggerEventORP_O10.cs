using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventORP_O10
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentMSA msa;
private readonly HL7V24SegmentERR err;
private readonly HL7V24SegmentNTE nte;


        public string Id { get { return @"ORP_O10"; } }
        public string MessageStructureId { get { return @"ORP_O10"; } }
        public string EventDescription { get { return @"Pharmacy/treatment order acknowledgement"; } }

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

        public HL7V24TriggerEventORP_O10(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.err = new HL7V24SegmentERR(this.message);
this.nte = new HL7V24SegmentNTE(this.message);

        }
    }
}