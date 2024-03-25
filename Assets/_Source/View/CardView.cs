using System.Collections;
using System.Collections.Generic;
using _Source.Model;
using UnityEngine;
using UnityEngine.UI;

namespace _Source.View {
    
    public class CardView : MonoBehaviour
    {
        [SerializeField]public Image cardImage;
        [SerializeField]public Text cardName;
        [SerializeField]public Color cardColor;
        
            private CardInstance _cardInstance;
    

            public void Init(CardInstance cardInstance)
        {
            _cardInstance = cardInstance;
            cardName.text = cardInstance.cardAsset.cardName;
            cardImage.sprite = cardInstance.cardAsset.cardImage;
            cardColor = cardInstance.cardAsset.cardColor;
            
        }
    }
    
}
