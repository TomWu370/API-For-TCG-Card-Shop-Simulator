﻿using BepInEx;
using BepInEx.Logging;
using System;
using UnityEngine;

namespace Bepinex_Preload_Patch
{
    [BepInPlugin(MyGUID, PluginName, VersionString)]
    public class Plugin : BaseUnityPlugin
    {
        private const string MyGUID = "com.DarkDragoon.PreloaderTest";
        private const string PluginName = "PreloaderTest";
        private const string VersionString = "1.0.0";
        public static ManualLogSource Log { get; private set; }
        public void Awake()
        {
            Log = Logger; // Initialize the static Log property
            Logger.LogInfo($"PluginName: {PluginName}, VersionString: {VersionString} is loading...");
            Logger.LogInfo($"PluginName: {PluginName}, VersionString: {VersionString} is loaded.");
        }
        public void Update()
        {
            if (UnityEngine.Input.GetKeyUp(KeyCode.O))
            {
                foreach (EMonsterType monsterType in Enum.GetValues(typeof(EMonsterType)))
                {
                    Log.LogDebug("Found monstertype with name --" + monsterType.ToString());
                    Log.LogDebug("Found monstertype with value --" + (int)monsterType);
                }
            }
        }
    }
}
