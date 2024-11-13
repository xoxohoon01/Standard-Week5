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
            attackDelay = currentState.Fire(this);
        }
    }

    public GameObject LaunchProjectile(GameObject prefab)
    {
        return Instantiate(prefab);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentState.Fire(this);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentState = new IGunState();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentState = new IThrowState();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentState = new IMagicState();
        }
    }
}
