using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour
{
    public int experience;
    public GameObject shield;
    private bool haveShield=false;
    private bool haveSlot=false;

    public GameObject Annoucement;
    public Text AnnoucementText;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        experience = gameObject.GetComponent<infosPlayer>().experience;

        if (experience>=1000 && haveShield == false) 
        { 
            ShieldApparition();
            StartCoroutine(PowerUpAnnoucement(2));
        }

        if(!haveSlot && experience >= 500)
        {
            Inventory.instance.upgradeSlot();
            StartCoroutine(PowerUpAnnoucement(1));
            haveSlot = true;
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

    private IEnumerator PowerUpAnnoucement(int annoucementType)
    {
        if (annoucementType == 1)
        {
            AnnoucementText.text = "new inventory slot unlocked";
        }

        else if (annoucementType == 2)
        {
            AnnoucementText.text = "shields unlocked";
        }


        Debug.Log("début annonce");
        Annoucement.SetActive(true);
        yield return new WaitForSeconds(5f);
        Annoucement.SetActive(false);
        Debug.Log("Fin annonce");

    }
}
