﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSON;
using AdofaiMapConverter.Types;

namespace AdofaiMapConverter.Decorations
{
    public class UnknownDecoration : Decoration
    {
        private JsonNode raw;
        public UnknownDecoration(JsonNode raw) : base(LevelEventType.None, true)
            => this.raw = raw;
        public override JsonNode ToNode() => raw;
    }
}
