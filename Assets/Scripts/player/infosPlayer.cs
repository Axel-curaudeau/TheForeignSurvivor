using UnityEngine;
using UnityEngine.UI;

public class infosPlayer : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public int experience=0;
    public Text experienceText;

    public healthBarre barre;



    

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        barre.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        experienceText.text = "Xp : " + experience.ToString();
    }

    public void loseHp(int damage)
    {
        currentHealth -= damage;
        barre.SetHealth(currentHealth);
        if (currentHealth <= 0) { death(); }
    }

    public void death()
    {
        GameOverManager.instance.OnPlayerDeath();
        player_movement.instance.enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<player_fire>().enabled = false;
    }

}
