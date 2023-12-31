using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject rooster;
    public GameObject chicken;
    public GameObject chick;

    private GameObject chosenChick;

    private int prefab;
    private int side;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 0.5f)
        {
            prefab = Random.Range(0, 3);
            side = Random.Range(0, 4);

            switch (prefab)
            {
                case 0:
                    chosenChick = rooster;
                    break;
                case 1:
                    chosenChick = chicken;
                    break;
                case 2:
                    chosenChick = chick;
                    break;
            }

            switch (side)
            {
                case 0://Top
                    Instantiate(chosenChick, new Vector3(Random.Range(-19f, 19f), 0, 19f), Quaternion.Euler(0f, 180f, 0f));
                    break;
                case 1://Bottom
                    Instantiate(chosenChick, new Vector3(Random.Range(-19f, 19f), 0, -19f), Quaternion.Euler(0f, 0f, 0f));
                    break;
                case 2://Left
                    Instantiate(chosenChick, new Vector3(-19f, 0, Random.Range(-19f, 19f)), Quaternion.Euler(0f, 90f, 0f));
                    break;
                case 3://Right
                    Instantiate(chosenChick, new Vector3(19f, 0, Random.Range(-19f, 19f)), Quaternion.Euler(0f, 270f, 0f));
                    break;
            }
            timer = 0f;
        }
    }
}
