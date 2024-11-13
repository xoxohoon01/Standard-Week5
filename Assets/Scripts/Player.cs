using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject BulletPrefab;
    public GameObject GrenadePrefab;
    public GameObject MagicPrefab;

    private IState currentState;
    private float attackDelay;
    private float attackTime;

    private void CheckCanAttack()
    {
        if (attackDelay <= attackTime)
        {
            attackDelay = currentState.Fire();
        }
    }

    private void Update()
    {
        
    }
}
