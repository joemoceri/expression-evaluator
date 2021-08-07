using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentECR
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"ECR"; } }

        public string SegmentId { get { return @"ECR"; } }
        
        public string LongName { get { return @"Equipment Command Response"; } }
        
        public string Description { get { return @"The equipment command response segment contains the receiving component's response to the previously received command."; } }
        
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
                            Id = @"ECR.1",
                            Type = @"Field",
                            Position = @"ECR.1",
                            Name = @"Command Response",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0387",
                            TableName = @"Command response",
                            Description = @"This field identifies the response of the previously issued command. Refer to User-defined Table 0387 - Command response for valid values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ECR.1.1",
                            Type = @"Component",
                            Position = @"ECR.1.1",
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
                            Id = @"ECR.1.2",
                            Type = @"Component",
                            Position = @"ECR.1.2",
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
                            Id = @"ECR.1.3",
                            Type = @"Component",
                            Position = @"ECR.1.3",
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
                            Id = @"ECR.1.4",
                            Type = @"Component",
                            Position = @"ECR.1.4",
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
                            Id = @"ECR.1.5",
                            Type = @"Component",
                            Position = @"ECR.1.5",
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
                            Id = @"ECR.1.6",
                            Type = @"Component",
                            Position = @"ECR.1.6",
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
                            Id = @"ECR.1.7",
                            Type = @"Component",
                            Position = @"ECR.1.7",
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
                            Id = @"ECR.1.8",
                            Type = @"Component",
                            Position = @"ECR.1.8",
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
                            Id = @"ECR.1.9",
                            Type = @"Component",
                            Position = @"ECR.1.9",
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
                            Id = @"ECR.2",
                            Type = @"Field",
                            Position = @"ECR.2",
                            Name = @"Date/Time Completed",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date and time that the receiving component completed the requested command.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECR.3",
                            Type = @"Field",
                            Position = @"ECR.3",
                            Name = @"Command Response Parameters",
                            Length = 65536,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies any associated parameters that relate to the returned response command message.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V26SegmentECR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field commandResponse;

public HL7V26Field CommandResponse
{
    get
    {
        if (commandResponse != null)
        {
            return commandResponse;
        }

        commandResponse = new HL7V26Field
        {
            field = message[@"ECR"][1],
            Id = @"ECR.1",
            Type = @"Field",
            Position = @"ECR.1",
            Name = @"Command Response",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0387",
            TableName = @"Command response",
            Description = @"This field identifies the response of the previously issued command. Refer to User-defined Table 0387 - Command response for valid values.",
            Sample = @"",
        };

        

        

        

        return commandResponse;
    } 
}
internal HL7V26Field dateTimeCompleted;

public HL7V26Field DateTimeCompleted
{
    get
    {
        if (dateTimeCompleted != null)
        {
            return dateTimeCompleted;
        }

        dateTimeCompleted = new HL7V26Field
        {
            field = message[@"ECR"][2],
            Id = @"ECR.2",
            Type = @"Field",
            Position = @"ECR.2",
            Name = @"Date/Time Completed",
            Length = 24,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time that the receiving component completed the requested command.",
            Sample = @"",
        };

        

        

        

        return dateTimeCompleted;
    } 
}
internal HL7V26Field commandResponseParameters;

public HL7V26Field CommandResponseParameters
{
    get
    {
        if (commandResponseParameters != null)
        {
            return commandResponseParameters;
        }

        commandResponseParameters = new HL7V26Field
        {
            field = message[@"ECR"][3],
            Id = @"ECR.3",
            Type = @"Field",
            Position = @"ECR.3",
            Name = @"Command Response Parameters",
            Length = 65536,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies any associated parameters that relate to the returned response command message.",
            Sample = @"",
        };

        

        

        

        return commandResponseParameters;
    } 
}

    }
}
