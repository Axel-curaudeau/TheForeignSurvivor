using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public Weapon swordData;

    public Animator animator;

    public SpriteRenderer spriteRenderer;

    public static int CoolDown = 0;


    public void Attack(Vector2 direction)
    {
        spriteRenderer.flipX = direction.x == -1;
        transform.rotation = Quaternion.Euler(0, 0, direction.y * 90);
        StartCoroutine(AttackSequence());
        CoolDown = swordData.attackSpeed;
    }

    public IEnumerator AttackSequence()
    {
        animator.SetTrigger("Attacking");
        yield return new WaitForSeconds(0.45f);
        Debug.Log("Attack");
        Destroy(transform.gameObject);
    }
}
