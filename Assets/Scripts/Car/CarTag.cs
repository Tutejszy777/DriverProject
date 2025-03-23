using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;

public class CarTag : MonoBehaviour
{
    public CanvasManager canvasManager;
    public GameObject blowUpParticles;
    public HoverMotor hoverMotor;

    void Start()
    {
        canvasManager = GameObject.FindObjectOfType<CanvasManager>();
        blowUpParticles = GameObject.FindGameObjectWithTag("BlowUpParticles");
        blowUpParticles.SetActive(false);
        hoverMotor = GameObject.FindObjectOfType<HoverMotor>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // TODO: Insert collision code :)
        if (collision.gameObject.CompareTag("TeamWalls")) //have added this collision to walls
        {
            stopTheGame();
        }
        else if (collision.gameObject.CompareTag("TeamObstacles")) //have added this collision to walls
        {
            stopTheGame();

        }
        else if (collision.gameObject.CompareTag("TeamTrees"))
        {
            stopTheGame();
            //Utils.ForceCrash(ForcedCrashCategory.Abort);
        }
        else if (collision.gameObject.CompareTag("BlowUpParticles"))
        {
            stopTheGame();
        }
        else if (collision.gameObject.CompareTag("Untagged"))
        {
            Debug.LogError("Undefined Object hit - please set the Tag");
        }
    }

    private void stopTheGame()
    {
        blowUpParticles.SetActive(true);
        canvasManager.EndGame();
        hoverMotor.speed = 0;
        hoverMotor.accelerating = false;
    }

}
