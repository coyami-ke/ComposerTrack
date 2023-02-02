﻿using AdofaiMapConverter.Types;
using JSON;
using static AdofaiMapConverter.Actions.ActionUtils;

namespace AdofaiMapConverter.Actions.Default
{
    public class AutoPlayTiles : Action
    {
        public Toggle enabled = Toggle.Enabled;
        public Toggle safetyTiles = Toggle.Disabled;
        public AutoPlayTiles() : base(LevelEventType.AutoPlayTiles) { }
        public AutoPlayTiles(Toggle enabled, Toggle safetyTiles, bool active) : base(LevelEventType.AutoPlayTiles, active)
        {
            this.enabled = enabled;
            this.safetyTiles = safetyTiles;
        }
        public override JsonNode ToNode()
        {
            JsonNode node = InitNode(eventType, active);
            node["enabled"] = enabled.ToString();
            node["safetyTiles"] = safetyTiles.ToString();
            return node;
        }
    }
}
