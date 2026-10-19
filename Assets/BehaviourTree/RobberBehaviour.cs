using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class RobberBehaviour : MonoBehaviour
{   
    BehaviourTree tree;


    // Start is called before the first frame update
    void Start()
    {
       tree = new BehaviourTree();
       Node steal = new Node("Steal Something");
       Node goToDiamond = new Node("Go To Diamond");
       Node GoToVan = new Node("Go To Van");

       steal.AddChild(goToDiamond);
       steal.AddChild(GoToVan);
       tree.AddChild(steal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
