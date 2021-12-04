using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PerkFactory
{
    public static Perk CreatePerkFormTemplate (PerkVariant perkVariant)
    {
        var perk = new Perk(
            perkVariant.PerkType,
            perkVariant.AttackType,
            perkVariant.Icon,
            perkVariant.VisualEffect,
            perkVariant.Discription,
            perkVariant.Name,
            perkVariant.ApplyingDamage,
            perkVariant.ApplyingDefense,
            perkVariant.ApplyingEnergy,
            perkVariant.Level,
            perkVariant.IsTest);

        return perk;
    }
}
