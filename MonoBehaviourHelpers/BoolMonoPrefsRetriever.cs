using UnityEngine;

namespace Plugins.ScriptablePlayerPrefs.MonoBehaviourHelpers {
	[AddComponentMenu("ScriptablePlayerPrefs/Mono Prefs Retriever : bool")]
	public class BoolMonoPrefsRetriever : BaseMonoPrefsRetriever<bool, ScriptablePlayerPrefsBoolEntry> { }
}