using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootFireBall : MonoBehaviour
{
    public GameObject fireBall;

    public int projectilSpeed;
    public int coolDown;
    private int timeInCoolDown;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").GetComponentInChildren<Transform>();
        timeInCoolDown = coolDown;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timeInCoolDown == 0) {
            Vector2 Direction = target.transform.position - transform.position;
            creatFireBall(Direction.normalized);
            timeInCoolDown = coolDown;
        }
        timeInCoolDown--;
    }

    private void creatFireBall(Vector2 Direction)
    {
        GameObject newFireBall = Instantiate(fireBall,transform.position,Quaternion.identity);
        newFireBall.GetComponent<Rigidbody2D>().velocity =  Direction * projectilSpeed;
    }
}
