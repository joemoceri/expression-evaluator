using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventQBP_Z77
    {
        private readonly HL7V2Message message;
        private readonly HL7V25SegmentMSH msh;
private readonly HL7V25SegmentSFT sft;
private readonly HL7V25SegmentQPD qpd;
private readonly HL7V25SegmentPID pid;
private readonly HL7V25SegmentRCP rcp;
private readonly HL7V25SegmentRDF rdf;
private readonly HL7V25SegmentDSC dsc;


        public string Id { get { return @"QBP_Z77"; } }
        public string MessageStructureId { get { return @"QBP_Z77"; } }
        public string EventDescription { get { return @"Query By Example - Tabular Patient List Query"; } }

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

        public HL7V25TriggerEventQBP_Z77(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.qpd = new HL7V25SegmentQPD(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.rcp = new HL7V25SegmentRCP(this.message);
this.rdf = new HL7V25SegmentRDF(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}