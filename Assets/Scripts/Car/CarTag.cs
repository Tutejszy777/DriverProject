using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;

public class CarTag : MonoBehaviour
{
    public CanvasManager canvasManager;

    void Start()
    {
        canvasManager = GameObject.FindObjectOfType<CanvasManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // TODO: Insert collision code :)
        if (collision.gameObject.CompareTag("TeamWalls")) //have added this collision to walls
        {
            canvasManager.EndGame();
        }
        else if (collision.gameObject.CompareTag("TeamObstacles")) //have added this collision to walls
        {
            canvasManager.EndGame();
        }
        else if (collision.gameObject.CompareTag("TeamTrees"))
        {
            canvasManager.EndGame();
            //Utils.ForceCrash(ForcedCrashCategory.Abort);
        }
        else if (collision.gameObject.CompareTag("Untagged"))
        {
            Debug.LogError("Undefined Object hit - please set the Tag");
        }
    }

}
