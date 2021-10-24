using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthController : MonoBehaviour
{
    [Header("UI")]
    public Text healthValue;

    [Header("Health")]
    public CharacterMoveController character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthValue.text = character.health.ToString();
    }
}
