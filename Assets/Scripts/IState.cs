using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    // 리턴값이 후딜레이
    public float Fire(Player player);
}
