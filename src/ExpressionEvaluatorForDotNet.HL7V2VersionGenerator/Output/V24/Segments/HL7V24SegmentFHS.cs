using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentFHS
    {
        private readonly HL7V2Message message;

        public string Id { get { return @"FHS"; } }

        public string SegmentId { get { return @"FHS"; } }
        
        public string LongName { get { return @"File Header Segment"; } }
        
        public string Description { get { return @"The FHS segment is used to head a file (group of batches) as defined in Section 2.15.3, “HL7 batch protocol.”"; } }
        
        public string Sample { get { return @""; } }

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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FHS.1",
                            Type = @"Field",
                            Position = @"FHS.1",
                            Name = @"File Field Separator",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.2",
                            Type = @"Field",
                            Position = @"FHS.2",
                            Name = @"File Encoding Characters",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.3",
                            Type = @"Field",
                            Position = @"FHS.3",
                            Name = @"File Sending Application",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.4",
                            Type = @"Field",
                            Position = @"FHS.4",
                            Name = @"File Sending Facility",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.5",
                            Type = @"Field",
                            Position = @"FHS.5",
                            Name = @"File Receiving Application",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.6",
                            Type = @"Field",
                            Position = @"FHS.6",
                            Name = @"File Receiving Facility",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.7",
                            Type = @"Field",
                            Position = @"FHS.7",
                            Name = @"File Creation Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FHS.7.1",
                            Type = @"Component",
                            Position = @"FHS.7.1",
                            Name = @"Time Of An Event",
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
                            Id = @"FHS.7.2",
                            Type = @"Component",
                            Position = @"FHS.7.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.8",
                            Type = @"Field",
                            Position = @"FHS.8",
                            Name = @"File Security",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.9",
                            Type = @"Field",
                            Position = @"FHS.9",
                            Name = @"File Name/ID",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field can be used by the application processing file.  Its use is not further specified",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.10",
                            Type = @"Field",
                            Position = @"FHS.10",
                            Name = @"File Header Comment",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the free text field, the use of which is not further specified",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.11",
                            Type = @"Field",
                            Position = @"FHS.11",
                            Name = @"File Control ID",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to identify a particular file uniquely.  It can be echoed back in FHS-12-reference file control ID",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.12",
                            Type = @"Field",
                            Position = @"FHS.12",
                            Name = @"Reference File Control ID",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the value of FHS-11-file control ID when this file was originally transmitted.  Not present if this file is being transmitted for the first time",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V24SegmentFHS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field fileFieldSeparator;

public HL7V24Field FileFieldSeparator
{
    get
    {
        if (fileFieldSeparator != null)
        {
            return fileFieldSeparator;
        }

        fileFieldSeparator = new HL7V24Field
        {
            field = message[@"FHS"][1],
            Id = @"FHS.1",
            Type = @"Field",
            Position = @"FHS.1",
            Name = @"File Field Separator",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileFieldSeparator.field.FieldRepetitions != null && fileFieldSeparator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileFieldSeparator.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < fileFieldSeparator.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = fileFieldSeparator.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < fileFieldSeparator.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = fileFieldSeparator.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < fileFieldSeparator.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = fileFieldSeparator.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            fileFieldSeparator.fieldRepetitions = fieldRepetitions;
        }

        return fileFieldSeparator;
    } 
}

internal HL7V24Field fileEncodingCharacters;

public HL7V24Field FileEncodingCharacters
{
    get
    {
        if (fileEncodingCharacters != null)
        {
            return fileEncodingCharacters;
        }

        fileEncodingCharacters = new HL7V24Field
        {
            field = message[@"FHS"][2],
            Id = @"FHS.2",
            Type = @"Field",
            Position = @"FHS.2",
            Name = @"File Encoding Characters",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileEncodingCharacters.field.FieldRepetitions != null && fileEncodingCharacters.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileEncodingCharacters.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < fileEncodingCharacters.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = fileEncodingCharacters.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < fileEncodingCharacters.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = fileEncodingCharacters.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < fileEncodingCharacters.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = fileEncodingCharacters.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            fileEncodingCharacters.fieldRepetitions = fieldRepetitions;
        }

        return fileEncodingCharacters;
    } 
}

internal HL7V24Field fileSendingApplication;

public HL7V24Field FileSendingApplication
{
    get
    {
        if (fileSendingApplication != null)
        {
            return fileSendingApplication;
        }

        fileSendingApplication = new HL7V24Field
        {
            field = message[@"FHS"][3],
            Id = @"FHS.3",
            Type = @"Field",
            Position = @"FHS.3",
            Name = @"File Sending Application",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileSendingApplication.field.FieldRepetitions != null && fileSendingApplication.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileSendingApplication.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < fileSendingApplication.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = fileSendingApplication.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < fileSendingApplication.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = fileSendingApplication.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < fileSendingApplication.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = fileSendingApplication.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            fileSendingApplication.fieldRepetitions = fieldRepetitions;
        }

        return fileSendingApplication;
    } 
}

internal HL7V24Field fileSendingFacility;

public HL7V24Field FileSendingFacility
{
    get
    {
        if (fileSendingFacility != null)
        {
            return fileSendingFacility;
        }

        fileSendingFacility = new HL7V24Field
        {
            field = message[@"FHS"][4],
            Id = @"FHS.4",
            Type = @"Field",
            Position = @"FHS.4",
            Name = @"File Sending Facility",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileSendingFacility.field.FieldRepetitions != null && fileSendingFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileSendingFacility.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < fileSendingFacility.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = fileSendingFacility.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < fileSendingFacility.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = fileSendingFacility.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < fileSendingFacility.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = fileSendingFacility.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            fileSendingFacility.fieldRepetitions = fieldRepetitions;
        }

        return fileSendingFacility;
    } 
}

internal HL7V24Field fileReceivingApplication;

public HL7V24Field FileReceivingApplication
{
    get
    {
        if (fileReceivingApplication != null)
        {
            return fileReceivingApplication;
        }

        fileReceivingApplication = new HL7V24Field
        {
            field = message[@"FHS"][5],
            Id = @"FHS.5",
            Type = @"Field",
            Position = @"FHS.5",
            Name = @"File Receiving Application",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileReceivingApplication.field.FieldRepetitions != null && fileReceivingApplication.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileReceivingApplication.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < fileReceivingApplication.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = fileReceivingApplication.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < fileReceivingApplication.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = fileReceivingApplication.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < fileReceivingApplication.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = fileReceivingApplication.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            fileReceivingApplication.fieldRepetitions = fieldRepetitions;
        }

        return fileReceivingApplication;
    } 
}

internal HL7V24Field fileReceivingFacility;

public HL7V24Field FileReceivingFacility
{
    get
    {
        if (fileReceivingFacility != null)
        {
            return fileReceivingFacility;
        }

        fileReceivingFacility = new HL7V24Field
        {
            field = message[@"FHS"][6],
            Id = @"FHS.6",
            Type = @"Field",
            Position = @"FHS.6",
            Name = @"File Receiving Facility",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileReceivingFacility.field.FieldRepetitions != null && fileReceivingFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileReceivingFacility.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < fileReceivingFacility.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = fileReceivingFacility.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < fileReceivingFacility.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = fileReceivingFacility.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < fileReceivingFacility.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = fileReceivingFacility.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            fileReceivingFacility.fieldRepetitions = fieldRepetitions;
        }

        return fileReceivingFacility;
    } 
}

internal HL7V24Field fileCreationDateTime;

public HL7V24Field FileCreationDateTime
{
    get
    {
        if (fileCreationDateTime != null)
        {
            return fileCreationDateTime;
        }

        fileCreationDateTime = new HL7V24Field
        {
            field = message[@"FHS"][7],
            Id = @"FHS.7",
            Type = @"Field",
            Position = @"FHS.7",
            Name = @"File Creation Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileCreationDateTime.field.FieldRepetitions != null && fileCreationDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileCreationDateTime.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < fileCreationDateTime.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = fileCreationDateTime.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < fileCreationDateTime.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = fileCreationDateTime.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < fileCreationDateTime.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = fileCreationDateTime.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            fileCreationDateTime.fieldRepetitions = fieldRepetitions;
        }

        return fileCreationDateTime;
    } 
}

internal HL7V24Field fileSecurity;

public HL7V24Field FileSecurity
{
    get
    {
        if (fileSecurity != null)
        {
            return fileSecurity;
        }

        fileSecurity = new HL7V24Field
        {
            field = message[@"FHS"][8],
            Id = @"FHS.8",
            Type = @"Field",
            Position = @"FHS.8",
            Name = @"File Security",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileSecurity.field.FieldRepetitions != null && fileSecurity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileSecurity.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < fileSecurity.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = fileSecurity.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < fileSecurity.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = fileSecurity.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < fileSecurity.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = fileSecurity.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            fileSecurity.fieldRepetitions = fieldRepetitions;
        }

        return fileSecurity;
    } 
}

internal HL7V24Field fileNameID;

public HL7V24Field FileNameID
{
    get
    {
        if (fileNameID != null)
        {
            return fileNameID;
        }

        fileNameID = new HL7V24Field
        {
            field = message[@"FHS"][9],
            Id = @"FHS.9",
            Type = @"Field",
            Position = @"FHS.9",
            Name = @"File Name/ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field can be used by the application processing file.  Its use is not further specified",
            Sample = @"",
        };

        // check for repetitions
        if (fileNameID.field.FieldRepetitions != null && fileNameID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileNameID.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < fileNameID.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = fileNameID.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < fileNameID.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = fileNameID.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < fileNameID.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = fileNameID.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            fileNameID.fieldRepetitions = fieldRepetitions;
        }

        return fileNameID;
    } 
}

internal HL7V24Field fileHeaderComment;

public HL7V24Field FileHeaderComment
{
    get
    {
        if (fileHeaderComment != null)
        {
            return fileHeaderComment;
        }

        fileHeaderComment = new HL7V24Field
        {
            field = message[@"FHS"][10],
            Id = @"FHS.10",
            Type = @"Field",
            Position = @"FHS.10",
            Name = @"File Header Comment",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the free text field, the use of which is not further specified",
            Sample = @"",
        };

        // check for repetitions
        if (fileHeaderComment.field.FieldRepetitions != null && fileHeaderComment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileHeaderComment.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < fileHeaderComment.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = fileHeaderComment.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < fileHeaderComment.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = fileHeaderComment.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < fileHeaderComment.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = fileHeaderComment.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            fileHeaderComment.fieldRepetitions = fieldRepetitions;
        }

        return fileHeaderComment;
    } 
}

internal HL7V24Field fileControlID;

public HL7V24Field FileControlID
{
    get
    {
        if (fileControlID != null)
        {
            return fileControlID;
        }

        fileControlID = new HL7V24Field
        {
            field = message[@"FHS"][11],
            Id = @"FHS.11",
            Type = @"Field",
            Position = @"FHS.11",
            Name = @"File Control ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is used to identify a particular file uniquely.  It can be echoed back in FHS-12-reference file control ID",
            Sample = @"",
        };

        // check for repetitions
        if (fileControlID.field.FieldRepetitions != null && fileControlID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileControlID.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < fileControlID.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = fileControlID.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < fileControlID.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = fileControlID.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < fileControlID.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = fileControlID.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            fileControlID.fieldRepetitions = fieldRepetitions;
        }

        return fileControlID;
    } 
}

internal HL7V24Field referenceFileControlID;

public HL7V24Field ReferenceFileControlID
{
    get
    {
        if (referenceFileControlID != null)
        {
            return referenceFileControlID;
        }

        referenceFileControlID = new HL7V24Field
        {
            field = message[@"FHS"][12],
            Id = @"FHS.12",
            Type = @"Field",
            Position = @"FHS.12",
            Name = @"Reference File Control ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the value of FHS-11-file control ID when this file was originally transmitted.  Not present if this file is being transmitted for the first time",
            Sample = @"",
        };

        // check for repetitions
        if (referenceFileControlID.field.FieldRepetitions != null && referenceFileControlID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(referenceFileControlID.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < referenceFileControlID.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = referenceFileControlID.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < referenceFileControlID.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = referenceFileControlID.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < referenceFileControlID.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = referenceFileControlID.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            referenceFileControlID.fieldRepetitions = fieldRepetitions;
        }

        return referenceFileControlID;
    } 
}
    }
}
