using niscolas.UnityUtils.Core;
using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsScriptablePrefsUtils.Conditions.CompareToPrefs
{
    [CreateAssetMenu(
        menuName = UnityAtomsConstants.ConditionsCreateAssetMenuPrefix + "(bool) => Compare Prefs Entry")]
    public class CompareBoolToBoolPrefsEntry : BaseCompareToPrefsEntry<
        bool,
        BoolPair,
        BoolConstant,
        BoolVariable,
        BoolEvent,
        BoolPairEvent,
        BoolBoolFunction,
        BoolVariableInstancer,
        BoolReference,
        bool,
        BoolPair,
        BoolConstant,
        BoolVariable,
        BoolEvent,
        BoolPairEvent,
        BoolBoolFunction,
        BoolVariableInstancer,
        BoolReference,
        bool>
    {
        public override bool Call(bool t1)
        {
            bool result = scriptablePrefsEntry.Get(defaultValueRef.Value) == t1;

            return comparisonOperator switch
            {
                ComparisonOperator.NotEqual => !result,
                _ => result
            };
        }

        public bool Call()
        {
            return Call(operand2Ref.Value);
        }
    }
}