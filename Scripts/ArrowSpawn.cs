using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Vincent McClintock
//Date: 10-18-2017

public class ArrowSpawn : MonoBehaviour {
    public GameObject obstacle;
    public Vector3 spawnValues;
    public int obstacleCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    private void Start()
    {
        StartCoroutine (SpawnArrows());
    }

    IEnumerator SpawnArrows()
    {
        yield return new WaitForSeconds(startWait);

        //while loop runs the for loop, constantly spawning waves of arrows
        while (true)
        {
        	//each for loop spawns a wave of a set number of arrows
            for (int i = 0; i < obstacleCount; i++)
            {
            	//Random variable is used in an if, elseif statement in order to have
            	//arrows spawn in one of three lanes; left, middle, and right.
                float xrand = Random.Range(0, 6);
                int xVal;
                if (xrand < 2)
                {
                    xVal = -1;
                }
                else if (xrand < 4)
                {
                    xVal = 0;
                }
                else
                {
                    xVal = 1;
                }


                //The spawn position is set as desired. The spawn rotation ensures 
                //the arrows spawn facing the player.
                Vector3 spawnPosition = new Vector3(xVal * spawnValues.x, spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                spawnRotation[0] = -1;
                Instantiate(obstacle, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
         	//wait after each for loop to allow time between waves of arrows. 
            yield return new WaitForSeconds(waveWait);
        }
    }
}
