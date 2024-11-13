using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMagicState : IState
{
    public float Fire(Player player)
    {
        int count = 10;
        for (int i = 0; i < count; i++)
        {
            GameObject projectile = player.LaunchProjectile(player.MagicPrefab);
            projectile.transform.eulerAngles = player.transform.forward + new Vector3(0, (360 / count) * i, 0);
            Vector3 dir = projectile.transform.forward * 10f;
            projectile.GetComponent<Rigidbody>().velocity = dir;
        }
        
        return 3f;
    }
}