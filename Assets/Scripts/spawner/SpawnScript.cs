using System.Collections;
using System.Drawing;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] ennemis= new GameObject[2];
    public GameObject[] spawnPoints = new GameObject[4];
    public int nombreEnnemi;

    int randomPosition;  //pour determiner le lieu de spawn
    int randomEnnemi;   //pour determiner l'enemi � spawn
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

                randomEnnemi = Random.Range(0, ennemis.Length);  //un ennemi al�atoire
                randomPosition = Random.Range(0, 4);    //� une position al�atoire
                Instantiate(ennemis[randomEnnemi], spawnPoints[randomPosition].transform.position, Quaternion.identity);

                yield return new WaitForSeconds(spawnTime);
            }
             yield return new WaitForSeconds(waveTime); //yield permet de mettre en pause la corouine pendant "waveTime" secondes
            nombreEnnemi++;
        }
       
    }
}
