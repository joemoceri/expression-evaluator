using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentPRA
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"PRA"; } }

        public string SegmentId { get { return @"PRA"; } }
        
        public string LongName { get { return @"Practitioner detail segment"; } }
        
        public string Description { get { return @"The PRA segment adds detailed medical practitioner information to the personnel identified by the STF segment.  A PRA segment may optionally follow an STF segment.  A PRA segment must always have been preceded by a corresponding STF segment.  The PRA segment may also be used for staff who work in healthcare who are not practitioners, but need to be certified, e.g., “medical records staff.” "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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
                            Id = @"PRA.1",
                            Type = @"Field",
                            Position = @"PRA.1",
                            Name = @"PRA - Primary Key Value",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field must match MFE-4-primary key value, to identify which entry is being referenced",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.2",
                            Type = @"Field",
                            Position = @"PRA.2",
                            Name = @"Practioner Group",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name and/or code of a group of practitioners to which this practitioner belongs",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRA.2.1",
                            Type = @"Component",
                            Position = @"PRA.2.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.2.2",
                            Type = @"Component",
                            Position = @"PRA.2.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.2.3",
                            Type = @"Component",
                            Position = @"PRA.2.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.2.4",
                            Type = @"Component",
                            Position = @"PRA.2.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.2.5",
                            Type = @"Component",
                            Position = @"PRA.2.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.2.6",
                            Type = @"Component",
                            Position = @"PRA.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.3",
                            Type = @"Field",
                            Position = @"PRA.3",
                            Name = @"Practioner Category",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0186",
                            TableName = @"Practitioner Category",
                            Description = @"This field contains the category of practitioner.  Refer to user-defined table 0186 - Practitioner category whose values may include codes for staff physician, courtesy physician, resident, physician assistant, physical therapist, psychiatrist, psychologist, pharmacist, registered nurse, licensed practical nurse, licensed vocational nurse, nurse practitioner, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.4",
                            Type = @"Field",
                            Position = @"PRA.4",
                            Name = @"Provider Billing",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0187",
                            TableName = @"Provider billing",
                            Description = @"This field indicates how provider services are billed.  Refer to HL7 table 0187 - Provider billing for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.5",
                            Type = @"Field",
                            Position = @"PRA.5",
                            Name = @"Specialty",
                            Length = 100,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CM_SPD",
                            DataTypeName = @"Specialty",
                            TableId = null,
                            TableName = null,
                            Description = @"This repeating field is made up of multiple components to record the practitioner’s specialties.  The multiple components of each specialty are: (1) specialty name or abbreviation, identifies provider’s specialty, (2) name of specialty governing board, (3) Certification Status, (4) certified date contains the  date of certification, if certified",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRA.5.1",
                            Type = @"Component",
                            Position = @"PRA.5.1",
                            Name = @"Specialty Name",
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
                            Id = @"PRA.5.2",
                            Type = @"Component",
                            Position = @"PRA.5.2",
                            Name = @"Governing Board",
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
                            Id = @"PRA.5.3",
                            Type = @"Component",
                            Position = @"PRA.5.3",
                            Name = @"Eligible Or Certified",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0337",
                            TableName = @"Certification status",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.5.4",
                            Type = @"Component",
                            Position = @"PRA.5.4",
                            Name = @"Date Of Certification",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.6",
                            Type = @"Field",
                            Position = @"PRA.6",
                            Name = @"Practitioner ID Numbers",
                            Length = 100,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CM_PLN",
                            DataTypeName = @"Practitioner ID Numbers",
                            TableId = null,
                            TableName = null,
                            Description = @"This repeating field contains this practitioner’s license numbers and other ID numbers.  This is a field made up of the following components: (1) the ID number, and (2) the type of number, and optionally (3) the state or province in which it is valid, if relevant, or other qualifying information.  It is recommended that state qualifications use the abbreviations from the postal service of the country.  The practitioner ID number type (component 2) is a user-defined table (table 0338).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRA.6.1",
                            Type = @"Component",
                            Position = @"PRA.6.1",
                            Name = @"ID Number",
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
                            Id = @"PRA.6.2",
                            Type = @"Component",
                            Position = @"PRA.6.2",
                            Name = @"Type Of ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0338",
                            TableName = @"Practitioner ID number type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.6.3",
                            Type = @"Component",
                            Position = @"PRA.6.3",
                            Name = @"State/other Qualifying Info",
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
                            Id = @"PRA.6.4",
                            Type = @"Component",
                            Position = @"PRA.6.4",
                            Name = @"Expiration Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7",
                            Type = @"Field",
                            Position = @"PRA.7",
                            Name = @"Privileges",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CM_PIP",
                            DataTypeName = @"Privileges",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the institutional privileges which this provider may exercise.  Depends upon institutional needs.  For example, admit, transfer, discharge, place orders, verify orders, review results, etc.  Can also be used for privileges other than patient services.  This is a repeating field, with each privilege made up of the following components: (1) privilege; (2) privilege class; (3) privilege expiration date, if any; and (4) privilege activation date, if any.  Note that the privilege and privilege class components are CE data types, and thus they are encoded with the subcomponent delimiter (&) rather than the component delimiter (^)",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.1",
                            Type = @"Component",
                            Position = @"PRA.7.1",
                            Name = @"Privilege",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.1.1",
                            Type = @"SubComponent",
                            Position = @"PRA.7.1.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.1.2",
                            Type = @"SubComponent",
                            Position = @"PRA.7.1.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.1.3",
                            Type = @"SubComponent",
                            Position = @"PRA.7.1.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.1.4",
                            Type = @"SubComponent",
                            Position = @"PRA.7.1.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.1.5",
                            Type = @"SubComponent",
                            Position = @"PRA.7.1.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.1.6",
                            Type = @"SubComponent",
                            Position = @"PRA.7.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.2",
                            Type = @"Component",
                            Position = @"PRA.7.2",
                            Name = @"Privilege Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.2.1",
                            Type = @"SubComponent",
                            Position = @"PRA.7.2.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.2.2",
                            Type = @"SubComponent",
                            Position = @"PRA.7.2.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.2.3",
                            Type = @"SubComponent",
                            Position = @"PRA.7.2.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.2.4",
                            Type = @"SubComponent",
                            Position = @"PRA.7.2.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.2.5",
                            Type = @"SubComponent",
                            Position = @"PRA.7.2.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.2.6",
                            Type = @"SubComponent",
                            Position = @"PRA.7.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.3",
                            Type = @"Component",
                            Position = @"PRA.7.3",
                            Name = @"Expiration Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.7.4",
                            Type = @"Component",
                            Position = @"PRA.7.4",
                            Name = @"Activation Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRA.8",
                            Type = @"Field",
                            Position = @"PRA.8",
                            Name = @"Date Entered Practice",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date the practitioner began practicing at the present institution (e.g., at hospital, at physician organization, at managed care network).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentPRA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field pRAPrimaryKeyValue;

public HL7V23Field PRAPrimaryKeyValue
{
    get
    {
        if (pRAPrimaryKeyValue != null)
        {
            return pRAPrimaryKeyValue;
        }

        pRAPrimaryKeyValue = new HL7V23Field
        {
            field = message[@"PRA"][1],
            Id = @"PRA.1",
            Type = @"Field",
            Position = @"PRA.1",
            Name = @"PRA - Primary Key Value",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field must match MFE-4-primary key value, to identify which entry is being referenced",
            Sample = @"",
        };

        

        

        

        return pRAPrimaryKeyValue;
    } 
}
internal HL7V23Field practionerGroup;

public HL7V23Field PractionerGroup
{
    get
    {
        if (practionerGroup != null)
        {
            return practionerGroup;
        }

        practionerGroup = new HL7V23Field
        {
            field = message[@"PRA"][2],
            Id = @"PRA.2",
            Type = @"Field",
            Position = @"PRA.2",
            Name = @"Practioner Group",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name and/or code of a group of practitioners to which this practitioner belongs",
            Sample = @"",
        };

        

        

        

        return practionerGroup;
    } 
}
internal HL7V23Field practionerCategory;

public HL7V23Field PractionerCategory
{
    get
    {
        if (practionerCategory != null)
        {
            return practionerCategory;
        }

        practionerCategory = new HL7V23Field
        {
            field = message[@"PRA"][3],
            Id = @"PRA.3",
            Type = @"Field",
            Position = @"PRA.3",
            Name = @"Practioner Category",
            Length = 3,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0186",
            TableName = @"Practitioner Category",
            Description = @"This field contains the category of practitioner.  Refer to user-defined table 0186 - Practitioner category whose values may include codes for staff physician, courtesy physician, resident, physician assistant, physical therapist, psychiatrist, psychologist, pharmacist, registered nurse, licensed practical nurse, licensed vocational nurse, nurse practitioner, etc",
            Sample = @"",
        };

        

        

        

        return practionerCategory;
    } 
}
internal HL7V23Field providerBilling;

public HL7V23Field ProviderBilling
{
    get
    {
        if (providerBilling != null)
        {
            return providerBilling;
        }

        providerBilling = new HL7V23Field
        {
            field = message[@"PRA"][4],
            Id = @"PRA.4",
            Type = @"Field",
            Position = @"PRA.4",
            Name = @"Provider Billing",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0187",
            TableName = @"Provider billing",
            Description = @"This field indicates how provider services are billed.  Refer to HL7 table 0187 - Provider billing for valid values",
            Sample = @"",
        };

        

        

        

        return providerBilling;
    } 
}
internal HL7V23Field specialty;

public HL7V23Field Specialty
{
    get
    {
        if (specialty != null)
        {
            return specialty;
        }

        specialty = new HL7V23Field
        {
            field = message[@"PRA"][5],
            Id = @"PRA.5",
            Type = @"Field",
            Position = @"PRA.5",
            Name = @"Specialty",
            Length = 100,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_SPD",
            DataTypeName = @"Specialty",
            TableId = null,
            TableName = null,
            Description = @"This repeating field is made up of multiple components to record the practitioner’s specialties.  The multiple components of each specialty are: (1) specialty name or abbreviation, identifies provider’s specialty, (2) name of specialty governing board, (3) Certification Status, (4) certified date contains the  date of certification, if certified",
            Sample = @"",
        };

        

        

        

        return specialty;
    } 
}
internal HL7V23Field practitionerIDNumbers;

public HL7V23Field PractitionerIDNumbers
{
    get
    {
        if (practitionerIDNumbers != null)
        {
            return practitionerIDNumbers;
        }

        practitionerIDNumbers = new HL7V23Field
        {
            field = message[@"PRA"][6],
            Id = @"PRA.6",
            Type = @"Field",
            Position = @"PRA.6",
            Name = @"Practitioner ID Numbers",
            Length = 100,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_PLN",
            DataTypeName = @"Practitioner ID Numbers",
            TableId = null,
            TableName = null,
            Description = @"This repeating field contains this practitioner’s license numbers and other ID numbers.  This is a field made up of the following components: (1) the ID number, and (2) the type of number, and optionally (3) the state or province in which it is valid, if relevant, or other qualifying information.  It is recommended that state qualifications use the abbreviations from the postal service of the country.  The practitioner ID number type (component 2) is a user-defined table (table 0338).",
            Sample = @"",
        };

        

        

        

        return practitionerIDNumbers;
    } 
}
internal HL7V23Field privileges;

public HL7V23Field Privileges
{
    get
    {
        if (privileges != null)
        {
            return privileges;
        }

        privileges = new HL7V23Field
        {
            field = message[@"PRA"][7],
            Id = @"PRA.7",
            Type = @"Field",
            Position = @"PRA.7",
            Name = @"Privileges",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_PIP",
            DataTypeName = @"Privileges",
            TableId = null,
            TableName = null,
            Description = @"This field contains the institutional privileges which this provider may exercise.  Depends upon institutional needs.  For example, admit, transfer, discharge, place orders, verify orders, review results, etc.  Can also be used for privileges other than patient services.  This is a repeating field, with each privilege made up of the following components: (1) privilege; (2) privilege class; (3) privilege expiration date, if any; and (4) privilege activation date, if any.  Note that the privilege and privilege class components are CE data types, and thus they are encoded with the subcomponent delimiter (&) rather than the component delimiter (^)",
            Sample = @"",
        };

        

        

        

        return privileges;
    } 
}
internal HL7V23Field dateEnteredPractice;

public HL7V23Field DateEnteredPractice
{
    get
    {
        if (dateEnteredPractice != null)
        {
            return dateEnteredPractice;
        }

        dateEnteredPractice = new HL7V23Field
        {
            field = message[@"PRA"][8],
            Id = @"PRA.8",
            Type = @"Field",
            Position = @"PRA.8",
            Name = @"Date Entered Practice",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date the practitioner began practicing at the present institution (e.g., at hospital, at physician organization, at managed care network).",
            Sample = @"",
        };

        

        

        

        return dateEnteredPractice;
    } 
}

    }
}
