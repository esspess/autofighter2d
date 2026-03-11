using UnityEngine;

public enum WeaponType
{
    Melee,
    Projectile
}

[CreateAssetMenu(fileName = "New Weapon", menuName = "Database/Weapon")]
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