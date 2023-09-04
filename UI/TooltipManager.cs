using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipManager : MonoBehaviour
{

        private static TooltipSystem current;

        public GameObject tooltip;


public void InstantiateTooltip(){
        Instantiate(tooltip);
        Debug.Log("Initiated Tooltip");
}

public void DestroyTooltip(){
        Destroy(tooltip);
}
}
