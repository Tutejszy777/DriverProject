using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;

public class CarTag : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        // TODO: Insert collision code :)
        if (collision.gameObject.CompareTag("TeamWalls")) //have added this collision to walls
        {
            Debug.LogError("WHy u hit walls");
        }
        else if (collision.gameObject.CompareTag("TeamObstacles")) //have added this collision to walls
        {
            Debug.LogError("WHy u hit obstacles");
        }
        else if (collision.gameObject.CompareTag("TeamTrees"))
        {
            Debug.LogError("WHy u hit treees");
            //Utils.ForceCrash(ForcedCrashCategory.Abort);
        }
        else if (collision.gameObject.CompareTag("Untagged"))
        {
            Debug.LogError("Undefined Object hit - please set the Tag");
        }
    }

}
