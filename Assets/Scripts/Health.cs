using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private PlayerCharacter player_;
    [SerializeField] private Sprite fullHeart_;
    [SerializeField] private Sprite emptyHeart_;
    
    [SerializeField] private int numOfHearts_ = 3;
    
    [SerializeField] private Image[] hearts_;

    // Update is called once per frame
    void Update()
    {
        if (player_.lives_ > numOfHearts_)
        {
            player_.lives_ = numOfHearts_;
        }
        
        for (int i = 0; i < hearts_.Length; i++)
        {
            if (i < player_.lives_)
            {
                hearts_[i].sprite = fullHeart_;
            }
            else
            {
                hearts_[i].sprite = emptyHeart_;
            }
            if (i < numOfHearts_)
            {
                hearts_[i].enabled = true;
            }
            else
            {
                hearts_[i].enabled = false;
            }
        }
    }
}
