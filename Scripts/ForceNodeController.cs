using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceNodeController : MonoBehaviour{


/*    public Transform Army;
    public Transform Corps;
    public Transform Division;
    public Transform RegimentBrigade;
    public Transform Battalion;
    public Transform Company;
    public Transform Platoon; */

    public Transform UnitDiagram;

    public GameObject Node;

    public int NodeNumber; //Number of Nodes beside
    public int DiagramTopNr; //Number of Unit Trees beside (on Same level) // need different one for each level??
    public int DiagramBottomNr; //Number of Unit Trees beside (on lowest expanded level)
    
    private float DiagramHeight; //Height of rectTransform
    private float DiagramWidth;  //Width of RectTransform
    
    //get public Rect Transforms!! like: https://stackoverflow.com/questions/66534298/unity-set-position-of-gui-element-relative-to-another-element-that-is-on-a-diffe
    //private Transform.position NodeBasePos;
    //private Transform.position NodeFollowPos;

    // Need something like Awake and then start so start is called after the first frame
    void OnValidate() {
    //UnitDiagram = GetComponent<RectTransform>();
        CreateNodes();
    }

    //Make the Nodes than Position them with Anchors - maybe fixed sises with scrollbar - https://www.youtube.com/watch?v=rAqyi85IAJ0

    private void CreateNodes() {
        Debug.Log(UnitDiagram.GetComponent<RectTransform>().rect.height); // get height

        //NewPosition NodeBasePos; //
        //NodeBasePos = (DiagramWidth/2f, DiagramHeight/4f,0f);

/*
        if (NodeNumber == DiagramTopNr) { //If Nodes beside equal to Units add a Node
            
            
            GameObject newobj = Instantiate(Node);
            newobj.transform.setParent(UnitDiagram);
            newobj.transform.localPosition = UnitDiagram; // whatever here 
        }
*/
    }

//Load Saved Nodes/Positions

//Create Nodes at empty positions to te right of Existing ones


/*     private float width; //How to get Width of rect Transform
     private RectTransform rt;
 
     void Start () {
 
         rt = GetComponent<RectTransform>();
         setWidth();
 
     }
 
     private void setWidth () {
         
         StartCoroutine(delayWidth());
 
     }
 
     private IEnumerator delayWidth () {
 
         yield return 0;
 
         width = rt.rect.width;
 
     }*/ //https://answers.unity.com/questions/919516/how-to-get-the-width-height-of-a-recttransform-con.html
}