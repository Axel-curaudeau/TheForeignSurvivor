using System.Collections;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] ennemis= new GameObject[2];
    public GameObject[] spawnPoints = new GameObject[4];
    public int nombreEnnemi;

    int randomPosition;  //pour determiner le lieu de spawn
    int randomEnnemi;   //pour determiner l'enemi à spawn
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
        yield return new WaitForSeconds(10);    //the player have 10 secondes to choose a weapon

        while (isGenerating)
        {
            for (int i = 0; i < nombreEnnemi; i++)
            {

                randomEnnemi = Random.Range(0, ennemis.Length);  //un ennemi aléatoire

                do
                {
                    randomPosition = Random.Range(0, spawnPoints.Length);    //à une position aléatoire
                } while (randomPosition == ClosestToPlayer());              //mais pas la plus proche du joueur!

                Instantiate(ennemis[randomEnnemi], spawnPoints[randomPosition].transform.position, Quaternion.identity);
                enemiesCounter.addEnemy();

                yield return new WaitForSeconds(spawnTime);
            }
             yield return new WaitForSeconds(waveTime); //yield permet de mettre en pause la corouine pendant "waveTime" secondes
            nombreEnnemi++;
        }
       
    }

    private int ClosestToPlayer()
    {
        int closest = 0;
        Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        float distanceMin = Vector3.Distance(playerPos, spawnPoints[closest].transform.position);
        float distance;

        for (int i= 0; i<spawnPoints.Length;i++)
        {
            distance = Vector3.Distance(playerPos, spawnPoints[i].transform.position);

            if (distance < distanceMin) { 
                closest = i;
                distanceMin = distance;
            }
        }

        return closest;
    }
}
