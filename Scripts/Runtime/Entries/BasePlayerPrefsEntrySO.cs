using UnityAtoms.BaseAtoms;
using UnityEngine;
using Sirenix.OdinInspector;

namespace niscolas.UnityUtils.PlayerPrefs
{
    public abstract class BasePlayerPrefsEntrySO<T> : ScriptableObject
    {
        [SerializeField]
        protected StringReference _key;

        [SerializeField]
        private T _valueToSave;

        [ShowInInspector]
        private bool HasKey => UnityEngine.PlayerPrefs.HasKey(_key.Value);
        
        [ShowIf(nameof(HasKey)), ShowInInspector]
        public T SavedValue => Get();

        [Button]
        private void SaveValue()
        {
            Save(_valueToSave);
        }

        public abstract T Get();

        public abstract T Get(T defaultValue);

        public abstract void Save(T value);
    }
}