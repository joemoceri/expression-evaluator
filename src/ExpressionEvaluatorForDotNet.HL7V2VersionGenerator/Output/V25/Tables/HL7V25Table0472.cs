using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0472
    {
        public string Id { get { return @"0472"; } }

        public string TableId { get { return @"0472"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"TQ conjunction ID"; } }

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

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"A",
                            Description = @"Asynchronous",
                            Comment = @"Do the next specification in parallel with this one (unless otherwise constrained by the following components: ORC-7^4-start date/time and ORC-7^5-end date/time). The conjunction of “A” specifies two parallel instructions, as are sometimes used in medication, e.g., prednisone given at 1 tab on Monday, Wednesday, Friday, and at 1/2 tab on Tuesday, Thursday, Saturday, Sunday."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"This is an actuation time",
                            Comment = @"It will be followed by a completion time for the service. This code allows one to distinguish between the time and priority at which a service should be actuated (e.g., blood should be drawn) and the time and priority at which a service should be completed (e.g., results should be reported). For continuous or periodic services, the point at which the service is actually stopped is determined by the components ORC-7^5-end date/time and ORC-7^3-duration, whichever indicates an earlier stopping time. Ordinarily, only one of these components would be present, but if one requested an EKG with the specification  ^1^QAM^X3^D10 then the EKG would be done for only three days since the number of repeats (3) defined the earlier stopping time."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Synchronous.",
                            Comment = @"Do the next specification after this one (unless otherwise constrained by the following components: ORC-7^4-start date/time and ORC-7^5-end date/time). An “S” specification implies that the second timing sequence follows the first, e.g., when an order is written to measure blood pressure Q15 minutes for the 1st hour, then every 2 hours for the next day."
                        },
                    };
            } 
        }
    }
}
