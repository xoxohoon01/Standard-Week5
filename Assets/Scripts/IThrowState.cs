using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IThrowState : IState
{
    public float Fire(Player player)
    {
        GameObject projectile = player.LaunchProjectile(player.GrenadePrefab);
        projectile.GetComponent<Rigidbody>().velocity = projectile.transform.forward * 10f;
        return 3f;
    }
}
