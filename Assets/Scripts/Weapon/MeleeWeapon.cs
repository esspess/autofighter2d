using UnityEngine;

public class MeleeWeapon : Weapon
{
    public void Build(WeaponSO weaponSO)
    {
        id = weaponSO.Id;
        weaponName = weaponSO.WeaponName;
        fireRate = weaponSO.fireRate;
        lifeTime = weaponSO.lifetime;
        hitboxPrefab = weaponSO.HitboxPrefab;
        weaponKind = weaponSO.WeaponKind;
        HitBoxDistance = weaponSO.HitBoxDistance;
        HitPoint = weaponSO.HitPoint;
    }

    public override void Attack()
    {
        Debug.Log($"[{weaponName}] Executing Melee Attack!");
        // Instantiate melee hitbox, play animation, etc.

        HitBox hitbox = Instantiate(hitboxPrefab).GetComponent<HitBox>();
        if (hitbox != null) hitbox.SetHitPoint(HitPoint);

        hitbox.gameObject.transform.SetParent(gameObject.transform.parent);

        hitbox.gameObject.transform.position = transform.parent.position + new Vector3(0, -1.2f, 0);
        Destroy(hitbox.gameObject, lifeTime);
    }

}