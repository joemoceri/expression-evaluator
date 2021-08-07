using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentNDS
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"NDS"; } }

        public string SegmentId { get { return @"NDS"; } }
        
        public string LongName { get { return @"Notification Detail"; } }
        
        public string Description { get { return @"The equipment notification detail segment is the data necessary to maintain an adequate audit trail as well as notifications of events, (e.g., alarms that have occurred on a particular piece of equipment."; } }
        
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
                            Id = @"NDS.1",
                            Type = @"Field",
                            Position = @"NDS.1",
                            Name = @"Notification Reference Number",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a unique sequential reference number that may be used by various components to refer to this transaction. This number is generated by the originator of this notification.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDS.2",
                            Type = @"Field",
                            Position = @"NDS.2",
                            Name = @"Notification Date/Time",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the date/time of the notifications.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"NDS.2.1",
                            Type = @"Component",
                            Position = @"NDS.2.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDS.2.2",
                            Type = @"Component",
                            Position = @"NDS.2.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDS.3",
                            Type = @"Field",
                            Position = @"NDS.3",
                            Name = @"Notification Alert Severity",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0367",
                            TableName = @"Alert level",
                            Description = @"The severity of the specific notification. Refer to HL7 Table 0367 - Alert level for valid entries.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"NDS.3.1",
                            Type = @"Component",
                            Position = @"NDS.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDS.3.2",
                            Type = @"Component",
                            Position = @"NDS.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDS.3.3",
                            Type = @"Component",
                            Position = @"NDS.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDS.3.4",
                            Type = @"Component",
                            Position = @"NDS.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDS.3.5",
                            Type = @"Component",
                            Position = @"NDS.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDS.3.6",
                            Type = @"Component",
                            Position = @"NDS.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDS.4",
                            Type = @"Field",
                            Position = @"NDS.4",
                            Name = @"Notification Code",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains information about the type of notification being sent. These are manufacturer and equipment specific error or status codes, e.g., AQN0123 - aliquoting error - clot detected.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"NDS.4.1",
                            Type = @"Component",
                            Position = @"NDS.4.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDS.4.2",
                            Type = @"Component",
                            Position = @"NDS.4.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDS.4.3",
                            Type = @"Component",
                            Position = @"NDS.4.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDS.4.4",
                            Type = @"Component",
                            Position = @"NDS.4.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDS.4.5",
                            Type = @"Component",
                            Position = @"NDS.4.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NDS.4.6",
                            Type = @"Component",
                            Position = @"NDS.4.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        };
            }
        }

        public HL7V251SegmentNDS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field notificationReferenceNumber;

public HL7V251Field NotificationReferenceNumber
{
    get
    {
        if (notificationReferenceNumber != null)
        {
            return notificationReferenceNumber;
        }

        notificationReferenceNumber = new HL7V251Field
        {
            field = message[@"NDS"][1],
            Id = @"NDS.1",
            Type = @"Field",
            Position = @"NDS.1",
            Name = @"Notification Reference Number",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains a unique sequential reference number that may be used by various components to refer to this transaction. This number is generated by the originator of this notification.",
            Sample = @"",
        };

        

        

        

        return notificationReferenceNumber;
    } 
}
internal HL7V251Field notificationDateTime;

public HL7V251Field NotificationDateTime
{
    get
    {
        if (notificationDateTime != null)
        {
            return notificationDateTime;
        }

        notificationDateTime = new HL7V251Field
        {
            field = message[@"NDS"][2],
            Id = @"NDS.2",
            Type = @"Field",
            Position = @"NDS.2",
            Name = @"Notification Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the date/time of the notifications.",
            Sample = @"",
        };

        

        

        

        return notificationDateTime;
    } 
}
internal HL7V251Field notificationAlertSeverity;

public HL7V251Field NotificationAlertSeverity
{
    get
    {
        if (notificationAlertSeverity != null)
        {
            return notificationAlertSeverity;
        }

        notificationAlertSeverity = new HL7V251Field
        {
            field = message[@"NDS"][3],
            Id = @"NDS.3",
            Type = @"Field",
            Position = @"NDS.3",
            Name = @"Notification Alert Severity",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0367",
            TableName = @"Alert level",
            Description = @"The severity of the specific notification. Refer to HL7 Table 0367 - Alert level for valid entries.",
            Sample = @"",
        };

        

        

        

        return notificationAlertSeverity;
    } 
}
internal HL7V251Field notificationCode;

public HL7V251Field NotificationCode
{
    get
    {
        if (notificationCode != null)
        {
            return notificationCode;
        }

        notificationCode = new HL7V251Field
        {
            field = message[@"NDS"][4],
            Id = @"NDS.4",
            Type = @"Field",
            Position = @"NDS.4",
            Name = @"Notification Code",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains information about the type of notification being sent. These are manufacturer and equipment specific error or status codes, e.g., AQN0123 - aliquoting error - clot detected.",
            Sample = @"",
        };

        

        

        

        return notificationCode;
    } 
}

    }
}
