using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectScript : MonoBehaviour
{
    public EventSystem eSystem;
    public GameObject objectSelected;

    private bool isSelected;

    //use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxisRaw("Vertical") != 0 && isSelected == false)
        {
            eSystem.SetSelectedGameObject(objectSelected);
            isSelected = true;
        }
	}

    private void OnRelease()
    {
        isSelected = false;
    }
}
