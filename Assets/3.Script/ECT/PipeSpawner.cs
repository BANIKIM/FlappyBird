using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 1f;
    public int minY, maxY;
    [SerializeField] private GameObject plyaer;//�÷��̾� �� ��������
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;//�����ֱ�

        if (timer >= spawnRate)
        {
            
            int randomY = Random.Range(minY, maxY);
            Instantiate(pipePrefab, new Vector3(Player_Posx(plyaer.transform.position) + 10f, randomY, 0), Quaternion.identity);
            timer = 0f;
            
        }
    }
    //�÷��̾� x��ġ���� ��ȯ�ϴ� �޼ҵ�
    public float Player_Posx(Vector3 player)
    {
        return player.x;//�÷��̾� ������ x���� ��ȯ
    }
    //20231024 ���ȣ
}