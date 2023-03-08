using System.Collections;
using UnityEngine;

public class CollisionsPlayer : MonoBehaviour
{
    public int invulnerabilityFrames;
    private int invulnerabilityCurrentTime;
    private bool isInvulnerable;

    public SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        invulnerabilityCurrentTime = 0;
        isInvulnerable= false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (isInvulnerable == false) // if vulnerable take damage and set isInvulnerable to true
        {
            int damage;
            if (other.gameObject.tag == "Ennemi")
            {
                damage = other.gameObject.GetComponent<InfosEnnemi>().damageOnHit;
                gameObject.GetComponentInParent<infosPlayer>().loseHp(damage);

                isInvulnerable = true;
                StartCoroutine(InvicibilityFlash());
                invulnerabilityCurrentTime = 0;
            }
        }  
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isInvulnerable == false) { 
            int damage;
            if (other.gameObject.tag == "ennemiBullet")
            {
                damage = other.gameObject.GetComponent<infosFireBall>().damage;
                gameObject.GetComponentInParent<infosPlayer>().loseHp(damage);

                isInvulnerable = true;
                StartCoroutine(InvicibilityFlash());
                invulnerabilityCurrentTime = 0;

                Debug.Log(tag);
            }
        }

        if (other.gameObject.tag == "ennemiBullet")
        {
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isInvulnerable) //if invulnerable : decrement invulnerability timer 
        { 
            invulnerabilityCurrentTime++;
            if (invulnerabilityCurrentTime == invulnerabilityFrames) // if timer is over player become vulnerable
            {
                isInvulnerable = false;
            }
        }
    }

    public IEnumerator InvicibilityFlash()
    {
        while (isInvulnerable)
        {
            sprite.color = new Color(1f, 1f, 1f, 0f);
            yield return new WaitForSeconds(0.15f);
            sprite.color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(0.15f);
        }
    }
}
