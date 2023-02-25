using UnityEngine;
using System.Collections;

public class collisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "bullet") {

            //le 10 pourra etre remplacer par une stat de l'arme
            gameObject.GetComponentInParent<InfosEnnemi>().loseHp(10);

            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
