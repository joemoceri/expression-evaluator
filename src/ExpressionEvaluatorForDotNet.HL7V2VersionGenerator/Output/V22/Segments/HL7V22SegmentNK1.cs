using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentNK1
    {
        private readonly HL7V2Message message;

        public string Id { get { return @"NK1"; } }

        public string SegmentId { get { return @"NK1"; } }
        
        public string LongName { get { return @"Next Of Kin"; } }
        
        public string Description { get { return @"The NK1 segment contains information about the patient's other related parties. Any associated parties may be identified. Utilizing NK1-1-set ID, multiple NK1 segments can be sent to patient accounts"; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

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
                            Id = @"NK1.1",
                            Type = @"Field",
                            Position = @"NK1.1",
                            Name = @"Set Id - Next Of Kin",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence Id",
                            TableId = null,
                            TableName = null,
                            Description = @"uniquely identifies the NK1 records for the purpose of adding, changing, or deleting records.  For those messages that permit segments to repeat, the Set ID field is used to identify the repetitions.  For example, the swap and query transactions allow for multiple PID segments would have Set ID values of 1, 2, then 3, etc. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.2",
                            Type = @"Field",
                            Position = @"NK1.2",
                            Name = @"Name",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PN",
                            DataTypeName = @"Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"name of the next of kin",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NK1.2.1",
                            Type = @"Component",
                            Position = @"NK1.2.1",
                            Name = @"Familiy Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.2.2",
                            Type = @"Component",
                            Position = @"NK1.2.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.2.3",
                            Type = @"Component",
                            Position = @"NK1.2.3",
                            Name = @"Middle Initial Or Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.2.4",
                            Type = @"Component",
                            Position = @"NK1.2.4",
                            Name = @"Suffix (e.g. Jr Or Iii)",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.2.5",
                            Type = @"Component",
                            Position = @"NK1.2.5",
                            Name = @"Prefix (e.g. Dr)",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.2.6",
                            Type = @"Component",
                            Position = @"NK1.2.6",
                            Name = @"Degree (e.g. Md)",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.3",
                            Type = @"Field",
                            Position = @"NK1.3",
                            Name = @"Relationship",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0063",
                            TableName = @"RELATIONSHIP",
                            Description = @"defines the actual personal relationship that the next of kin has to the patient.  Refer to user-defined table 0063 - relationship.  Examples might include: brother, sister, mother, father, friend, spouse, emergency contact, employer, etc",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NK1.3.1",
                            Type = @"Component",
                            Position = @"NK1.3.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.3.2",
                            Type = @"Component",
                            Position = @"NK1.3.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.3.3",
                            Type = @"Component",
                            Position = @"NK1.3.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.3.4",
                            Type = @"Component",
                            Position = @"NK1.3.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.3.5",
                            Type = @"Component",
                            Position = @"NK1.3.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.3.6",
                            Type = @"Component",
                            Position = @"NK1.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.4",
                            Type = @"Field",
                            Position = @"NK1.4",
                            Name = @"Address",
                            Length = 106,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = @"defines the address of the associated party",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NK1.4.1",
                            Type = @"Component",
                            Position = @"NK1.4.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.4.2",
                            Type = @"Component",
                            Position = @"NK1.4.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.4.3",
                            Type = @"Component",
                            Position = @"NK1.4.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.4.4",
                            Type = @"Component",
                            Position = @"NK1.4.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.4.5",
                            Type = @"Component",
                            Position = @"NK1.4.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.4.6",
                            Type = @"Component",
                            Position = @"NK1.4.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.4.7",
                            Type = @"Component",
                            Position = @"NK1.4.7",
                            Name = @"Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0190",
                            TableName = @"ADDRESS TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.4.8",
                            Type = @"Component",
                            Position = @"NK1.4.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.5",
                            Type = @"Field",
                            Position = @"NK1.5",
                            Name = @"Phone Number",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"3",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = @"defines the telephone number of the associated party",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.6",
                            Type = @"Field",
                            Position = @"NK1.6",
                            Name = @"Business Phone Number",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = @"defines the business telephone number of the associated party",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.7",
                            Type = @"Field",
                            Position = @"NK1.7",
                            Name = @"Contact Role",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0131",
                            TableName = @"CONTRACT ROLE",
                            Description = @"indicates the specific relationship role (next of kin, employer, emergency contact, etc.).  Refer to userdefined table 0131 - contact role.  This field specifies the role that the next of kin plays with regards to the patient.  For example, an employer, emergency contact, next of kin, insurance company, state agency, federal agency etc.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NK1.7.1",
                            Type = @"Component",
                            Position = @"NK1.7.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.7.2",
                            Type = @"Component",
                            Position = @"NK1.7.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.7.3",
                            Type = @"Component",
                            Position = @"NK1.7.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.7.4",
                            Type = @"Component",
                            Position = @"NK1.7.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.7.5",
                            Type = @"Component",
                            Position = @"NK1.7.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.7.6",
                            Type = @"Component",
                            Position = @"NK1.7.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.8",
                            Type = @"Field",
                            Position = @"NK1.8",
                            Name = @"Start Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"start of relationship",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.9",
                            Type = @"Field",
                            Position = @"NK1.9",
                            Name = @"End Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"end of relationship",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.10",
                            Type = @"Field",
                            Position = @"NK1.10",
                            Name = @"Next Of Kin",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"title of the next of kin at their place of employment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.11",
                            Type = @"Field",
                            Position = @"NK1.11",
                            Name = @"Next Of Kin Job Code / Class",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_JOB_CODE",
                            DataTypeName = @"Job Title",
                            TableId = null,
                            TableName = null,
                            Description = @"the employers Job Code or Employee Classification used for the next of kin at their place of employment",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NK1.11.1",
                            Type = @"Component",
                            Position = @"NK1.11.1",
                            Name = @"Job Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.11.2",
                            Type = @"Component",
                            Position = @"NK1.11.2",
                            Name = @"Employee Classification",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.12",
                            Type = @"Field",
                            Position = @"NK1.12",
                            Name = @"Next Of Kin Employee Number",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"number the employer assigns to the employee that is acting as next of kin",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.13",
                            Type = @"Field",
                            Position = @"NK1.13",
                            Name = @"Organization Name",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"in cases where an employer serves as next of kin, this is the name of the organization which serves as the next of kin.  This field may also be used to communicate the name of the organization where the next of kin works.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentNK1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field setIdNextOfKin;

public HL7V22Field SetIdNextOfKin
{
    get
    {
        if (setIdNextOfKin != null)
        {
            return setIdNextOfKin;
        }

        setIdNextOfKin = new HL7V22Field
        {
            field = message[@"NK1"][1],
            Id = @"NK1.1",
            Type = @"Field",
            Position = @"NK1.1",
            Name = @"Set Id - Next Of Kin",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"uniquely identifies the NK1 records for the purpose of adding, changing, or deleting records.  For those messages that permit segments to repeat, the Set ID field is used to identify the repetitions.  For example, the swap and query transactions allow for multiple PID segments would have Set ID values of 1, 2, then 3, etc. ",
            Sample = @"",
        };

        // check for repetitions
        if (setIdNextOfKin.field.FieldRepetitions != null && setIdNextOfKin.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIdNextOfKin.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < setIdNextOfKin.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = setIdNextOfKin.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < setIdNextOfKin.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = setIdNextOfKin.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < setIdNextOfKin.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = setIdNextOfKin.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            setIdNextOfKin.fieldRepetitions = fieldRepetitions;
        }

        return setIdNextOfKin;
    } 
}

internal HL7V22Field name;

public HL7V22Field Name
{
    get
    {
        if (name != null)
        {
            return name;
        }

        name = new HL7V22Field
        {
            field = message[@"NK1"][2],
            Id = @"NK1.2",
            Type = @"Field",
            Position = @"NK1.2",
            Name = @"Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"name of the next of kin",
            Sample = @"",
        };

        // check for repetitions
        if (name.field.FieldRepetitions != null && name.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(name.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < name.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = name.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < name.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = name.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < name.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = name.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            name.fieldRepetitions = fieldRepetitions;
        }

        return name;
    } 
}

internal HL7V22Field relationship;

public HL7V22Field Relationship
{
    get
    {
        if (relationship != null)
        {
            return relationship;
        }

        relationship = new HL7V22Field
        {
            field = message[@"NK1"][3],
            Id = @"NK1.3",
            Type = @"Field",
            Position = @"NK1.3",
            Name = @"Relationship",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0063",
            TableName = @"RELATIONSHIP",
            Description = @"defines the actual personal relationship that the next of kin has to the patient.  Refer to user-defined table 0063 - relationship.  Examples might include: brother, sister, mother, father, friend, spouse, emergency contact, employer, etc",
            Sample = @"",
        };

        // check for repetitions
        if (relationship.field.FieldRepetitions != null && relationship.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(relationship.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < relationship.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = relationship.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < relationship.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = relationship.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < relationship.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = relationship.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            relationship.fieldRepetitions = fieldRepetitions;
        }

        return relationship;
    } 
}

internal HL7V22Field address;

public HL7V22Field Address
{
    get
    {
        if (address != null)
        {
            return address;
        }

        address = new HL7V22Field
        {
            field = message[@"NK1"][4],
            Id = @"NK1.4",
            Type = @"Field",
            Position = @"NK1.4",
            Name = @"Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = @"defines the address of the associated party",
            Sample = @"",
        };

        // check for repetitions
        if (address.field.FieldRepetitions != null && address.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(address.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < address.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = address.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < address.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = address.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < address.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = address.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            address.fieldRepetitions = fieldRepetitions;
        }

        return address;
    } 
}

internal HL7V22Field phoneNumber;

public HL7V22Field PhoneNumber
{
    get
    {
        if (phoneNumber != null)
        {
            return phoneNumber;
        }

        phoneNumber = new HL7V22Field
        {
            field = message[@"NK1"][5],
            Id = @"NK1.5",
            Type = @"Field",
            Position = @"NK1.5",
            Name = @"Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"defines the telephone number of the associated party",
            Sample = @"",
        };

        // check for repetitions
        if (phoneNumber.field.FieldRepetitions != null && phoneNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(phoneNumber.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < phoneNumber.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = phoneNumber.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < phoneNumber.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = phoneNumber.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < phoneNumber.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = phoneNumber.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            phoneNumber.fieldRepetitions = fieldRepetitions;
        }

        return phoneNumber;
    } 
}

internal HL7V22Field businessPhoneNumber;

public HL7V22Field BusinessPhoneNumber
{
    get
    {
        if (businessPhoneNumber != null)
        {
            return businessPhoneNumber;
        }

        businessPhoneNumber = new HL7V22Field
        {
            field = message[@"NK1"][6],
            Id = @"NK1.6",
            Type = @"Field",
            Position = @"NK1.6",
            Name = @"Business Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"defines the business telephone number of the associated party",
            Sample = @"",
        };

        // check for repetitions
        if (businessPhoneNumber.field.FieldRepetitions != null && businessPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(businessPhoneNumber.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < businessPhoneNumber.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = businessPhoneNumber.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < businessPhoneNumber.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = businessPhoneNumber.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < businessPhoneNumber.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = businessPhoneNumber.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            businessPhoneNumber.fieldRepetitions = fieldRepetitions;
        }

        return businessPhoneNumber;
    } 
}

internal HL7V22Field contactRole;

public HL7V22Field ContactRole
{
    get
    {
        if (contactRole != null)
        {
            return contactRole;
        }

        contactRole = new HL7V22Field
        {
            field = message[@"NK1"][7],
            Id = @"NK1.7",
            Type = @"Field",
            Position = @"NK1.7",
            Name = @"Contact Role",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0131",
            TableName = @"CONTRACT ROLE",
            Description = @"indicates the specific relationship role (next of kin, employer, emergency contact, etc.).  Refer to userdefined table 0131 - contact role.  This field specifies the role that the next of kin plays with regards to the patient.  For example, an employer, emergency contact, next of kin, insurance company, state agency, federal agency etc.",
            Sample = @"",
        };

        // check for repetitions
        if (contactRole.field.FieldRepetitions != null && contactRole.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(contactRole.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < contactRole.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = contactRole.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < contactRole.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = contactRole.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < contactRole.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = contactRole.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            contactRole.fieldRepetitions = fieldRepetitions;
        }

        return contactRole;
    } 
}

internal HL7V22Field startDate;

public HL7V22Field StartDate
{
    get
    {
        if (startDate != null)
        {
            return startDate;
        }

        startDate = new HL7V22Field
        {
            field = message[@"NK1"][8],
            Id = @"NK1.8",
            Type = @"Field",
            Position = @"NK1.8",
            Name = @"Start Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"start of relationship",
            Sample = @"",
        };

        // check for repetitions
        if (startDate.field.FieldRepetitions != null && startDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(startDate.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < startDate.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = startDate.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < startDate.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = startDate.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < startDate.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = startDate.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            startDate.fieldRepetitions = fieldRepetitions;
        }

        return startDate;
    } 
}

internal HL7V22Field endDate;

public HL7V22Field EndDate
{
    get
    {
        if (endDate != null)
        {
            return endDate;
        }

        endDate = new HL7V22Field
        {
            field = message[@"NK1"][9],
            Id = @"NK1.9",
            Type = @"Field",
            Position = @"NK1.9",
            Name = @"End Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"end of relationship",
            Sample = @"",
        };

        // check for repetitions
        if (endDate.field.FieldRepetitions != null && endDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(endDate.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < endDate.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = endDate.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < endDate.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = endDate.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < endDate.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = endDate.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            endDate.fieldRepetitions = fieldRepetitions;
        }

        return endDate;
    } 
}

internal HL7V22Field nextOfKin;

public HL7V22Field NextOfKin
{
    get
    {
        if (nextOfKin != null)
        {
            return nextOfKin;
        }

        nextOfKin = new HL7V22Field
        {
            field = message[@"NK1"][10],
            Id = @"NK1.10",
            Type = @"Field",
            Position = @"NK1.10",
            Name = @"Next Of Kin",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"title of the next of kin at their place of employment",
            Sample = @"",
        };

        // check for repetitions
        if (nextOfKin.field.FieldRepetitions != null && nextOfKin.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(nextOfKin.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < nextOfKin.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = nextOfKin.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < nextOfKin.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = nextOfKin.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < nextOfKin.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = nextOfKin.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            nextOfKin.fieldRepetitions = fieldRepetitions;
        }

        return nextOfKin;
    } 
}

internal HL7V22Field nextOfKinJobCodeClass;

public HL7V22Field NextOfKinJobCodeClass
{
    get
    {
        if (nextOfKinJobCodeClass != null)
        {
            return nextOfKinJobCodeClass;
        }

        nextOfKinJobCodeClass = new HL7V22Field
        {
            field = message[@"NK1"][11],
            Id = @"NK1.11",
            Type = @"Field",
            Position = @"NK1.11",
            Name = @"Next Of Kin Job Code / Class",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_JOB_CODE",
            DataTypeName = @"Job Title",
            TableId = null,
            TableName = null,
            Description = @"the employers Job Code or Employee Classification used for the next of kin at their place of employment",
            Sample = @"",
        };

        // check for repetitions
        if (nextOfKinJobCodeClass.field.FieldRepetitions != null && nextOfKinJobCodeClass.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(nextOfKinJobCodeClass.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < nextOfKinJobCodeClass.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = nextOfKinJobCodeClass.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < nextOfKinJobCodeClass.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = nextOfKinJobCodeClass.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < nextOfKinJobCodeClass.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = nextOfKinJobCodeClass.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            nextOfKinJobCodeClass.fieldRepetitions = fieldRepetitions;
        }

        return nextOfKinJobCodeClass;
    } 
}

internal HL7V22Field nextOfKinEmployeeNumber;

public HL7V22Field NextOfKinEmployeeNumber
{
    get
    {
        if (nextOfKinEmployeeNumber != null)
        {
            return nextOfKinEmployeeNumber;
        }

        nextOfKinEmployeeNumber = new HL7V22Field
        {
            field = message[@"NK1"][12],
            Id = @"NK1.12",
            Type = @"Field",
            Position = @"NK1.12",
            Name = @"Next Of Kin Employee Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"number the employer assigns to the employee that is acting as next of kin",
            Sample = @"",
        };

        // check for repetitions
        if (nextOfKinEmployeeNumber.field.FieldRepetitions != null && nextOfKinEmployeeNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(nextOfKinEmployeeNumber.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < nextOfKinEmployeeNumber.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = nextOfKinEmployeeNumber.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < nextOfKinEmployeeNumber.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = nextOfKinEmployeeNumber.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < nextOfKinEmployeeNumber.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = nextOfKinEmployeeNumber.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            nextOfKinEmployeeNumber.fieldRepetitions = fieldRepetitions;
        }

        return nextOfKinEmployeeNumber;
    } 
}

internal HL7V22Field organizationName;

public HL7V22Field OrganizationName
{
    get
    {
        if (organizationName != null)
        {
            return organizationName;
        }

        organizationName = new HL7V22Field
        {
            field = message[@"NK1"][13],
            Id = @"NK1.13",
            Type = @"Field",
            Position = @"NK1.13",
            Name = @"Organization Name",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"in cases where an employer serves as next of kin, this is the name of the organization which serves as the next of kin.  This field may also be used to communicate the name of the organization where the next of kin works.",
            Sample = @"",
        };

        // check for repetitions
        if (organizationName.field.FieldRepetitions != null && organizationName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(organizationName.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < organizationName.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = organizationName.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < organizationName.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = organizationName.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < organizationName.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = organizationName.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            organizationName.fieldRepetitions = fieldRepetitions;
        }

        return organizationName;
    } 
}
    }
}