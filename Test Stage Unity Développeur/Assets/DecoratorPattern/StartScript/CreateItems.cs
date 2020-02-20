using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInterface;
using Decorator;
using ItemClass;

public class CreateItems : MonoBehaviour
{

    private void Start()
    {
        IItem swordBronze = CreateSwordBronze();
        Debug.Log(swordBronze.GetName());
        Debug.Log(swordBronze.GetDescription());
        
        IItem swordSilver = CreateSwordSilver();
        Debug.Log(swordSilver.GetName());
        Debug.Log(swordSilver.GetDescription());

        IItem swordGold = CreateSwordGold();
        Debug.Log(swordGold.GetName());
        Debug.Log(swordGold.GetDescription());

        IItem potionHeal = CreatePotionHeal();
        Debug.Log(potionHeal.GetName());
        Debug.Log(potionHeal.GetDescription());

        IItem potionCritical = CreatePotionCritical();
        Debug.Log(potionCritical.GetName());
        Debug.Log(potionCritical.GetDescription());

        IItem armorTorso = CreateArmorTorso();
        Debug.Log(armorTorso.GetName());
        Debug.Log(armorTorso.GetDescription());

        IItem armorHands = CreateArmorHands();
        Debug.Log(armorHands.GetName());
        Debug.Log(armorHands.GetDescription());
    }


    IItem CreateSwordBronze()
    {
        IItem swordBronze = new Item("SwordBronze");
        Damage swordBronzeDamage = new Damage(swordBronze,2,3);
        PhysicalDamage swordBronzePhysical = new PhysicalDamage(swordBronzeDamage);
        return swordBronze;
    }

    IItem CreateSwordSilver()
    {
        IItem swordSilver = new Item("SwordSilver");
        Damage swordSilverDamage = new Damage(swordSilver,4,5);
        MagicalDamage swordSilverMagical = new MagicalDamage(swordSilverDamage);
        CriticalChanceBuff swordSilverCrit = new CriticalChanceBuff(swordSilverMagical,20);
        return swordSilver;
    }

    IItem CreateSwordGold()
    {
        IItem swordGold = new Item("SwordGold");
        Damage swordGoldDamage = new Damage(swordGold,6,7);
        PhysicalDamage swordGoldPhysical = new PhysicalDamage(swordGoldDamage);
        CriticalChanceBuff swordGoldCrit = new CriticalChanceBuff(swordGoldPhysical,20);
        HealOnAttack swordGoldHealAttack = new HealOnAttack(swordGoldCrit,3);
        return swordGold;
    }

    IItem CreatePotionHeal()
    {
        IItem potion = new Item("PotionHeal");
        Heal potionHeal = new Heal(potion,15);
        return potion;
    }

    IItem CreatePotionCritical()
    {
        IItem potion = new Item("PotionCritical");
        TimedCritBuff potioncrit = new TimedCritBuff(potion,30,1);
        return potion;
    }

    IItem CreateArmorTorso()
    {
        IItem armor = new Item("ArmorTorso");
        PhysicalArmor armorPhysical = new PhysicalArmor(armor,3);
        MagicalArmor armorMagical = new MagicalArmor(armorPhysical,1);
        MaxHealthBuff armorMaxHealth = new MaxHealthBuff(armorMagical,3);
        return armor;
    }

    IItem CreateArmorHands()
    {
        IItem armor = new Item("ArmorHands");
        PhysicalArmor armorPhysical = new PhysicalArmor(armor,1);
        MagicalArmor armorMagical = new MagicalArmor(armorPhysical,1);
        CriticalChanceBuff armorCrit = new CriticalChanceBuff(armorMagical,5);
        return armor;
    }
}
