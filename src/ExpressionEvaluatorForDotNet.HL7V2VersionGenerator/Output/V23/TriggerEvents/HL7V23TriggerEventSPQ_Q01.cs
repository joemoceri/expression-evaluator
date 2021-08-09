using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventSPQ_Q01
    {
        private readonly HL7V2Message message;
        public HL7V23SegmentMSH msh{get; init;}
public HL7V23SegmentSPR spr{get; init;}
public HL7V23SegmentRDF rdf{get; init;}
public HL7V23SegmentDSC dsc{get; init;}


        public string Id { get { return @"SPQ_Q01"; } }
        public string MessageStructureId { get { return @"SPQ_Q01"; } }
        public string EventDescription { get { return @"Stored procedure request"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

                    };
            }
        }

        public HL7V23TriggerEventSPQ_Q01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.spr = new HL7V23SegmentSPR(this.message);
this.rdf = new HL7V23SegmentRDF(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}
