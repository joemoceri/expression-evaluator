using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventDOC_T12
    {
        private readonly HL7V2Message message;
        private readonly HL7V251SegmentMSH msh;
private readonly HL7V251SegmentMSA msa;
private readonly HL7V251SegmentERR err;
private readonly HL7V251SegmentQAK qak;
private readonly HL7V251SegmentQRD qrd;
private readonly HL7V251SegmentDSC dsc;


        public string Id { get { return @"DOC_T12"; } }
        public string MessageStructureId { get { return @"DOC_T12"; } }
        public string EventDescription { get { return @"Document response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",

                    };
            }
        }

        public HL7V251TriggerEventDOC_T12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.err = new HL7V251SegmentERR(this.message);
this.qak = new HL7V251SegmentQAK(this.message);
this.qrd = new HL7V251SegmentQRD(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}