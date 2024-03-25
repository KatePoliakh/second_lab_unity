using System.Collections;
using System.Collections.Generic;
using _Source.Core;
using _Source.Model;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

namespace _Source.View {
    
    public class CardView : MonoBehaviour
    {
        [SerializeField]public Image cardImage;
        [SerializeField] private TextMeshProUGUI cardName;
        [SerializeField]public Color cardColor;
        [SerializeField] private GameObject cardBack;
        [SerializeField] private GameObject cardFront;
        
            private CardInstance _cardInstance;
            private bool _isFaceUp;
            
            public RectTransform RectTransform { get; private set; }
            private void Awake()
            {
                RectTransform = transform as RectTransform;
                if (RectTransform is null)
                    Debug.LogError("CardView must be placed on gameobject with a RectTransform.");
            }
            public void OnPointerDown(PointerEventData eventData)
            {
                Debug.Log($"Clicked on card: {_cardInstance.СardAsset.cardName}");
                PlayCard();
            }
            public void Flip(bool isFaceUp)
            {
                _isFaceUp = isFaceUp;
                cardFront.SetActive(_isFaceUp);
                cardBack.SetActive(!_isFaceUp);
            }
            private void PlayCard()
            {
                _cardInstance.MoveToLayout(CardGame.Instance.FieldLayoutId);
            }
    

            public void Init(CardInstance cardInstance)
        {
            _cardInstance = cardInstance;
            
            gameObject.name = _cardInstance.СardAsset.cardName;
            cardName.text = _cardInstance.СardAsset.cardName;
            
            var sprite = _cardInstance.СardAsset.cardImage;
            cardImage.sprite = sprite;
            cardColor = cardInstance.СardAsset.cardColor;
            
        }
            
    }
    
}
