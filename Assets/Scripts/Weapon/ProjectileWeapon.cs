using UnityEngine;
public class ProjectileWeapon : Weapon
{
    private float projectileSpeed;

    public void Build(WeaponSO weaponSO)
    {
        id = weaponSO.Id;
        weaponName = weaponSO.WeaponName;
        fireRate = weaponSO.fireRate;
        lifeTime = weaponSO.lifetime;
        hitboxPrefab = weaponSO.HitboxPrefab;
        weaponKind = weaponSO.WeaponKind;
        projectileSpeed = weaponSO.projectileSpeed;
    }

    public override void Attack()
    {
        Debug.Log($"[{weaponName}] Firing Projectile at speed {projectileSpeed}!");
        // Instantiate projectile prefab, add force/velocity, etc.
    }
}