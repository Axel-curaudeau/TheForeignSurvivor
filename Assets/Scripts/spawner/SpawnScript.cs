using System.Collections;
using UnityEngine;
using static UnityEditor.UIElements.ToolbarMenu;

public class SpawnScript : MonoBehaviour
{
    public GameObject ennemi;
    public GameObject[] spawnPoints = new GameObject[4];
    public int nombreEnnemi;

    int randomInt;  //pour determiner le lieu de spawn
    private bool isGenerating=true;
    public float waveTime;
    public float spawnTime;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generateWave());
    }

    IEnumerator generateWave() //ceci est une coroutine 
    {
        while (isGenerating)
        {
            for (int i = 0; i <= nombreEnnemi; i++)
            {
                randomInt = UnityEngine.Random.Range(0, 4);
                float varianceInt = Random.Range(-2f, 2f);  //pour espacer les ennemis au moment du spawn
                Vector3 varianceVector = new Vector3(varianceInt, varianceInt, 0);
                Instantiate(ennemi, spawnPoints[randomInt].transform.position+varianceVector, Quaternion.identity);

                yield return new WaitForSeconds(spawnTime);
            }
             yield return new WaitForSeconds(waveTime); //yield permet de mettre en pause la corouine pendant "waveTime" secondes
        }
       
    }
}
