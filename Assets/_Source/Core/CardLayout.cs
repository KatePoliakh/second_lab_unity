using System;
using System.Collections;
using System.Collections.Generic;
using _Source.Model;
using UnityEngine;

namespace _Source.Core{
    
    public class CardLayout : MonoBehaviour
    {
        [field: SerializeField] public int LayoutId;
        [field: SerializeField] public Vector2 Offset;
        [SerializeField] private bool FaceUp;
        private RectTransform RectTransform;
         private void Awake()
        {
            RectTransform = transform as RectTransform;
            if (RectTransform is null)
                Debug.LogError("CardLayout must be placed on gameobject with a RectTransform.");
        }   

        void Update()
        {
            var cards = CardGame.Instance.GetCardsInLayout(LayoutId);
            for (int i = 0; i < cards.Count; i++)
            {
                var cardView = CardGame.Instance.GetCardView(cards[i]);
                cardView.RectTransform.SetParent(RectTransform, false);
                cardView.RectTransform.anchoredPosition = cards[i].CardPosition * Offset;
                cardView.transform.SetSiblingIndex(cards[i].CardPosition);
                cardView.Flip(FaceUp);
            }
        }
        
        
    }
    
}
