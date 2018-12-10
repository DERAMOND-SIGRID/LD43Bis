using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour {

    [SerializeField]
    private float moveSpeed;
    public float GetMoveSpeed() { return moveSpeed; }

    [SerializeField]
    private int attackDistance;
    public int GetAttackDistance() { return attackDistance; }

}
