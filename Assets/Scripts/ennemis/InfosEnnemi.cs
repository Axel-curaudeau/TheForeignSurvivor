using UnityEngine;

public class InfosEnnemi : MonoBehaviour
{
    public int HP;
    public int damageOnHit;
    public int gainExperience;


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

    public void death() { 
        Destroy(gameObject);
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        giveExperience(player);
    }

    public void giveExperience(GameObject player)
    {
        player.GetComponent<infosPlayer>().experience += gainExperience;
    }
}
