using UnityEngine;

public enum WeaponType
{
    Melee,
    Projectile
}

[CreateAssetMenu(menuName = "Scriptable Objects/Weapon")]
public class WeaponSO : ScriptableObject
{
    public int Id;
    public string WeaponName;
    public float fireRate;
    public float lifetime;
    public GameObject HitboxPrefab;
    public WeaponType WeaponKind;
    public float HitBoxDistance;
    public float HitPoint;
    [Header("Projectile Only")]
    public float projectileSpeed;
}