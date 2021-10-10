using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Transform[] Pos;
    public GameObject Box;

    public Transform Loc;
    public bool Spawn = true;

    [SerializeField]
    MonoBehaviour factory;
    IFactory Factory { get { return factory as IFactory; } }

    // Update is called once per frame
    void Update()
    {
        Loc = Pos[Random.Range(0, Pos.Length)];
        //int spawnBox = Random.Range(0, 1);

        if (Spawn == true)
        {
            Instantiate(Box, Loc);
            Spawn = false;
            StartCoroutine(SpawnTrue());
            
            //Factory.FactoryMethod(spawnBox);
        }
    }
    IEnumerator SpawnTrue()
    {
        yield return new WaitForSeconds(1f);
        Spawn = true;
    }
}
