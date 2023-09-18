using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Talking : MonoBehaviour
{
    public List<AlienDialogue> alienDialogues;

    public GameObject buttonPrefab;
    public GameObject dialogueHolder;

    public List<AlienDialogue> selectedOptions;

    public GameObject[] OptionButtons;

    public bool deleteOptions;
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            selectedOptions[i] = alienDialogues[Random.Range(0, alienDialogues.Count)];
        }
        foreach (AlienDialogue options in selectedOptions)
        {
            Initalize(options);
        }
    }

    private void Update()
    {
        if (deleteOptions == true)
        {
            foreach (GameObject options in OptionButtons)
            {
                Destroy(options);
            }
            deleteOptions = false;
        }

        OptionButtons = GameObject.FindGameObjectsWithTag("Button");
    }


    private void Initalize(AlienDialogue data)
    {
        GameObject optionButton = Instantiate(buttonPrefab, dialogueHolder.transform);
        optionButton.GetComponentInChildren<TMP_Text>().text = data.Option;
        var optionData = optionButton.GetComponent<AlienResponse>();
        optionData.dialogue = data;
    }

    public void BacktoOptions()
    {
        deleteOptions = true;

        for (int i = 0; i < 2; i++)
        {
            selectedOptions.Add(alienDialogues[Random.Range(0, alienDialogues.Count)]);
        }

        foreach (AlienDialogue options in selectedOptions)
        {
            Initalize(options);
        }

    }

}
