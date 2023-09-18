using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CreateAssetMenu(fileName = "DialogueData", menuName = "ScriptableObjects/AlienDialogue", order = 1)]
public class AlienDialogue : ScriptableObject
{

        public float Frustration;

        public string Option;
    public string Response;
    public string Feedback;
}
