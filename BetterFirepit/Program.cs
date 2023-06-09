﻿using Vintagestory.API.Common;
using HarmonyLib;
using Vintagestory.API.Server;

namespace BetterFirepit
{
    internal class Program : ModSystem
    {
        public Harmony harmony;

        public override void StartServerSide(ICoreServerAPI api)
        {
            harmony = new Harmony("betterfirepit");
            harmony.PatchAll();
            ILogger logger = api.Logger;
            logger.Debug("Better Firepit: Patched firepit");
            base.StartServerSide(api);
        }
    }
}
