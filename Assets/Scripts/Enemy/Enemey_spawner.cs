using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemey_spawner : MonoBehaviour {
    [SerializeField]
    List<Transform> SpawnPoints = new List<Transform>();
    [SerializeField]
    List<GameObject> enemyPrefabs;

    float timer = 0.0f;
    int timerInt;
    int spawnLocationInt = -1;
    int randomEnemyIndex = -1;
    bool playerReady = false;
    bool spawnPause;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        gameStarter();
        if (playerReady == true) spawner();
        timer += Time.deltaTime;
        timerInt = Mathf.RoundToInt(timer);
    }

    //Funktion til at vise spiilleren er klar 
    void gameStarter()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerReady == false)
        {
            playerReady = true;
            timer = 0;
        }

    }

    void spawner()
    {   
        switch (timerInt)
        {
            case 0:
                if(spawnPause == false)
                {
                    spawnLocationInt = Random.Range(1, 5);
                    SpawnAt(spawnLocationInt, enemyPrefabs[0]);
                    StartCoroutine(spawnPauser());  
                }
                break;

            case 5:
                if (spawnPause == false)
                {
                    spawnLocationInt = Random.Range(1, 4);
                    StartCoroutine(spawnPauser());
                    SpawnAt(spawnLocationInt, enemyPrefabs[0]);
                }
                break;

            case 10:
                if (spawnPause == false)
                {
                    spawnLocationInt = Random.Range(1, 4);
                    StartCoroutine(spawnPauser());
                    SpawnAt(spawnLocationInt, enemyPrefabs[1]);
                }
                break;

            case 15:
                if (spawnPause == false)
                {
                    spawnLocationInt = Random.Range(1, 4);
                    StartCoroutine(spawnPauser());
                    SpawnAt(spawnLocationInt, enemyPrefabs[0]);
                    spawnLocationInt = Random.Range(1, 4);
                    SpawnAt(spawnLocationInt, enemyPrefabs[0]);
                    spawnLocationInt = Random.Range(1, 4);
                    SpawnAt(spawnLocationInt, enemyPrefabs[1]);
                    timer = 0;
                }
                break;

        }
        
    }


    //Ud fra en tilfældig int spawner den en "enemy" på en af 4 locations
    void SpawnAt(int spawnLocationInt, GameObject enemyObject)
    {
        //print(spawnLocationInt);
        switch (spawnLocationInt)
        {
            case 1:
                Instantiate(enemyObject, new Vector3(SpawnPoints[0].position.x, SpawnPoints[0].position.y, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(enemyObject, new Vector3(SpawnPoints[1].position.x, SpawnPoints[1].position.y, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(enemyObject, new Vector3(SpawnPoints[2].position.x, SpawnPoints[2].position.y, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(enemyObject, new Vector3(SpawnPoints[3].position.x, SpawnPoints[3].position.y, 0), Quaternion.identity);
                break;

        }
    }


    IEnumerator spawnPauser()
    {
        spawnPause = true;
        yield return new WaitForSeconds(1.0f);
        spawnPause = false;
    }

}
