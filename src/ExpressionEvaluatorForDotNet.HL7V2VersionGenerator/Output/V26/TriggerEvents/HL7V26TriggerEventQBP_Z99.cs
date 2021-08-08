using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventQBP_Z99
    {
        private readonly HL7V2Message message;
        private readonly HL7V26SegmentMSH msh;
private readonly HL7V26SegmentSFT sft;
private readonly HL7V26SegmentUAC uac;
private readonly HL7V26SegmentQPD qpd;
private readonly HL7V26SegmentRDF rdf;
private readonly HL7V26SegmentRCP rcp;
private readonly HL7V26SegmentDSC dsc;


        public string Id { get { return @"QBP_Z99"; } }
        public string MessageStructureId { get { return @"QBP_Z99"; } }
        public string EventDescription { get { return @"Who Am I Query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

                    };
            }
        }

        public HL7V26TriggerEventQBP_Z99(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.qpd = new HL7V26SegmentQPD(this.message);
this.rdf = new HL7V26SegmentRDF(this.message);
this.rcp = new HL7V26SegmentRCP(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}