using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwap : MonoBehaviour
{
    public Transform character;
    public List<Transform> possibleCharacters;
    public int whichCharacter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (character == null&&possibleCharacters.Count>=1)
        {
            character=possibleCharacters[0];
        }
        Swap();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (whichCharacter == 0)
            {
                whichCharacter = possibleCharacters.Count - 1;
            }
            else
            {
                whichCharacter -= 1;
            }
            Swap();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (whichCharacter == possibleCharacters.Count - 1)
            {
                whichCharacter = 0;
            }
            else
            {
                whichCharacter += 1;
            }
            Swap();
        }
    }
    public void Swap()
    {
        character = possibleCharacters[whichCharacter];
        //character.GetComponent<SkateboardMovement>().enabled = true;
        //character.GetComponent<StarterAssets.ThirdPersonController>().enabled = true;
        //for (int i = 0; i < possibleCharacters.Count; i++)
        //{
        //    if (possibleCharacters[i]!=character)
        //    {

        //        possibleCharacters[i].GetComponent<SkateboardMovement>().enabled = false;
        //        possibleCharacters[i].GetComponent<StarterAssets.ThirdPersonController>().enabled = false;
        //    }
        //}
        if (whichCharacter == 1)
        {
            character.GetComponent<SkateboardMovement>().enabled = true;
            possibleCharacters[0].GetComponent<StarterAssets.ThirdPersonController>().enabled = false;
        }
        else
        {
            character.GetComponent<StarterAssets.ThirdPersonController>().enabled = true;
            possibleCharacters[1].GetComponent<SkateboardMovement>().enabled = false;
        }
    }
}
