using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 12;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;
    private string ballText = "SpawnRandomBall";

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(ballText, startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int randBallIIndex = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randBallIIndex], spawnPos, ballPrefabs[randBallIIndex].transform.rotation);
    }

}
