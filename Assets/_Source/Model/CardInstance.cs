using System.Collections;
using System.Collections.Generic;
using _Source.ScriptableObjects;
using _Source.View;
using UnityEngine;

namespace _Source.Model {
    
    public class CardInstance
    {
        public CardAsset СardAsset { get; private set; }
        public CardView CardView { get; set; }
        public int LayoutId { get; set; }
        public int CardPosition { get; set; } 


        public CardInstance(CardAsset cardAsset)
        {
            this.СardAsset = cardAsset;
        }
        public void MoveToLayout(int layoutId)
        {
            LayoutId = layoutId;
            // Update CardPosition based on the layout
        }
    }

    
}
