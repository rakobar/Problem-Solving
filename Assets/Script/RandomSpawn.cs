using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Transform[] Pos;
    public GameObject Box;

    public Transform Loc;
    public bool Spawn = true;

    // Update is called once per frame
    void Update()
    {
        Loc = Pos[Random.Range(0, Pos.Length)];
        

        if (Spawn == true)
        {

            /*for (int i = 0; i < 10; i++)
            {
                float spawnY = Random.Range
                    (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
                float spawnX = Random.Range
                    (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

                Vector2 spawnPosition = new Vector2(spawnX, spawnY);
                Instantiate(Box, spawnPosition, Quaternion.identity);
            }*/

            Instantiate(Box, Loc);
            Spawn = false;
            StartCoroutine(SpawnTrue());
            
            
        }
    }
    IEnumerator SpawnTrue()
    {
        yield return new WaitForSeconds(3f);
        Spawn = true;
    }
}
