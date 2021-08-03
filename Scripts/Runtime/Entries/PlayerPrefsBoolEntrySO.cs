﻿using UnityEngine;

namespace Plugins.ScriptablePlayerPrefs
{
    [CreateAssetMenu(menuName = BaseCreateAssetMenuPath + "Entry (Bool)", order = CreateAssetMenuOrder)]
    public class PlayerPrefsBoolEntrySO : BasePlayerPrefsEntrySO<bool>
    {
        public override bool Get()
        {
            return GetIntAsBool(
                PlayerPrefs.GetInt(keyRef.Value)
            );
        }

        public override bool Get(bool defaultValue)
        {
            int result = PlayerPrefs.GetInt(keyRef.Value, GetBoolAsInt(defaultValue));
            return GetIntAsBool(result);
        }

        public override void Save(bool value)
        {
            PlayerPrefs.SetInt(keyRef.Value, GetBoolAsInt(value));
            PlayerPrefs.Save();
        }

        private static bool GetIntAsBool(int value)
        {
            return value == 1;
        }

        private static int GetBoolAsInt(bool value)
        {
            return value ? 1 : 0;
        }
    }
}