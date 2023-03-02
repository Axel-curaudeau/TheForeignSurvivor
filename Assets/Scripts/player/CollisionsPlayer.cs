using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsPlayer : MonoBehaviour
{
    public int invulnerabilityFrames;
    private int invulnerabilityCurrentTime;
    private bool isInvulnerable;

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
            if (other.gameObject.tag == "Ennemi" || other.gameObject.tag == "ennemiBullet")
            {
                // 10 a remplacer par une stat de l'arme!
                gameObject.GetComponentInParent<infosPlayer>().loseHp(10);



            }
            isInvulnerable = true;
            invulnerabilityCurrentTime = 0;
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
}
