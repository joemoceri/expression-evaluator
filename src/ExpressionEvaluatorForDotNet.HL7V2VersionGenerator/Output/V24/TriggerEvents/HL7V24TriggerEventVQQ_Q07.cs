using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventVQQ_Q07
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentVTQ vtq;
private readonly HL7V24SegmentRDF rdf;
private readonly HL7V24SegmentDSC dsc;


        public string Id { get { return @"VQQ_Q07"; } }
        public string MessageStructureId { get { return @"VQQ_Q07"; } }
        public string EventDescription { get { return @"Virtual table query"; } }

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

        public HL7V24TriggerEventVQQ_Q07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.vtq = new HL7V24SegmentVTQ(this.message);
this.rdf = new HL7V24SegmentRDF(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}