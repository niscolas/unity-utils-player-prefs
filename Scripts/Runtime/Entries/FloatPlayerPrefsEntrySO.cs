using UnityEngine;

namespace niscolas.UnityUtils.PlayerPrefs
{
    [CreateAssetMenu(
        menuName = Constants.CreateAssetMenuPrefix + "Entry (Float)",
        order = Constants.CreateAssetMenuOrder)]
    public class FloatPlayerPrefsEntrySO : BasePlayerPrefsEntrySO<float>
    {
        public override float Get()
        {
            return UnityEngine.PlayerPrefs.GetFloat(_key.Value);
        }

        public override float Get(float defaultValue)
        {
            return UnityEngine.PlayerPrefs.GetFloat(_key.Value, defaultValue);
        }

        public override void Save(float value)
        {
            UnityEngine.PlayerPrefs.SetFloat(_key.Value, value);
            UnityEngine.PlayerPrefs.Save();
        }
    }
}