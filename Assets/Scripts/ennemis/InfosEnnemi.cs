using UnityEngine;

public class InfosEnnemi : MonoBehaviour
{
    public int HP;
    public int damageOnHit;

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
    }
}
