using UnityEngine;

public class InfosEnnemi : MonoBehaviour
{
    public int HP;
    public int damageOnHit;
    public int gainExperience;
    public GameObject HeartPrefab;


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

        lootHP(1);
    }

    public void giveExperience(GameObject player)
    {
        player.GetComponent<infosPlayer>().experience += gainExperience;
    }

    public void lootHP(int percentage)
    {
        if (Random.Range(0f, 100f) < percentage)
        {
            Instantiate(HeartPrefab, transform.position, Quaternion.identity).name = "Heart:";
        }
    }
}
