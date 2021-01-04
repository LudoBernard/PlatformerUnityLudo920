using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private PlayerCharacter player_;

    [SerializeField] private Text scoreText_;

    // Update is called once per frame
    void Update()
    {
        scoreText_.text = "Score: " + player_.gems_;
    }
}
