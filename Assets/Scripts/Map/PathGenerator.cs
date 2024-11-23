using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathGenerator : MonoBehaviour
{
    [SerializeField] GameObject roadPrefab;
    [SerializeField] Vector3 spawnPos;
    [SerializeField] Vector3 offset;
    [SerializeField] int amount;


    void Start()
    {
        GeneratePath();
    }

    public void GeneratePath()
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject instance = Instantiate(roadPrefab, spawnPos, Quaternion.identity, transform);
            spawnPos += offset;
        }
    }
}
