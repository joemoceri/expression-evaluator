﻿using System.Collections.Generic;

namespace Io.JoeMoceri.ExpressionEvaluator.LanguageTemplate
{
    public class HL7V2MessageSegment
    {
		public string SegmentName { get; set; }

        public IList<HL7V2Field> Fields { get; set; }

        public override string ToString()
        {
            return CombineHL7Fields();

			string CombineHL7Fields()
			{
				if (Fields == null || Fields.Count == 0)
				{
					return null;
				}

				var result = SegmentName;

				for (var i = 0; i < Fields.Count; i++)
				{
					result += $"{Fields[i].Delimiter}{Fields[i].Value}";
				}

				return result;
			}
		}
    }
}
