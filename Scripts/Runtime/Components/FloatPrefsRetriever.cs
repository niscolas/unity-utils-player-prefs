using UnityAtoms.BaseAtoms;

namespace niscolas.UnityUtils.PlayerPrefs
{
    public class FloatPrefsRetriever : BasePrefsRetriever<
        float,
        FloatReference,
        FloatPair,
        FloatConstant,
        FloatVariable,
        FloatEvent,
        FloatPairEvent,
        FloatFloatFunction,
        FloatVariableInstancer,
        FloatPlayerPrefsEntrySO> { }
}