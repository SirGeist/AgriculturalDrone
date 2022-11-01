using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantGrowth : MonoBehaviour
{

    // Variables
    private int currentProgression = 0;
    public int timeBetweenGrowths;
    public int maxGrowth;

    // Start is called before the first frame update
    void Start()
    {
        // Calls growth function, 2nd parameter is the first instance of how much time is passed; the last parameter is for subsequent times
        InvokeRepeating("Growth", timeBetweenGrowths, timeBetweenGrowths);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Functioning for growing the plant
    public void Growth(){

        // If the plant is not fully grown, continue growing
        if(currentProgression != maxGrowth){
            gameObject.transform.GetChild(currentProgression).gameObject.SetActive(true);
        }

        // If this is the second stage, disable the growth of the first stage
        if(currentProgression > 0 && currentProgression < maxGrowth){
            gameObject.transform.GetChild(currentProgression - 1).gameObject.SetActive(false);
        }

        // Adjust the progression if not fully grown
        if(currentProgression < maxGrowth){
            currentProgression++;
        }
    }
}