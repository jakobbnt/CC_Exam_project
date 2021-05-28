using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemey_spawner : MonoBehaviour {




    [SerializeField]
    Transform spawnPoint_1;
    [SerializeField]
    Transform spawnPoint_2;
    [SerializeField]
    Transform spawnPoint_3;
    [SerializeField]
    Transform spawnPoint_4;
    [SerializeField]
    GameObject enemeyPrefab;

    float timer = 0.0f;
    int timerInt;
    int spawnarray = -1;
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
        print(timerInt);
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
                        spawnarray = Random.Range(1, 4);
                        StartCoroutine(spawnPauser());
                        switch (spawnarray)
                        {
                            case 1:
                                Instantiate(enemeyPrefab, spawnPoint_1.position, Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(enemeyPrefab, spawnPoint_2.position, Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(enemeyPrefab, spawnPoint_3.position, Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(enemeyPrefab, spawnPoint_4.position, Quaternion.identity);
                                break;

                        }
                        
                    }
                    break;

                case 5:
                    if (spawnPause == false)
                    {
                        spawnarray = Random.Range(1, 4);
                        StartCoroutine(spawnPauser());
                        switch (spawnarray)
                        {
                            case 1:
                                Instantiate(enemeyPrefab, spawnPoint_1.position, Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(enemeyPrefab, spawnPoint_2.position, Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(enemeyPrefab, spawnPoint_3.position, Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(enemeyPrefab, spawnPoint_4.position, Quaternion.identity);
                                break;

                        }

                    }
                    break;


                case 10:
                    if (spawnPause == false)
                    {
                        spawnarray = Random.Range(1, 4);
                        StartCoroutine(spawnPauser());
                        switch (spawnarray)
                        {
                            case 1:
                                Instantiate(enemeyPrefab, spawnPoint_1.position, Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(enemeyPrefab, spawnPoint_2.position, Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(enemeyPrefab, spawnPoint_3.position, Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(enemeyPrefab, spawnPoint_4.position, Quaternion.identity);
                                break;

                        }

                    }
                    break;


                case 15:
                    if (spawnPause == false)
                    {
                        spawnarray = Random.Range(1, 4);
                        StartCoroutine(spawnPauser());
                        switch (spawnarray)
                        {
                            case 1:
                                Instantiate(enemeyPrefab, spawnPoint_1.position, Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(enemeyPrefab, spawnPoint_2.position, Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(enemeyPrefab, spawnPoint_3.position, Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(enemeyPrefab, spawnPoint_4.position, Quaternion.identity);
                                break;

                        }

                    }
                    break;
            }
        }
    }



    IEnumerator spawnPauser()
    {
        spawnPause = true;
        yield return new WaitForSeconds(1.0f);
        spawnPause = false;
    }

}
