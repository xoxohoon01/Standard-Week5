using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGunState : IState
{
    public float Fire(Player player)
    {
        GameObject projectile = player.LaunchProjectile(player.BulletPrefab);
        projectile.GetComponent<Rigidbody>().velocity = projectile.transform.forward * 30f;
        return 1.0f;
    }
}
