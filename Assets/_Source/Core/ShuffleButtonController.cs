using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _Source.Core{
    
    
    public class ShuffleButtonController : MonoBehaviour
    {
        [SerializeField] private Button shuffleButton;
        [SerializeField] private int layoutIdToShuffle;

        private void Start()
        {
            shuffleButton.onClick.AddListener(HandleShuffleClick);
        }

        private void HandleShuffleClick()
        {
            CardGame.Instance.ShuffleLayout(layoutIdToShuffle);
        }
    }
    
}
