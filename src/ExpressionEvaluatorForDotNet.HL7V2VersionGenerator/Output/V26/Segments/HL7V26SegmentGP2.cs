using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentGP2
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"GP2"; } }

        public string SegmentId { get { return @"GP2"; } }
        
        public string LongName { get { return @"Grouping/Reimbursement - Procedure Line Item"; } }
        
        public string Description { get { return @"This segment is used for items that pertain to each HCPC/CPT line item.

The GP2 segment is specific to the US and may not be implemented in non-US systems."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
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
                            Id = @"GP2.1",
                            Type = @"Field",
                            Position = @"GP2.1",
                            Name = @"Revenue Code",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0456",
                            TableName = @"Revenue code",
                            Description = @"This field identifies a specific ancillary service for each HCPC/CPT This field is the same as UB92 Form Locator 42 ""Revenue Code"". Refer to User-defined Table 0456 - Revenue Code for suggested values. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.2",
                            Type = @"Field",
                            Position = @"GP2.2",
                            Name = @"Number of Service Units",
                            Length = 7,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the quantitative count of units for each HCPC/CPT. This field is the same as UB92 Form Locator 46 ""Units of Service"". This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.3",
                            Type = @"Field",
                            Position = @"GP2.3",
                            Name = @"Charge",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CP",
                            DataTypeName = @"Composite Price",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the amount charged for the specific individual line item (HCPC/CPT). This field is the same as UB92 Form Locator 56. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GP2.3.1",
                            Type = @"Component",
                            Position = @"GP2.3.1",
                            Name = @"Price",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. Note that each component of the MO data type (Section 2.A.41, ""MO - money"") is a subcomponent here.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GP2.3.1.1",
                            Type = @"SubComponent",
                            Position = @"GP2.3.1.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.3.1.2",
                            Type = @"SubComponent",
                            Position = @"GP2.3.1.2",
                            Name = @"Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, ""MSH-17-country code"", in section 2.14.9.17, is used to determine the default.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.3.2",
                            Type = @"Component",
                            Position = @"GP2.3.2",
                            Name = @"Price Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID. Refer to HL7 Table 0205 - Price type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.3.3",
                            Type = @"Component",
                            Position = @"GP2.3.3",
                            Name = @"From Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is a NM data type; together they specify the ""range"". The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.3.4",
                            Type = @"Component",
                            Position = @"GP2.3.4",
                            Name = @"To Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See <from value>.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.3.5",
                            Type = @"Component",
                            Position = @"GP2.3.5",
                            Name = @"Range Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CWE, defined by the standard table of units for either time or quantity (see for example, the tables in Section 7.1.4, ""Coding schemes""). This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and <to value> are present.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GP2.3.5.1",
                            Type = @"SubComponent",
                            Position = @"GP2.3.5.1",
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
                            Id = @"GP2.3.5.2",
                            Type = @"SubComponent",
                            Position = @"GP2.3.5.2",
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
                            Id = @"GP2.3.5.3",
                            Type = @"SubComponent",
                            Position = @"GP2.3.5.3",
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
                            Id = @"GP2.3.5.4",
                            Type = @"SubComponent",
                            Position = @"GP2.3.5.4",
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
                            Id = @"GP2.3.5.5",
                            Type = @"SubComponent",
                            Position = @"GP2.3.5.5",
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
                            Id = @"GP2.3.5.6",
                            Type = @"SubComponent",
                            Position = @"GP2.3.5.6",
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
                            Id = @"GP2.3.5.7",
                            Type = @"SubComponent",
                            Position = @"GP2.3.5.7",
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
                            Id = @"GP2.3.5.8",
                            Type = @"SubComponent",
                            Position = @"GP2.3.5.8",
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
                            Id = @"GP2.3.5.9",
                            Type = @"SubComponent",
                            Position = @"GP2.3.5.9",
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
                            Id = @"GP2.3.6",
                            Type = @"Component",
                            Position = @"GP2.3.6",
                            Name = @"Range Type",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.4",
                            Type = @"Field",
                            Position = @"GP2.4",
                            Name = @"Reimbursement Action Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0459",
                            TableName = @"Reimbursement Action Code",
                            Description = @"This field identifies the action to be taken during reimbursement calculations. If valued, this code overrides the value in GP2-6 - OCE Edit Code. Refer to User-defined Table 0459 - Reimbursement Action Code for suggested values. This field is defined by CMS or other regulatory agencies",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.5",
                            Type = @"Field",
                            Position = @"GP2.5",
                            Name = @"Denial or Rejection Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0460",
                            TableName = @"Denial or Rejection Code",
                            Description = @"This field determines the OCE status of the line item. Refer to User-defined table 0460 - Denial or Rejection Code for suggested values. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.6",
                            Type = @"Field",
                            Position = @"GP2.6",
                            Name = @"OCE Edit Code",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0458",
                            TableName = @"OCE Edit Code",
                            Description = @"This field contains the edit that results from the processing of HCPCS/CPT procedures for a line item HCPCS/CPT, after evaluating all the codes, revenue codes, and modifiers. Refer to User-defined table 0458 - OCE Edit Code for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.7",
                            Type = @"Field",
                            Position = @"GP2.7",
                            Name = @"Ambulatory Payment Classification Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0466",
                            TableName = @"Ambulatory Payment Classification Code",
                            Description = @"This field contains the derived APC code. This is the APC code used for payment, which is the same as the assigned APC, for all situations except partial hospitalization. If partial hospitalization is billed in this visit, the assigned APC will differ from the APC used for payment. Partial hospitalization is the only time an assigned APC differs from the APC used for payment. The payment APC is used for billing and should be displayed in this field. The first component contains the APC identifier. The second component reports the text description for the APC group. Refer to User-defined table 0466 - Ambulatory Payment Classification Code for suggested values. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GP2.7.1",
                            Type = @"Component",
                            Position = @"GP2.7.1",
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
                            Id = @"GP2.7.2",
                            Type = @"Component",
                            Position = @"GP2.7.2",
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
                            Id = @"GP2.7.3",
                            Type = @"Component",
                            Position = @"GP2.7.3",
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
                            Id = @"GP2.7.4",
                            Type = @"Component",
                            Position = @"GP2.7.4",
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
                            Id = @"GP2.7.5",
                            Type = @"Component",
                            Position = @"GP2.7.5",
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
                            Id = @"GP2.7.6",
                            Type = @"Component",
                            Position = @"GP2.7.6",
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
                            Id = @"GP2.7.7",
                            Type = @"Component",
                            Position = @"GP2.7.7",
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
                            Id = @"GP2.7.8",
                            Type = @"Component",
                            Position = @"GP2.7.8",
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
                            Id = @"GP2.7.9",
                            Type = @"Component",
                            Position = @"GP2.7.9",
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
                            Id = @"GP2.8",
                            Type = @"Field",
                            Position = @"GP2.8",
                            Name = @"Modifier Edit Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0467",
                            TableName = @"Modifier Edit Code",
                            Description = @"This field contains calculated edits of the modifiers for each line or HCPCS/CPT. This field can be repeated up to five times, one edit for each of the modifiers present. This field relates to the values in PR1-16 - Procedure Code Modifier . Each repetition corresponds positionally to the order of the PR1-16 modifier codes. If no modifier code exists, use the code U (modifier edit code unknown) as a placeholder. The repetitions of Modifier Edit Codes must match the repetitions of Procedure Code Modifiers. For example, if PR1-16 - Procedure Code Modifier reports ...|01~02~03~04|... as modifier codes, and modifier code 03 modifier status code is unknown, GP2-8 - Modifier Edit Code would report ...|1~1~U~1|... Refer to User-defined table 0467 - Modifier Edit Code for suggested values. This field is defined by CMS or other regulatory agencies",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.9",
                            Type = @"Field",
                            Position = @"GP2.9",
                            Name = @"Payment Adjustment Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0468",
                            TableName = @"Payment Adjustment Code",
                            Description = @"This field contains any payment adjustment due to drugs or medical devices. Refer to User-defined Table 0468 - Payment Adjustment Codefor suggested values. This field is defined by CMS or other regulatory agencies",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.10",
                            Type = @"Field",
                            Position = @"GP2.10",
                            Name = @"Packaging Status Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0469",
                            TableName = @"Packaging Status Code",
                            Description = @"This field contains the packaging status of the service. A status indicator of N may accompany this, unless it is part of a partial hospitalization. Refer to User defined (CMS) Table 0469 - Packaging Status Code for suggested values. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.11",
                            Type = @"Field",
                            Position = @"GP2.11",
                            Name = @"Expected CMS Payment Amount",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CP",
                            DataTypeName = @"Composite Price",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the calculated dollar amount that CMS is expected to pay for the line item.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GP2.11.1",
                            Type = @"Component",
                            Position = @"GP2.11.1",
                            Name = @"Price",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. Note that each component of the MO data type (Section 2.A.41, ""MO - money"") is a subcomponent here.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GP2.11.1.1",
                            Type = @"SubComponent",
                            Position = @"GP2.11.1.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.11.1.2",
                            Type = @"SubComponent",
                            Position = @"GP2.11.1.2",
                            Name = @"Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, ""MSH-17-country code"", in section 2.14.9.17, is used to determine the default.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.11.2",
                            Type = @"Component",
                            Position = @"GP2.11.2",
                            Name = @"Price Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID. Refer to HL7 Table 0205 - Price type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.11.3",
                            Type = @"Component",
                            Position = @"GP2.11.3",
                            Name = @"From Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is a NM data type; together they specify the ""range"". The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.11.4",
                            Type = @"Component",
                            Position = @"GP2.11.4",
                            Name = @"To Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See <from value>.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.11.5",
                            Type = @"Component",
                            Position = @"GP2.11.5",
                            Name = @"Range Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CWE, defined by the standard table of units for either time or quantity (see for example, the tables in Section 7.1.4, ""Coding schemes""). This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and <to value> are present.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GP2.11.5.1",
                            Type = @"SubComponent",
                            Position = @"GP2.11.5.1",
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
                            Id = @"GP2.11.5.2",
                            Type = @"SubComponent",
                            Position = @"GP2.11.5.2",
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
                            Id = @"GP2.11.5.3",
                            Type = @"SubComponent",
                            Position = @"GP2.11.5.3",
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
                            Id = @"GP2.11.5.4",
                            Type = @"SubComponent",
                            Position = @"GP2.11.5.4",
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
                            Id = @"GP2.11.5.5",
                            Type = @"SubComponent",
                            Position = @"GP2.11.5.5",
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
                            Id = @"GP2.11.5.6",
                            Type = @"SubComponent",
                            Position = @"GP2.11.5.6",
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
                            Id = @"GP2.11.5.7",
                            Type = @"SubComponent",
                            Position = @"GP2.11.5.7",
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
                            Id = @"GP2.11.5.8",
                            Type = @"SubComponent",
                            Position = @"GP2.11.5.8",
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
                            Id = @"GP2.11.5.9",
                            Type = @"SubComponent",
                            Position = @"GP2.11.5.9",
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
                            Id = @"GP2.11.6",
                            Type = @"Component",
                            Position = @"GP2.11.6",
                            Name = @"Range Type",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.12",
                            Type = @"Field",
                            Position = @"GP2.12",
                            Name = @"Reimbursement Type Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0470",
                            TableName = @"Reimbursement Type Code",
                            Description = @"This field contains the fee schedule reimbursement type applied to the line item. Refer to User-defined Table 0470 - Reimbursement Type Code for suggested values. This field is defined by CMS or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.13",
                            Type = @"Field",
                            Position = @"GP2.13",
                            Name = @"Co-Pay Amount",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CP",
                            DataTypeName = @"Composite Price",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the patient's Co-pay amount for the line item.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GP2.13.1",
                            Type = @"Component",
                            Position = @"GP2.13.1",
                            Name = @"Price",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. Note that each component of the MO data type (Section 2.A.41, ""MO - money"") is a subcomponent here.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GP2.13.1.1",
                            Type = @"SubComponent",
                            Position = @"GP2.13.1.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.13.1.2",
                            Type = @"SubComponent",
                            Position = @"GP2.13.1.2",
                            Name = @"Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, ""MSH-17-country code"", in section 2.14.9.17, is used to determine the default.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.13.2",
                            Type = @"Component",
                            Position = @"GP2.13.2",
                            Name = @"Price Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID. Refer to HL7 Table 0205 - Price type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.13.3",
                            Type = @"Component",
                            Position = @"GP2.13.3",
                            Name = @"From Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is a NM data type; together they specify the ""range"". The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.13.4",
                            Type = @"Component",
                            Position = @"GP2.13.4",
                            Name = @"To Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See <from value>.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.13.5",
                            Type = @"Component",
                            Position = @"GP2.13.5",
                            Name = @"Range Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CWE, defined by the standard table of units for either time or quantity (see for example, the tables in Section 7.1.4, ""Coding schemes""). This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and <to value> are present.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GP2.13.5.1",
                            Type = @"SubComponent",
                            Position = @"GP2.13.5.1",
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
                            Id = @"GP2.13.5.2",
                            Type = @"SubComponent",
                            Position = @"GP2.13.5.2",
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
                            Id = @"GP2.13.5.3",
                            Type = @"SubComponent",
                            Position = @"GP2.13.5.3",
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
                            Id = @"GP2.13.5.4",
                            Type = @"SubComponent",
                            Position = @"GP2.13.5.4",
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
                            Id = @"GP2.13.5.5",
                            Type = @"SubComponent",
                            Position = @"GP2.13.5.5",
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
                            Id = @"GP2.13.5.6",
                            Type = @"SubComponent",
                            Position = @"GP2.13.5.6",
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
                            Id = @"GP2.13.5.7",
                            Type = @"SubComponent",
                            Position = @"GP2.13.5.7",
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
                            Id = @"GP2.13.5.8",
                            Type = @"SubComponent",
                            Position = @"GP2.13.5.8",
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
                            Id = @"GP2.13.5.9",
                            Type = @"SubComponent",
                            Position = @"GP2.13.5.9",
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
                            Id = @"GP2.13.6",
                            Type = @"Component",
                            Position = @"GP2.13.6",
                            Name = @"Range Type",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GP2.14",
                            Type = @"Field",
                            Position = @"GP2.14",
                            Name = @"Pay Rate per Service Unit",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the calculated rate, or multiplying factor, for each service unit for the line item.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V26SegmentGP2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field revenueCode;

public HL7V26Field RevenueCode
{
    get
    {
        if (revenueCode != null)
        {
            return revenueCode;
        }

        revenueCode = new HL7V26Field
        {
            field = message[@"GP2"][1],
            Id = @"GP2.1",
            Type = @"Field",
            Position = @"GP2.1",
            Name = @"Revenue Code",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0456",
            TableName = @"Revenue code",
            Description = @"This field identifies a specific ancillary service for each HCPC/CPT This field is the same as UB92 Form Locator 42 ""Revenue Code"". Refer to User-defined Table 0456 - Revenue Code for suggested values. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        

        

        

        return revenueCode;
    } 
}
internal HL7V26Field numberofServiceUnits;

public HL7V26Field NumberofServiceUnits
{
    get
    {
        if (numberofServiceUnits != null)
        {
            return numberofServiceUnits;
        }

        numberofServiceUnits = new HL7V26Field
        {
            field = message[@"GP2"][2],
            Id = @"GP2.2",
            Type = @"Field",
            Position = @"GP2.2",
            Name = @"Number of Service Units",
            Length = 7,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the quantitative count of units for each HCPC/CPT. This field is the same as UB92 Form Locator 46 ""Units of Service"". This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        

        

        

        return numberofServiceUnits;
    } 
}
internal HL7V26Field charge;

public HL7V26Field Charge
{
    get
    {
        if (charge != null)
        {
            return charge;
        }

        charge = new HL7V26Field
        {
            field = message[@"GP2"][3],
            Id = @"GP2.3",
            Type = @"Field",
            Position = @"GP2.3",
            Name = @"Charge",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount charged for the specific individual line item (HCPC/CPT). This field is the same as UB92 Form Locator 56. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        

        

        

        return charge;
    } 
}
internal HL7V26Field reimbursementActionCode;

public HL7V26Field ReimbursementActionCode
{
    get
    {
        if (reimbursementActionCode != null)
        {
            return reimbursementActionCode;
        }

        reimbursementActionCode = new HL7V26Field
        {
            field = message[@"GP2"][4],
            Id = @"GP2.4",
            Type = @"Field",
            Position = @"GP2.4",
            Name = @"Reimbursement Action Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0459",
            TableName = @"Reimbursement Action Code",
            Description = @"This field identifies the action to be taken during reimbursement calculations. If valued, this code overrides the value in GP2-6 - OCE Edit Code. Refer to User-defined Table 0459 - Reimbursement Action Code for suggested values. This field is defined by CMS or other regulatory agencies",
            Sample = @"",
        };

        

        

        

        return reimbursementActionCode;
    } 
}
internal HL7V26Field denialorRejectionCode;

public HL7V26Field DenialorRejectionCode
{
    get
    {
        if (denialorRejectionCode != null)
        {
            return denialorRejectionCode;
        }

        denialorRejectionCode = new HL7V26Field
        {
            field = message[@"GP2"][5],
            Id = @"GP2.5",
            Type = @"Field",
            Position = @"GP2.5",
            Name = @"Denial or Rejection Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0460",
            TableName = @"Denial or Rejection Code",
            Description = @"This field determines the OCE status of the line item. Refer to User-defined table 0460 - Denial or Rejection Code for suggested values. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        

        

        

        return denialorRejectionCode;
    } 
}
internal HL7V26Field oCEEditCode;

public HL7V26Field OCEEditCode
{
    get
    {
        if (oCEEditCode != null)
        {
            return oCEEditCode;
        }

        oCEEditCode = new HL7V26Field
        {
            field = message[@"GP2"][6],
            Id = @"GP2.6",
            Type = @"Field",
            Position = @"GP2.6",
            Name = @"OCE Edit Code",
            Length = 3,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0458",
            TableName = @"OCE Edit Code",
            Description = @"This field contains the edit that results from the processing of HCPCS/CPT procedures for a line item HCPCS/CPT, after evaluating all the codes, revenue codes, and modifiers. Refer to User-defined table 0458 - OCE Edit Code for suggested values.",
            Sample = @"",
        };

        

        

        

        return oCEEditCode;
    } 
}
internal HL7V26Field ambulatoryPaymentClassificationCode;

public HL7V26Field AmbulatoryPaymentClassificationCode
{
    get
    {
        if (ambulatoryPaymentClassificationCode != null)
        {
            return ambulatoryPaymentClassificationCode;
        }

        ambulatoryPaymentClassificationCode = new HL7V26Field
        {
            field = message[@"GP2"][7],
            Id = @"GP2.7",
            Type = @"Field",
            Position = @"GP2.7",
            Name = @"Ambulatory Payment Classification Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0466",
            TableName = @"Ambulatory Payment Classification Code",
            Description = @"This field contains the derived APC code. This is the APC code used for payment, which is the same as the assigned APC, for all situations except partial hospitalization. If partial hospitalization is billed in this visit, the assigned APC will differ from the APC used for payment. Partial hospitalization is the only time an assigned APC differs from the APC used for payment. The payment APC is used for billing and should be displayed in this field. The first component contains the APC identifier. The second component reports the text description for the APC group. Refer to User-defined table 0466 - Ambulatory Payment Classification Code for suggested values. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        

        

        

        return ambulatoryPaymentClassificationCode;
    } 
}
internal HL7V26Field modifierEditCode;

public HL7V26Field ModifierEditCode
{
    get
    {
        if (modifierEditCode != null)
        {
            return modifierEditCode;
        }

        modifierEditCode = new HL7V26Field
        {
            field = message[@"GP2"][8],
            Id = @"GP2.8",
            Type = @"Field",
            Position = @"GP2.8",
            Name = @"Modifier Edit Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0467",
            TableName = @"Modifier Edit Code",
            Description = @"This field contains calculated edits of the modifiers for each line or HCPCS/CPT. This field can be repeated up to five times, one edit for each of the modifiers present. This field relates to the values in PR1-16 - Procedure Code Modifier . Each repetition corresponds positionally to the order of the PR1-16 modifier codes. If no modifier code exists, use the code U (modifier edit code unknown) as a placeholder. The repetitions of Modifier Edit Codes must match the repetitions of Procedure Code Modifiers. For example, if PR1-16 - Procedure Code Modifier reports ...|01~02~03~04|... as modifier codes, and modifier code 03 modifier status code is unknown, GP2-8 - Modifier Edit Code would report ...|1~1~U~1|... Refer to User-defined table 0467 - Modifier Edit Code for suggested values. This field is defined by CMS or other regulatory agencies",
            Sample = @"",
        };

        

        

        

        return modifierEditCode;
    } 
}
internal HL7V26Field paymentAdjustmentCode;

public HL7V26Field PaymentAdjustmentCode
{
    get
    {
        if (paymentAdjustmentCode != null)
        {
            return paymentAdjustmentCode;
        }

        paymentAdjustmentCode = new HL7V26Field
        {
            field = message[@"GP2"][9],
            Id = @"GP2.9",
            Type = @"Field",
            Position = @"GP2.9",
            Name = @"Payment Adjustment Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0468",
            TableName = @"Payment Adjustment Code",
            Description = @"This field contains any payment adjustment due to drugs or medical devices. Refer to User-defined Table 0468 - Payment Adjustment Codefor suggested values. This field is defined by CMS or other regulatory agencies",
            Sample = @"",
        };

        

        

        

        return paymentAdjustmentCode;
    } 
}
internal HL7V26Field packagingStatusCode;

public HL7V26Field PackagingStatusCode
{
    get
    {
        if (packagingStatusCode != null)
        {
            return packagingStatusCode;
        }

        packagingStatusCode = new HL7V26Field
        {
            field = message[@"GP2"][10],
            Id = @"GP2.10",
            Type = @"Field",
            Position = @"GP2.10",
            Name = @"Packaging Status Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0469",
            TableName = @"Packaging Status Code",
            Description = @"This field contains the packaging status of the service. A status indicator of N may accompany this, unless it is part of a partial hospitalization. Refer to User defined (CMS) Table 0469 - Packaging Status Code for suggested values. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        

        

        

        return packagingStatusCode;
    } 
}
internal HL7V26Field expectedCMSPaymentAmount;

public HL7V26Field ExpectedCMSPaymentAmount
{
    get
    {
        if (expectedCMSPaymentAmount != null)
        {
            return expectedCMSPaymentAmount;
        }

        expectedCMSPaymentAmount = new HL7V26Field
        {
            field = message[@"GP2"][11],
            Id = @"GP2.11",
            Type = @"Field",
            Position = @"GP2.11",
            Name = @"Expected CMS Payment Amount",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the calculated dollar amount that CMS is expected to pay for the line item.",
            Sample = @"",
        };

        

        

        

        return expectedCMSPaymentAmount;
    } 
}
internal HL7V26Field reimbursementTypeCode;

public HL7V26Field ReimbursementTypeCode
{
    get
    {
        if (reimbursementTypeCode != null)
        {
            return reimbursementTypeCode;
        }

        reimbursementTypeCode = new HL7V26Field
        {
            field = message[@"GP2"][12],
            Id = @"GP2.12",
            Type = @"Field",
            Position = @"GP2.12",
            Name = @"Reimbursement Type Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0470",
            TableName = @"Reimbursement Type Code",
            Description = @"This field contains the fee schedule reimbursement type applied to the line item. Refer to User-defined Table 0470 - Reimbursement Type Code for suggested values. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
        };

        

        

        

        return reimbursementTypeCode;
    } 
}
internal HL7V26Field coPayAmount;

public HL7V26Field CoPayAmount
{
    get
    {
        if (coPayAmount != null)
        {
            return coPayAmount;
        }

        coPayAmount = new HL7V26Field
        {
            field = message[@"GP2"][13],
            Id = @"GP2.13",
            Type = @"Field",
            Position = @"GP2.13",
            Name = @"Co-Pay Amount",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the patient's Co-pay amount for the line item.",
            Sample = @"",
        };

        

        

        

        return coPayAmount;
    } 
}
internal HL7V26Field payRateperServiceUnit;

public HL7V26Field PayRateperServiceUnit
{
    get
    {
        if (payRateperServiceUnit != null)
        {
            return payRateperServiceUnit;
        }

        payRateperServiceUnit = new HL7V26Field
        {
            field = message[@"GP2"][14],
            Id = @"GP2.14",
            Type = @"Field",
            Position = @"GP2.14",
            Name = @"Pay Rate per Service Unit",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the calculated rate, or multiplying factor, for each service unit for the line item.",
            Sample = @"",
        };

        

        

        

        return payRateperServiceUnit;
    } 
}

    }
}
