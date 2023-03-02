using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infosPlayer : MonoBehaviour
{
    public int HP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loseHp(int hp)
    {
        HP -= hp;
        if (HP <= 0) { death(); }
    }

    public void death()
    {
        Debug.Log("You lose!");
    }
}
