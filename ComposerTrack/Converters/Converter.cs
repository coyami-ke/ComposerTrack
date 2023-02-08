using AdofaiMapConverter.Actions;
using AdofaiMapConverter.Decorations;
using ComposerTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerTrack.Converters
{
    public static class Converter
    {
        public static MoveTrack KeyFrameToMoveTrack(KeyFrame input)
        {
            MoveTrack result      = new();
            result.positionOffset = new AdofaiMapConverter.Types.Vector2(input.Position.X, input.Position.Y);
            result.rotationOffset = input.Rotation;
            result.scale          = input.Scale.X;
            result.startTile      = (Convert.ToInt32(input.StartEndTile), AdofaiMapConverter.Types.TileRelativeTo.ThisTile);
            result.endTile        = (Convert.ToInt32(input.StartEndTile), AdofaiMapConverter.Types.TileRelativeTo.ThisTile);
            result.ease           = input.Ease;
            result.gapLength      = 0;
            result.opacity        = input.Opacity;
            result.duration       = input.Duration;
            result.active         = true;

            return result;
        }
        public static MoveDecorations KeyFrameToMoveDecorations(KeyFrame input)
        {
            MoveDecorations result = new();
            result.positionOffset  = new AdofaiMapConverter.Types.Vector2(input.Position.X, input.Position.Y);
            result.rotationOffset  = input.Rotation;
            result.scale           = input.Scale.X;
            result.duration        = input.Duration;
            result.ease            = input.Ease;
            result.tag             = input.Tag;
            return result;
        }
        public static PositionTrack TileDataToPositionTrack(TileData input)
        {
            PositionTrack result  = new();
            result.editorOnly     = AdofaiMapConverter.Types.Toggle.Disabled;
            result.positionOffset = new AdofaiMapConverter.Types.Vector2(input.Position.X, input.Position.Y);
            result.rotation       = input.Rotation;
            result.scale          = input.Position.X;
            result.relativeTo     = (0, AdofaiMapConverter.Types.TileRelativeTo.ThisTile);
            result.justThisTile   = AdofaiMapConverter.Types.Toggle.Disabled;
            result.opacity        = input.Opacity;
            return result;
        }
        public static AddDecoration DecoDataToDecoration(DecoData input)
        {
            AddDecoration result   = new();
            result.position        = new AdofaiMapConverter.Types.Vector2(input.Position.X, input.Position.Y);
            result.rotation        = input.Rotation;
            result.scale           = new AdofaiMapConverter.Types.Vector2(input.Scale.X, input.Scale.Y);
            result.decorationImage = input.Source;
            result.color           = input.Color;
            result.active          = true;
            result.tag             = input.Tag;
            result.relativeTo      = AdofaiMapConverter.Types.DecPlacementType.Tile;
            result.floor           = input.Beat;
            return result;
        }
    }
}
