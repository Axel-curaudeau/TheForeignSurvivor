using UnityEngine;
using System.Collections;

public class collisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            gameObject.GetComponentInParent<InfosEnnemi>().loseHp(10);

            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Sword")
        {
            gameObject.GetComponentInParent<InfosEnnemi>().loseHp(collision.GetComponent<Sword>().swordData.damage);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
