using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class TooltipSystem : MonoBehaviour {
    
    private static TooltipSystem current;

    public static bool tooltipRaycast;

<<<<<<< HEAD
=======
    //TooltipPrefab
    public static GameObject prefabTooltip;

    public static GameObject TooltipCanvas;

>>>>>>> 495c2f7dbddfcaac2df47d2561cb144ccb0edb3d
    public Tooltip tooltip;

    public void Awake() {
        current = this;
    }
/*
    public void InstantiateTooltip(){
        Instantiate(tooltip);
        Debug.Log("Initiated Tooltip");
    }

    public void DestroyTooltip(){
        Destroy(tooltip);
    }
*/
    public static void Show(string information,string content, string header = "") {
        GameObject TooltipInstantiated = Instantiate(prefabTooltip,new Vector3(0, 0, 0), Quaternion.identity, TooltipCanvas.transform);
        tooltip = TooltipInstantiated.GetComponent<TooltipSystem>();
        current.tooltip.SetText(information, content, header);
    }

    public static void Hide() {
        DestroyImmediate(current.tooltip, true);
    }

    public void OnPointerEnter(PointerEventData eventData) {
        tooltipRaycast = true;
    }
    public void OnPointerExit(PointerEventData eventData) {
        tooltipRaycast = false;
    }

    public void OnPointerEnter(PointerEventData eventData) {
        tooltipRaycast = true;
    }
    public void OnPointerExit(PointerEventData eventData) {
        tooltipRaycast = false;
    }
}
