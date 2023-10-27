using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Reposition : MonoBehaviour
{
    //public Transform playerTransform;
    public GameObject[] PlayerPrefabs;
    public GameObject[] mapPrefabs;
    private float spawnX = 300.0f;
    private int lastPrefabIndex = 0;



    private void Update()
    {
        if (PlayerPrefabs[PlayerPrefs.GetInt("Character")].transform.position.x > spawnX)//�÷��̾ 300�� ���� 
        {
            SpawnMap();//�ʽ���
            spawnX += 300.0f;//������ ���� 300�� ������
        }
    }

    private void SpawnMap()
    {
        GameObject map = Instantiate(mapPrefabs[GetRandomPrefabIndex()]) as GameObject;
        map.transform.SetParent(transform);
        map.transform.position = new Vector3(spawnX, -5f, 0);  // Y���� Z���� 0���� ���� / ���� �ű�
    }

    private int GetRandomPrefabIndex()
    {
        if (mapPrefabs.Length <= 1)
            return 0;

        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, mapPrefabs.Length);
        }

        lastPrefabIndex = randomIndex;
        return randomIndex;
    }
}
