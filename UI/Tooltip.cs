using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



[ExecuteInEditMode()]
public class Tooltip : MonoBehaviour {
    
    public Text headerField;

    public Text contentField;

    public Text informationField;

    public LayoutElement layoutElement;

    public int characterWrapLimit;

    public RectTransform rectTransform;


    [SerializeField] private GameObject popupCanvasObject;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float padding;

    [SerializeField] private Canvas popupCanvas;


    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
        popupCanvas = popupCanvasObject.GetComponent<Canvas>();
    }

    public void SetText(string information ,string content, string header = "") {
        if (string.IsNullOrEmpty(header)) {
            headerField.gameObject.SetActive(false);
        }
        else {
            headerField.gameObject.SetActive(true);
            headerField.text = header;
        }
        contentField.text = content;
        informationField.text = information;
    }

    private void Update() {
        //Change Size of Tooltip box when inside Editor
        if (Application.isEditor) {
            int headerLength = headerField.text.Length;
            int contentLength = contentField.text.Length;
            int informationLength = informationField.text.Length;

            layoutElement.enabled = (headerLength > characterWrapLimit || contentLength > characterWrapLimit || informationLength > characterWrapLimit) ? true : false;
        }
/*
        //Move Tooltip to mouse
        Vector2 position = Input.mousePosition;
        
        //Position Tooltip inside Screen
        float pivotX = position.x / Screen.width;
        float pivotY = position.y / Screen.height;

        rectTransform.pivot = new Vector2(pivotX, pivotY);

        transform.position = position;
*/

        FollowCursor();
    }

    
private void FollowCursor() {
    if (!popupCanvasObject.activeSelf) { return; }
if (TooltipTrigger.freezeTooltip == false) {
    Vector3 newPos = Input.mousePosition + offset;
    newPos.z = 0f;
    //Lösung = Screen Breite - (x-Position + Breite des Rect Transform * Scale des Canvas / 2) - padding
    float rightEdgeToScreenEdgeDistance = Screen.width - (newPos.x + rectTransform.rect.width * popupCanvas.scaleFactor / 2) - padding;
    if (rightEdgeToScreenEdgeDistance < 0) {
            newPos.x += rightEdgeToScreenEdgeDistance;
    }

    float leftEdgeToScreenEdgeDistance = 0 - (newPos.x - rectTransform.rect.width * popupCanvas.scaleFactor / 2) - padding;
    if (leftEdgeToScreenEdgeDistance > 0) {
            newPos.x += leftEdgeToScreenEdgeDistance;
    }

    float topEdgeToScreenEdgeDistance = Screen.height - (newPos.y + rectTransform.rect.height * popupCanvas.scaleFactor) - padding;
    if (topEdgeToScreenEdgeDistance < 0) {
            newPos.y += topEdgeToScreenEdgeDistance;
    }

    float bootomEdgeToScreenEdgeDistance = 0 - (newPos.y - rectTransform.rect.height * popupCanvas.scaleFactor) - padding;
    if (bootomEdgeToScreenEdgeDistance > 0) {
            newPos.y += bootomEdgeToScreenEdgeDistance;
    }
      
    rectTransform.transform.position = newPos;
}
    }

    //popupCanvasObject
    //Vector3
    //popupObject = rectTransform
    //popupCanvas
    
}
