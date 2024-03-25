using System.Collections;
using System.Collections.Generic;
using _Source.ScriptableObjects;
using UnityEngine;

namespace _Source.Model {
    
    public class CardInstance
    {
        public CardAsset cardAsset;
        public int LayoutId;
        public int CardPosition;

        public CardInstance(CardAsset cardAsset)
        {
            this.cardAsset = cardAsset;
        }
    }

    
}
