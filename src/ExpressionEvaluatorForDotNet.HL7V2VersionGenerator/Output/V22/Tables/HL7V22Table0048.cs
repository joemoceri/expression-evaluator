using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0048
    {
        public string Id { get { return @"0048"; } }

        public string TableId { get { return @"0048"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"WHAT SUBJECT FILTER"; } }

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

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"ADV",
                            Description = @"Advice / diagnosis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANU",
                            Description = @"Nursing unit lookup (returns patients in beds, excluding empty beds)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"APA",
                            Description = @"Account number query, return matching visit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"APM",
                            Description = @"Medical record number query, returns visits for a medical record number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"APN",
                            Description = @"Patient name lookup",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"APP",
                            Description = @"Physician lookup",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ARN",
                            Description = @"Nursing unit lookup (returns patients in beds, including empty beds)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CAN",
                            Description = @"Cancel (used to cancel a query)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEM",
                            Description = @"Demographics",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FIN",
                            Description = @"Financial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MFQ",
                            Description = @"Master file query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MRI",
                            Description = @"Most recent inpatient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MRO",
                            Description = @"Most recent outpatient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NCK",
                            Description = @"Network clock",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NSC",
                            Description = @"Network status change",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NST",
                            Description = @"Network statistic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORD",
                            Description = @"Order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OTH",
                            Description = @"Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRO",
                            Description = @"Procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RAR",
                            Description = @"Pharmacy administration information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RDR",
                            Description = @"Pharmacy dispense information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RER",
                            Description = @"Pharmacy encoded order information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RES",
                            Description = @"Result",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RGR",
                            Description = @"Pharmacy give information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ROR",
                            Description = @"Pharmacy prescription information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"STA",
                            Description = @"Status",
                            Comment = null
                        },
                    };
            } 
        }
    }
}