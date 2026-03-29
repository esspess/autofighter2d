using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects / AttackSO")]
public class AttackSO : ScriptableObject
{
    public WeaponGO AttackWeapon;
    public int AttackDamage;
    public int AttackPower;
}