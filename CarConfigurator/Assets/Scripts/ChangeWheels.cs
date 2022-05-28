using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWheels : MonoBehaviour
{
    public GameObject [] spawnWheels;

    private GameObject instantiatedWheels;
    private int wheelsCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        instantiatedWheels = Instantiate(spawnWheels[0], transform.position, transform.rotation, transform);
        wheelsCounter++;
    }

    public void NextWheels()
    {
        Destroy(instantiatedWheels);

        if (wheelsCounter >= spawnWheels.Length - 1)
        {
            wheelsCounter = 0;
        }

        instantiatedWheels = Instantiate(spawnWheels[wheelsCounter], transform.position, transform.rotation, transform);
        wheelsCounter++;
    }
}
