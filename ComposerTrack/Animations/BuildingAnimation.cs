using ComposerTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

#nullable disable
namespace ComposerTrack.Animations
{
    public static class BuildingAnimation
    {
        /// <summary>
        /// Animation of build
        /// </summary>
        /// <param name="tileData"></param>
        /// <param name="intensivity"></param>
        /// <param name="withRotation"></param>
        /// <returns></returns>
        public static TileData Build(TileData tileData, int intensivity = 1, bool withRotation = true)
        {
            List<KeyFrame> keyFrame = new();
            TileData tile = tileData;

            if (tile is null) return null;

            Vector2 str = new(tile.Position.X, tile.Position.Y);

            if (tile.Angle < 0) tile.Angle += 360f;

            if (tile.Angle >= 0 && tile.Angle < 90)
            {
                str.X += 0f * intensivity;
                str.Y += 1f * intensivity;
                if (withRotation)
                {

                }
            }
            if (tile.Angle >= 90 && tile.Angle < 180)
            {
                str.X += 1f * intensivity;
                str.Y += 1f * intensivity;
            }
            if (tile.Angle >= 180 && tile.Angle < 270)
            {
                str.X += 1f * intensivity;
                str.Y += 0f * intensivity;
            }
            if (tile.Angle >= 270 && tile.Angle < 360)
            {
                str.X += -1f * intensivity;
                str.Y += 0f * intensivity;
            }

            tile.Position = str;

            return tile;
        }
    }
}
