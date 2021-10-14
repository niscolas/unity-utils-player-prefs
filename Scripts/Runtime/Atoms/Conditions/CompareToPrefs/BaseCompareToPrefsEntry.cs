using niscolas.UnityUtils.Core;
using niscolas.UnityUtils.PlayerPrefs;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsScriptablePrefsUtils.Conditions.CompareToPrefs
{
    public abstract class BaseCompareToPrefsEntry
    <
        TOp2, POp2, COp2, VOp2, E1Op2, E2Op2, FOp2, VIOp2, ROp2, TEntry, PEntry, CEntry, VEntry, E1Entry, E2Entry,
        FEntry, VIEntry, REntry, TParam
    > : AtomCondition<TParam>
        where POp2 : struct, IPair<TOp2>
        where COp2 : AtomBaseVariable<TOp2>
        where VOp2 : AtomVariable<TOp2, POp2, E1Op2, E2Op2, FOp2>
        where E1Op2 : AtomEvent<TOp2>
        where E2Op2 : AtomEvent<POp2>
        where FOp2 : AtomFunction<TOp2, TOp2>
        where VIOp2 : AtomVariableInstancer<VOp2, POp2, TOp2, E1Op2, E2Op2, FOp2>
        where ROp2 : AtomReference<TOp2, POp2, COp2, VOp2, E1Op2, E2Op2, FOp2, VIOp2>
        where PEntry : struct, IPair<TEntry>
        where CEntry : AtomBaseVariable<TEntry>
        where VEntry : AtomVariable<TEntry, PEntry, E1Entry, E2Entry, FEntry>
        where E1Entry : AtomEvent<TEntry>
        where E2Entry : AtomEvent<PEntry>
        where FEntry : AtomFunction<TEntry, TEntry>
        where VIEntry : AtomVariableInstancer<VEntry, PEntry, TEntry, E1Entry, E2Entry, FEntry>
        where REntry : AtomReference<TEntry, PEntry, CEntry, VEntry, E1Entry, E2Entry, FEntry, VIEntry>
    {
        [SerializeField]
        protected BasePlayerPrefsEntrySO<TEntry> scriptablePrefsEntry;

        [SerializeField]
        protected REntry defaultValueRef;

        [SerializeField]
        protected ComparisonOperator comparisonOperator;

        [SerializeField]
        protected ROp2 operand2Ref;
    }
}