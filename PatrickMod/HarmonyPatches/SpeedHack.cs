using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


namespace PatrickMod.HarmonyPatches
{
    [HarmonyPatch(typeof(Actor_PlayerCC), "UpdateTargetVelocity")]
    internal class Actor_PlayerCC_UpdateTargetVelocity
    {
        static void Prefix(ref Actor_PlayerCC __instance)
        {
            __instance.moveSpeed = 19;
            __instance.jumpHeight = 19;
        }
    }
}
