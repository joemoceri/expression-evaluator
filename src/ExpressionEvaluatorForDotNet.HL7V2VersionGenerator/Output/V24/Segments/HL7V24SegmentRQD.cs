using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentRQD
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"RQD"; } }

        public string SegmentId { get { return @"RQD"; } }
        
        public string LongName { get { return @"Requisition Detail"; } }
        
        public string Description { get { return @"RQD contains the detail for each requisitioned item. See assumptions above."; } }
        
        public string Sample { get { return @""; } }

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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RQD.1",
                            Type = @"Field",
                            Position = @"RQD.1",
                            Name = @"Requisition Line Number",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number that identifies this line in the requisition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.2",
                            Type = @"Field",
                            Position = @"RQD.2",
                            Name = @"Item Code - Internal",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the identifier and description that uniquely identify the item on the application sending the requisition. This field is conditional because at least one of the three fields RQD-2-item code- internal, RQD-3-item code-external , or RQD-4-hospital item code must be valued.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RQD.2.1",
                            Type = @"Component",
                            Position = @"RQD.2.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.2.2",
                            Type = @"Component",
                            Position = @"RQD.2.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.2.3",
                            Type = @"Component",
                            Position = @"RQD.2.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.2.4",
                            Type = @"Component",
                            Position = @"RQD.2.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.2.5",
                            Type = @"Component",
                            Position = @"RQD.2.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.2.6",
                            Type = @"Component",
                            Position = @"RQD.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.3",
                            Type = @"Field",
                            Position = @"RQD.3",
                            Name = @"Item Code - External",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the identifier and description that uniquely identify the item on the application receiving the requisition. This field is conditional because at least one of the three fields -- RQD-2-item code-internal, RQD-3-item code-external or RQD-4-hospital item code -- must be valued.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RQD.3.1",
                            Type = @"Component",
                            Position = @"RQD.3.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.3.2",
                            Type = @"Component",
                            Position = @"RQD.3.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.3.3",
                            Type = @"Component",
                            Position = @"RQD.3.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.3.4",
                            Type = @"Component",
                            Position = @"RQD.3.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.3.5",
                            Type = @"Component",
                            Position = @"RQD.3.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.3.6",
                            Type = @"Component",
                            Position = @"RQD.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.4",
                            Type = @"Field",
                            Position = @"RQD.4",
                            Name = @"Hospital Item Code",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the identifier and description that uniquely identify the item on all applications in the hospital. The identifier is usually controlled by the hospital financial application in the charge description master file. This field is conditional because at least one of the three fields-- RQD-2-item code-internal, RQD-3-item code-external or RQD-4-hospital item code-- must be valued.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RQD.4.1",
                            Type = @"Component",
                            Position = @"RQD.4.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.4.2",
                            Type = @"Component",
                            Position = @"RQD.4.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.4.3",
                            Type = @"Component",
                            Position = @"RQD.4.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.4.4",
                            Type = @"Component",
                            Position = @"RQD.4.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.4.5",
                            Type = @"Component",
                            Position = @"RQD.4.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.4.6",
                            Type = @"Component",
                            Position = @"RQD.4.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.5",
                            Type = @"Field",
                            Position = @"RQD.5",
                            Name = @"Requisition Quantity",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the quantity requisitioned for this item.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.6",
                            Type = @"Field",
                            Position = @"RQD.6",
                            Name = @"Requisition Unit of Measure",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the unit of measure for this item.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RQD.6.1",
                            Type = @"Component",
                            Position = @"RQD.6.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.6.2",
                            Type = @"Component",
                            Position = @"RQD.6.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.6.3",
                            Type = @"Component",
                            Position = @"RQD.6.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.6.4",
                            Type = @"Component",
                            Position = @"RQD.6.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.6.5",
                            Type = @"Component",
                            Position = @"RQD.6.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.6.6",
                            Type = @"Component",
                            Position = @"RQD.6.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.7",
                            Type = @"Field",
                            Position = @"RQD.7",
                            Name = @"Dept. Cost Center",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0319",
                            TableName = @"Department cost center",
                            Description = @"This field contains the accounting code that identifies this department in order to charge for this item . User-defined table 0319 - Department cost center is used as the HL7 identifier for the user-defined table of values for this field.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.8",
                            Type = @"Field",
                            Position = @"RQD.8",
                            Name = @"Item Natural Account Code",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0320",
                            TableName = @"Item natural account code",
                            Description = @"This field contains the accounting code that identifies this item in order to charge for this item. User-defined table 0320 - Item natural account code is used as the HL7 identifier for the user-defined table of values for this field.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.9",
                            Type = @"Field",
                            Position = @"RQD.9",
                            Name = @"Deliver To ID",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the unique identifier and descriptive name of the department/location where the item should be delivered.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RQD.9.1",
                            Type = @"Component",
                            Position = @"RQD.9.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.9.2",
                            Type = @"Component",
                            Position = @"RQD.9.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.9.3",
                            Type = @"Component",
                            Position = @"RQD.9.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.9.4",
                            Type = @"Component",
                            Position = @"RQD.9.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.9.5",
                            Type = @"Component",
                            Position = @"RQD.9.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.9.6",
                            Type = @"Component",
                            Position = @"RQD.9.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.10",
                            Type = @"Field",
                            Position = @"RQD.10",
                            Name = @"Date Needed",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date this item is required.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V24SegmentRQD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field requisitionLineNumber;

public HL7V24Field RequisitionLineNumber
{
    get
    {
        if (requisitionLineNumber != null)
        {
            return requisitionLineNumber;
        }

        requisitionLineNumber = new HL7V24Field
        {
            field = message[@"RQD"][1],
            Id = @"RQD.1",
            Type = @"Field",
            Position = @"RQD.1",
            Name = @"Requisition Line Number",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this line in the requisition.",
            Sample = @"",
        };

        

        

        

        return requisitionLineNumber;
    } 
}
internal HL7V24Field itemCodeInternal;

public HL7V24Field ItemCodeInternal
{
    get
    {
        if (itemCodeInternal != null)
        {
            return itemCodeInternal;
        }

        itemCodeInternal = new HL7V24Field
        {
            field = message[@"RQD"][2],
            Id = @"RQD.2",
            Type = @"Field",
            Position = @"RQD.2",
            Name = @"Item Code - Internal",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier and description that uniquely identify the item on the application sending the requisition. This field is conditional because at least one of the three fields RQD-2-item code- internal, RQD-3-item code-external , or RQD-4-hospital item code must be valued.",
            Sample = @"",
        };

        

        

        

        return itemCodeInternal;
    } 
}
internal HL7V24Field itemCodeExternal;

public HL7V24Field ItemCodeExternal
{
    get
    {
        if (itemCodeExternal != null)
        {
            return itemCodeExternal;
        }

        itemCodeExternal = new HL7V24Field
        {
            field = message[@"RQD"][3],
            Id = @"RQD.3",
            Type = @"Field",
            Position = @"RQD.3",
            Name = @"Item Code - External",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier and description that uniquely identify the item on the application receiving the requisition. This field is conditional because at least one of the three fields -- RQD-2-item code-internal, RQD-3-item code-external or RQD-4-hospital item code -- must be valued.",
            Sample = @"",
        };

        

        

        

        return itemCodeExternal;
    } 
}
internal HL7V24Field hospitalItemCode;

public HL7V24Field HospitalItemCode
{
    get
    {
        if (hospitalItemCode != null)
        {
            return hospitalItemCode;
        }

        hospitalItemCode = new HL7V24Field
        {
            field = message[@"RQD"][4],
            Id = @"RQD.4",
            Type = @"Field",
            Position = @"RQD.4",
            Name = @"Hospital Item Code",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier and description that uniquely identify the item on all applications in the hospital. The identifier is usually controlled by the hospital financial application in the charge description master file. This field is conditional because at least one of the three fields-- RQD-2-item code-internal, RQD-3-item code-external or RQD-4-hospital item code-- must be valued.",
            Sample = @"",
        };

        

        

        

        return hospitalItemCode;
    } 
}
internal HL7V24Field requisitionQuantity;

public HL7V24Field RequisitionQuantity
{
    get
    {
        if (requisitionQuantity != null)
        {
            return requisitionQuantity;
        }

        requisitionQuantity = new HL7V24Field
        {
            field = message[@"RQD"][5],
            Id = @"RQD.5",
            Type = @"Field",
            Position = @"RQD.5",
            Name = @"Requisition Quantity",
            Length = 6,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the quantity requisitioned for this item.",
            Sample = @"",
        };

        

        

        

        return requisitionQuantity;
    } 
}
internal HL7V24Field requisitionUnitofMeasure;

public HL7V24Field RequisitionUnitofMeasure
{
    get
    {
        if (requisitionUnitofMeasure != null)
        {
            return requisitionUnitofMeasure;
        }

        requisitionUnitofMeasure = new HL7V24Field
        {
            field = message[@"RQD"][6],
            Id = @"RQD.6",
            Type = @"Field",
            Position = @"RQD.6",
            Name = @"Requisition Unit of Measure",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the unit of measure for this item.",
            Sample = @"",
        };

        

        

        

        return requisitionUnitofMeasure;
    } 
}
internal HL7V24Field dept.CostCenter;

public HL7V24Field Dept.CostCenter
{
    get
    {
        if (dept.CostCenter != null)
        {
            return dept.CostCenter;
        }

        dept.CostCenter = new HL7V24Field
        {
            field = message[@"RQD"][7],
            Id = @"RQD.7",
            Type = @"Field",
            Position = @"RQD.7",
            Name = @"Dept. Cost Center",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0319",
            TableName = @"Department cost center",
            Description = @"This field contains the accounting code that identifies this department in order to charge for this item . User-defined table 0319 - Department cost center is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
        };

        

        

        

        return dept.CostCenter;
    } 
}
internal HL7V24Field itemNaturalAccountCode;

public HL7V24Field ItemNaturalAccountCode
{
    get
    {
        if (itemNaturalAccountCode != null)
        {
            return itemNaturalAccountCode;
        }

        itemNaturalAccountCode = new HL7V24Field
        {
            field = message[@"RQD"][8],
            Id = @"RQD.8",
            Type = @"Field",
            Position = @"RQD.8",
            Name = @"Item Natural Account Code",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0320",
            TableName = @"Item natural account code",
            Description = @"This field contains the accounting code that identifies this item in order to charge for this item. User-defined table 0320 - Item natural account code is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
        };

        

        

        

        return itemNaturalAccountCode;
    } 
}
internal HL7V24Field deliverToID;

public HL7V24Field DeliverToID
{
    get
    {
        if (deliverToID != null)
        {
            return deliverToID;
        }

        deliverToID = new HL7V24Field
        {
            field = message[@"RQD"][9],
            Id = @"RQD.9",
            Type = @"Field",
            Position = @"RQD.9",
            Name = @"Deliver To ID",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the unique identifier and descriptive name of the department/location where the item should be delivered.",
            Sample = @"",
        };

        

        

        

        return deliverToID;
    } 
}
internal HL7V24Field dateNeeded;

public HL7V24Field DateNeeded
{
    get
    {
        if (dateNeeded != null)
        {
            return dateNeeded;
        }

        dateNeeded = new HL7V24Field
        {
            field = message[@"RQD"][10],
            Id = @"RQD.10",
            Type = @"Field",
            Position = @"RQD.10",
            Name = @"Date Needed",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date this item is required.",
            Sample = @"",
        };

        

        

        

        return dateNeeded;
    } 
}

    }
}
