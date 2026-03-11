using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected int id;
    protected string weaponName;
    protected float fireRate;
    protected float lifeTime;
    protected GameObject hitboxPrefab;
    protected WeaponType weaponKind;
    protected float HitBoxDistance;
    protected float HitPoint;
    // Public getter so AttackGO can calculate cooldowns
    public float FireRate => fireRate;

    // Abstract method that Melee and Projectile MUST implement
    public abstract void Attack();
}