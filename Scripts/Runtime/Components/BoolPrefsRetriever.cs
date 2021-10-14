using UnityAtoms.BaseAtoms;

namespace niscolas.UnityUtils.PlayerPrefs
{
    public class BoolPrefsRetriever : BasePrefsRetriever<
        bool,
        BoolReference,
        BoolPair,
        BoolConstant,
        BoolVariable,
        BoolEvent,
        BoolPairEvent,
        BoolBoolFunction,
        BoolVariableInstancer,
        BoolPlayerPrefsEntrySO> { }
}