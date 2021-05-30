using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemey_spawner : MonoBehaviour {




    /*[SerializeField]
    Transform spawnPoint_1;
    [SerializeField]
    Transform spawnPoint_2;
    [SerializeField]
    Transform spawnPoint_3;
    [SerializeField]
    Transform spawnPoint_4;*/
    [SerializeField]
    List<Transform> SpawnPoints = new List<Transform>();
    [SerializeField]
    GameObject enemeyPrefab;

    float timer = 0.0f;
    int timerInt;
    int spawnLocationInt = -1;
    bool playerReady;
    bool spawnPause;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        gameStarter();
        spawner();
        timer += Time.deltaTime;
        timerInt = Mathf.RoundToInt(timer);
        //print(timerInt);
    }

    //Funktion til at vise spiilleren er klar 
    void gameStarter()
    {
        if (Input.GetKeyDown(KeyCode.Return) && playerReady == false)
        {
            playerReady = true;
            timer = 0;
        }

    }

    void spawner()
    {
        if(playerReady == true)
        {
            switch (timerInt)
            {
                case 0:
                    if(spawnPause == false)
                    {
                        spawnLocationInt = Random.Range(1, 4);
                        StartCoroutine(spawnPauser());
                        SetSpawnLocation(spawnLocationInt);
                    }
                    break;

                case 5:
                    if (spawnPause == false)
                    {
                        spawnLocationInt = Random.Range(1, 4);
                        StartCoroutine(spawnPauser());
                        SetSpawnLocation(spawnLocationInt);
                    }
                    break;


                case 10:
                    if (spawnPause == false)
                    {
                        spawnLocationInt = Random.Range(1, 4);
                        StartCoroutine(spawnPauser());
                        SetSpawnLocation(spawnLocationInt);
                    }
                    break;


                case 15:
                    if (spawnPause == false)
                    {
                        spawnLocationInt = Random.Range(1, 4);
                        StartCoroutine(spawnPauser());
                        SetSpawnLocation(spawnLocationInt);

                    }
                    break;
            }
        }
    }


    //Ud fra en tilfældig int spawner den en "enemy" på en af 4 locations
    void SetSpawnLocation(int spawnLocationInt)
    {
        print(spawnLocationInt);
        switch (spawnLocationInt)
        {
            case 1:
                Instantiate(enemeyPrefab, new Vector3(SpawnPoints[0].position.x, SpawnPoints[0].position.y, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(enemeyPrefab, new Vector3(SpawnPoints[1].position.x, SpawnPoints[1].position.y, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(enemeyPrefab, new Vector3(SpawnPoints[2].position.x, SpawnPoints[2].position.y, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(enemeyPrefab, new Vector3(SpawnPoints[3].position.x, SpawnPoints[3].position.y, 0), Quaternion.identity);
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
