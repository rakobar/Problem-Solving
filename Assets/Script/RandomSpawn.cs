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
        

        if (Spawn == true)
        {
            //Instantiate(Box, Loc);
            Spawn = false;
            StartCoroutine(SpawnTrue());
            
            
        }
    }
    IEnumerator SpawnTrue()
    {
        yield return new WaitForSeconds(3f);
        int spawnBox = Random.Range(0, 1);
        Factory.FactoryMethod(spawnBox);
        Spawn = true;
    }
}
