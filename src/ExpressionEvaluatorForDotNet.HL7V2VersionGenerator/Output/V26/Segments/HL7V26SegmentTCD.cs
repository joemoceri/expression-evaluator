using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentTCD
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"TCD"; } }

        public string SegmentId { get { return @"TCD"; } }
        
        public string LongName { get { return @"Test Code Detail"; } }
        
        public string Description { get { return @"The test code detail segment contains the data necessary to perform operations or calculations, or execute decisions by the laboratory automation system, and which are not supported by the original HL7 segments related to orders (ORC, OBR). For detail of use see messages of laboratory orders and observations in chapters 4 and 7."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",
                    };
            }
        }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"TCD.1",
                            Type = @"Field",
                            Position = @"TCD.1",
                            Name = @"Universal Service Identifier",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the test code that information is being transmitted about.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"TCD.1.1",
                            Type = @"Component",
                            Position = @"TCD.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.1.2",
                            Type = @"Component",
                            Position = @"TCD.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.1.3",
                            Type = @"Component",
                            Position = @"TCD.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.1.4",
                            Type = @"Component",
                            Position = @"TCD.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.1.5",
                            Type = @"Component",
                            Position = @"TCD.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.1.6",
                            Type = @"Component",
                            Position = @"TCD.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.1.7",
                            Type = @"Component",
                            Position = @"TCD.1.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.1.8",
                            Type = @"Component",
                            Position = @"TCD.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.1.9",
                            Type = @"Component",
                            Position = @"TCD.1.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.2",
                            Type = @"Field",
                            Position = @"TCD.2",
                            Name = @"Auto-Dilution Factor",
                            Length = 36,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SN",
                            DataTypeName = @"Structured Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the value that is to be used as the factor for automatically diluting a particular specimen by an instrument for this particular test code. (See examples in definition of 13.4.3.29, "" SAC-29 Dilution Factor(SN) 01356,"" in the ""Specimen Container Detail Segment."")",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"TCD.2.1",
                            Type = @"Component",
                            Position = @"TCD.2.1",
                            Name = @"Comparator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= "">"" or ""<"" or "">="" or ""<="" or ""="" or ""<>""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.2.2",
                            Type = @"Component",
                            Position = @"TCD.2.2",
                            Name = @"Num1",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.2.3",
                            Type = @"Component",
                            Position = @"TCD.2.3",
                            Name = @"Separator/Suffix",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"""-"" or ""+"" or ""/"" or ""."" or "":""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.2.4",
                            Type = @"Component",
                            Position = @"TCD.2.4",
                            Name = @"Num2",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.3",
                            Type = @"Field",
                            Position = @"TCD.3",
                            Name = @"Rerun Dilution Factor",
                            Length = 36,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SN",
                            DataTypeName = @"Structured Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the value that is to be used as the factor for automatically diluting a particular specimen in case of rerun for this particular test code.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"TCD.3.1",
                            Type = @"Component",
                            Position = @"TCD.3.1",
                            Name = @"Comparator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= "">"" or ""<"" or "">="" or ""<="" or ""="" or ""<>""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.3.2",
                            Type = @"Component",
                            Position = @"TCD.3.2",
                            Name = @"Num1",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.3.3",
                            Type = @"Component",
                            Position = @"TCD.3.3",
                            Name = @"Separator/Suffix",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"""-"" or ""+"" or ""/"" or ""."" or "":""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.3.4",
                            Type = @"Component",
                            Position = @"TCD.3.4",
                            Name = @"Num2",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.4",
                            Type = @"Field",
                            Position = @"TCD.4",
                            Name = @"Pre-Dilution Factor",
                            Length = 36,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SN",
                            DataTypeName = @"Structured Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the value that is to be used as the factor for a particular specimen that is delivered to the automated system as pre-diluted for this particular test code.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"TCD.4.1",
                            Type = @"Component",
                            Position = @"TCD.4.1",
                            Name = @"Comparator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= "">"" or ""<"" or "">="" or ""<="" or ""="" or ""<>""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.4.2",
                            Type = @"Component",
                            Position = @"TCD.4.2",
                            Name = @"Num1",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.4.3",
                            Type = @"Component",
                            Position = @"TCD.4.3",
                            Name = @"Separator/Suffix",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"""-"" or ""+"" or ""/"" or ""."" or "":""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.4.4",
                            Type = @"Component",
                            Position = @"TCD.4.4",
                            Name = @"Num2",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.5",
                            Type = @"Field",
                            Position = @"TCD.5",
                            Name = @"Endogenous Content of Pre-Dilution Diluent",
                            Length = 36,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SN",
                            DataTypeName = @"Structured Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field represents the rest concentration of the measured test in the diluent. It is the value that is to be used for calculation of the concentration of pre-diluted specimens for this particular test code.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"TCD.5.1",
                            Type = @"Component",
                            Position = @"TCD.5.1",
                            Name = @"Comparator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= "">"" or ""<"" or "">="" or ""<="" or ""="" or ""<>""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.5.2",
                            Type = @"Component",
                            Position = @"TCD.5.2",
                            Name = @"Num1",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.5.3",
                            Type = @"Component",
                            Position = @"TCD.5.3",
                            Name = @"Separator/Suffix",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"""-"" or ""+"" or ""/"" or ""."" or "":""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.5.4",
                            Type = @"Component",
                            Position = @"TCD.5.4",
                            Name = @"Num2",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.6",
                            Type = @"Field",
                            Position = @"TCD.6",
                            Name = @"Automatic Repeat Allowed",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field identifies whether or not automatic repeats are to be initiated for this particular specimen for this particular test code. Refer to HL7 Table 0136 -Yes/no indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.7",
                            Type = @"Field",
                            Position = @"TCD.7",
                            Name = @"Reflex Allowed",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field identifies whether or not automatic or manual reflex testing is to be initiated for this particular specimen. Refer to HL7 Table 0136 -Yes/no indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.8",
                            Type = @"Field",
                            Position = @"TCD.8",
                            Name = @"Analyte Repeat Status",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0389",
                            TableName = @"Analyte repeat status",
                            Description = @"This field identifies the repeat status for the analyte/result (e.g., original, rerun, repeat, reflex). Refer to HL7 Table 0389 - Analyte repeat status for valid values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"TCD.8.1",
                            Type = @"Component",
                            Position = @"TCD.8.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.8.2",
                            Type = @"Component",
                            Position = @"TCD.8.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.8.3",
                            Type = @"Component",
                            Position = @"TCD.8.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.8.4",
                            Type = @"Component",
                            Position = @"TCD.8.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.8.5",
                            Type = @"Component",
                            Position = @"TCD.8.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.8.6",
                            Type = @"Component",
                            Position = @"TCD.8.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.8.7",
                            Type = @"Component",
                            Position = @"TCD.8.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.8.8",
                            Type = @"Component",
                            Position = @"TCD.8.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.8.9",
                            Type = @"Component",
                            Position = @"TCD.8.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        };
            }
        }

        public HL7V26SegmentTCD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field universalServiceIdentifier;

public HL7V26Field UniversalServiceIdentifier
{
    get
    {
        if (universalServiceIdentifier != null)
        {
            return universalServiceIdentifier;
        }

        universalServiceIdentifier = new HL7V26Field
        {
            field = message[@"TCD"][1],
            Id = @"TCD.1",
            Type = @"Field",
            Position = @"TCD.1",
            Name = @"Universal Service Identifier",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the test code that information is being transmitted about.",
            Sample = @"",
        };

        

        

        

        return universalServiceIdentifier;
    } 
}
internal HL7V26Field autoDilutionFactor;

public HL7V26Field AutoDilutionFactor
{
    get
    {
        if (autoDilutionFactor != null)
        {
            return autoDilutionFactor;
        }

        autoDilutionFactor = new HL7V26Field
        {
            field = message[@"TCD"][2],
            Id = @"TCD.2",
            Type = @"Field",
            Position = @"TCD.2",
            Name = @"Auto-Dilution Factor",
            Length = 36,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the value that is to be used as the factor for automatically diluting a particular specimen by an instrument for this particular test code. (See examples in definition of 13.4.3.29, "" SAC-29 Dilution Factor(SN) 01356,"" in the ""Specimen Container Detail Segment."")",
            Sample = @"",
        };

        

        

        

        return autoDilutionFactor;
    } 
}
internal HL7V26Field rerunDilutionFactor;

public HL7V26Field RerunDilutionFactor
{
    get
    {
        if (rerunDilutionFactor != null)
        {
            return rerunDilutionFactor;
        }

        rerunDilutionFactor = new HL7V26Field
        {
            field = message[@"TCD"][3],
            Id = @"TCD.3",
            Type = @"Field",
            Position = @"TCD.3",
            Name = @"Rerun Dilution Factor",
            Length = 36,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the value that is to be used as the factor for automatically diluting a particular specimen in case of rerun for this particular test code.",
            Sample = @"",
        };

        

        

        

        return rerunDilutionFactor;
    } 
}
internal HL7V26Field preDilutionFactor;

public HL7V26Field PreDilutionFactor
{
    get
    {
        if (preDilutionFactor != null)
        {
            return preDilutionFactor;
        }

        preDilutionFactor = new HL7V26Field
        {
            field = message[@"TCD"][4],
            Id = @"TCD.4",
            Type = @"Field",
            Position = @"TCD.4",
            Name = @"Pre-Dilution Factor",
            Length = 36,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the value that is to be used as the factor for a particular specimen that is delivered to the automated system as pre-diluted for this particular test code.",
            Sample = @"",
        };

        

        

        

        return preDilutionFactor;
    } 
}
internal HL7V26Field endogenousContentofPreDilutionDiluent;

public HL7V26Field EndogenousContentofPreDilutionDiluent
{
    get
    {
        if (endogenousContentofPreDilutionDiluent != null)
        {
            return endogenousContentofPreDilutionDiluent;
        }

        endogenousContentofPreDilutionDiluent = new HL7V26Field
        {
            field = message[@"TCD"][5],
            Id = @"TCD.5",
            Type = @"Field",
            Position = @"TCD.5",
            Name = @"Endogenous Content of Pre-Dilution Diluent",
            Length = 36,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field represents the rest concentration of the measured test in the diluent. It is the value that is to be used for calculation of the concentration of pre-diluted specimens for this particular test code.",
            Sample = @"",
        };

        

        

        

        return endogenousContentofPreDilutionDiluent;
    } 
}
internal HL7V26Field automaticRepeatAllowed;

public HL7V26Field AutomaticRepeatAllowed
{
    get
    {
        if (automaticRepeatAllowed != null)
        {
            return automaticRepeatAllowed;
        }

        automaticRepeatAllowed = new HL7V26Field
        {
            field = message[@"TCD"][6],
            Id = @"TCD.6",
            Type = @"Field",
            Position = @"TCD.6",
            Name = @"Automatic Repeat Allowed",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field identifies whether or not automatic repeats are to be initiated for this particular specimen for this particular test code. Refer to HL7 Table 0136 -Yes/no indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return automaticRepeatAllowed;
    } 
}
internal HL7V26Field reflexAllowed;

public HL7V26Field ReflexAllowed
{
    get
    {
        if (reflexAllowed != null)
        {
            return reflexAllowed;
        }

        reflexAllowed = new HL7V26Field
        {
            field = message[@"TCD"][7],
            Id = @"TCD.7",
            Type = @"Field",
            Position = @"TCD.7",
            Name = @"Reflex Allowed",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field identifies whether or not automatic or manual reflex testing is to be initiated for this particular specimen. Refer to HL7 Table 0136 -Yes/no indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return reflexAllowed;
    } 
}
internal HL7V26Field analyteRepeatStatus;

public HL7V26Field AnalyteRepeatStatus
{
    get
    {
        if (analyteRepeatStatus != null)
        {
            return analyteRepeatStatus;
        }

        analyteRepeatStatus = new HL7V26Field
        {
            field = message[@"TCD"][8],
            Id = @"TCD.8",
            Type = @"Field",
            Position = @"TCD.8",
            Name = @"Analyte Repeat Status",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0389",
            TableName = @"Analyte repeat status",
            Description = @"This field identifies the repeat status for the analyte/result (e.g., original, rerun, repeat, reflex). Refer to HL7 Table 0389 - Analyte repeat status for valid values.",
            Sample = @"",
        };

        

        

        

        return analyteRepeatStatus;
    } 
}

    }
}
