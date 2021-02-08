using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Plugins.ScriptablePlayerPrefs.MonoBehaviourHelpers {
	public class BaseMonoPrefsRetriever<T, TPPE> : MonoBehaviour
		where TPPE : BaseScriptablePlayerPrefsEntry<T> {
		[SerializeField]
		private TPPE scriptablePlayerPrefsEntry;

		[SerializeField]
		private T defaultValue;

		[SerializeField]
		private AtomCondition<T>[] conditions;

		[Header("Events")]
		[SerializeField]
		private UnityEvent<T> onRetrieved;

		public void Retrieve() {
			if (!scriptablePlayerPrefsEntry) {
				return;
			}

			T result = scriptablePlayerPrefsEntry.Get(defaultValue);

			foreach (AtomCondition<T> condition in conditions) {
				if (!condition.Call(result)) {
					return;
				}
			}

			onRetrieved?.Invoke(result);
		}
	}
}