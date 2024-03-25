using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Source.ScriptableObjects {
    
    [CreateAssetMenu(fileName = "New Card", menuName = "Card Game/Card Asset")]
    public class CardAsset : ScriptableObject
    {
        public string cardName;
        public Color cardColor;
        public Sprite cardImage;
    }
    
}
