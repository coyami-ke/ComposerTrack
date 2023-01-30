using ComposerTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComposerTrack.ViewModels
{
    public static class Random
    {
        public static TileData[] RandomTiles(TileData[] data, int beat)
        {
            List<TileData> tilesData = new();

            foreach (var tile in data)
            {
                if (tile is null) continue;
                TileData tileData = tile;
                tileData.Rotation += RandomNumberGenerator.GetInt32(0, 10);

                var str = tileData.Position;
                str.X += RandomNumberGenerator.GetInt32(-4, 4);
                str.Y += RandomNumberGenerator.GetInt32(-4, 4);

                tileData.Position = str;
            }

            return tilesData.ToArray();
        }
    }
}
