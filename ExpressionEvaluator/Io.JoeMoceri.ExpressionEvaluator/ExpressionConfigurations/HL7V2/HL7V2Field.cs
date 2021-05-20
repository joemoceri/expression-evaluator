﻿using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V2Field
    {
        public HL7V2Field()
        {
            Components = new List<HL7V2FieldComponent>();
        }

        public int Id { get; set; }

        public string Delimiter { get; set; }

        public string Value { get; set; }

        public IList<HL7V2FieldComponent> Components { get; set; }
    }
}