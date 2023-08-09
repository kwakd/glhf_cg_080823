using UnityEngine;
using TMPro;

public class playerController : MonoBehaviour
{
    public TMP_Text speedText;

    [SerializeField]private playerData myPlayerData;

    private void start()
    {
        myPlayerData = new playerData();
    }

    private void Update()
    {
        speedText.text = myPlayerData.playerSpeed + " mile/hour";

        if(Input.GetKeyDown("z") || Input.GetKeyDown("x"))
        {
            generateSpeed();
            Debug.Log("button pressed");
        }
    }

    public void generateSpeed()
    {
        myPlayerData.playerSpeed += 1;
    }
}

// TODO LIST

// IN PROGRESS

// DONE

// LOOK AGAIN