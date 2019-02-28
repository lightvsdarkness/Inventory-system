using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGame : MonoBehaviour {

    public List<ControllerUpdCom> ControllerUpdCom;
    public GameObject WorldContainer;

    void Awake () {
        foreach (var controllerUpdCom in ControllerUpdCom) {
            controllerUpdCom.Setup(WorldContainer);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
