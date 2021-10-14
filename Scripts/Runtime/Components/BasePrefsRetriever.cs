using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace niscolas.UnityUtils.PlayerPrefs
{
    public class BasePrefsRetriever<T, TR, P, C, V, E1, E2, F, VI, TPPE> : MonoBehaviour
        where TR : AtomReference<T, P, C, V, E1, E2, F, VI>
        where TPPE : BasePlayerPrefsEntrySO<T>
        where P : struct, IPair<T>
        where C : AtomBaseVariable<T>
        where V : AtomVariable<T, P, E1, E2, F>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<P>
        where F : AtomFunction<T, T>
        where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
    {
        [SerializeField]
        private TPPE _entry;

        [SerializeField]
        private TR _defaultValue;

        [Header("Events")]
        [SerializeField]
        private UnityEvent<T> _onRetrieved;

        public void Retrieve()
        {
            if (!_entry)
            {
                return;
            }

            T result = _entry.Get(_defaultValue.Value);

            _onRetrieved?.Invoke(result);
        }
    }
}