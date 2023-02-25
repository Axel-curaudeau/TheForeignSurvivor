using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public Vector3 ball_velocity;
    public int lifeTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime--;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
