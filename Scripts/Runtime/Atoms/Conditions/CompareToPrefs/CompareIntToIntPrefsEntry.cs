using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsScriptablePrefsUtils.Conditions.CompareToPrefs
{
    [CreateAssetMenu(menuName = UnityAtomsConstants.ConditionsCreateAssetMenuPrefix + "(int) => Compare to Int Prefs Entry")]
    public class CompareIntToIntPrefsEntry : BaseCompareToPrefsEntry<
        int,
        IntPair,
        IntConstant,
        IntVariable,
        IntEvent,
        IntPairEvent,
        IntIntFunction,
        IntVariableInstancer,
        IntReference,
        int,
        IntPair,
        IntConstant,
        IntVariable,
        IntEvent,
        IntPairEvent,
        IntIntFunction,
        IntVariableInstancer,
        IntReference,
        int> { }
}