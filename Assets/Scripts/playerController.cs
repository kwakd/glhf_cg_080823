using UnityEngine;
using TMPro;

public class playerController : MonoBehaviour
{
    public TMP_Text speedText;

    public double playerSpeed;

    public void Update()
    {
        speedText.text = playerSpeed + " mile/hour";

        if(Input.anyKeyDown)
        {
            generateSpeed();
            Debug.Log("button pressed");
        }
    }

    public void generateSpeed()
    {
        playerSpeed += 1;
    }
}

// TODO LIST

// IN PROGRESS

// DONE

// LOOK AGAIN