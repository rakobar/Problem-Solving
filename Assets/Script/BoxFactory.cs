using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFactory : MonoBehaviour,IFactory
{
    [SerializeField]
    public GameObject[] boxPrefabs;
    public GameObject FactoryMethod(int tag)
    {
        GameObject box = Instantiate(boxPrefabs[tag]);
        return box;
    }
}
