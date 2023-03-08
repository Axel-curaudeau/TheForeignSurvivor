using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public int experience;
    public GameObject shield;
    private bool haveShield=false;
    private bool haveSlot=false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        experience = gameObject.GetComponent<infosPlayer>().experience;

        if (experience>=1000 && haveShield == false) { ShieldApparition(); }

        if(!haveSlot && experience >= 500)
        {
            Inventory.instance.upgradeSlot();
        }
    }

    private void ShieldApparition()
    {
        float[] phi = {0,2*Mathf.PI/3,4*Mathf.PI/3 };

        for (int i = 0; i < 3; i++)
        {
            shield.GetComponent<ShieldPatrol>().phi = phi[i];
            Instantiate(shield, transform.position, Quaternion.identity);
        }
        haveShield = true;
    }
}
