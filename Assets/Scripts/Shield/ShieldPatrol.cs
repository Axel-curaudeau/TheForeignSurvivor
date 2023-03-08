using UnityEngine;

public class ShieldPatrol : MonoBehaviour
{
    private GameObject player;

    private float timer=0;

    private float posX;
    private float posY;
    public float phi=0;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        posX = 7*Mathf.Cos(timer + phi) + player.transform.position.x;
        posY = 7*Mathf.Sin(timer + phi) + (player.transform.position.y - 1.5f); // "-1.5" because transform is not in the center of player sprite

        transform.position = new Vector3(posX, posY, 0f);
    }
}
