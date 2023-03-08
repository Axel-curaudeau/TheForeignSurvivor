using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttackFollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 direction;

    private void FixedUpdate()
    {
        transform.position = player.transform.position + new Vector3(0, -1.5f, 0) + 2 * direction;
    }

    public void setPlayerAndDirection(GameObject player, Vector3 direction)
    {
        this.player = player;
        this.direction = direction;
    }
}
