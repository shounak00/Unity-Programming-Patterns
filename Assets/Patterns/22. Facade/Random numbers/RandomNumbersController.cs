using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facade.RandomNumbers;

//Example of the Facade programming pattern (and possibly Adapter because they are very similar)
public class RandomNumbersController : MonoBehaviour
{
    private void Start()
    {
        RandomNumberFacade.InitSeed(0);

        Debug.Log("Float: 0 -> 1");

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(RandomNumberFacade.GetRandom01());
        }

        Debug.Log("Float: -1 -> 2");

        for (int i = 0; i < 10; i++)
        {
            Debug.Log(RandomNumberFacade.GetRandom(-1f, 2f));
        }

        Debug.Log("Integer: -10 -> 20");

        for (int i = 0; i < 10; i++)
        {
            Debug.Log(RandomNumberFacade.GetRandomInt(-10, 21));
        }
    }



}
