using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemDescription : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string Description;

    public GameObject DescriptionBox;
    public Text DecriptionText;

	void Start ()
	{
	    DescriptionBox = transform.parent.gameObject
            .GetComponent<InventoryBoxHelper>().ItemDescriptionBox;

        DecriptionText = transform.parent.gameObject
            .GetComponent<InventoryBoxHelper>().ItemDescriptionText;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        DescriptionBox.SetActive(true);
        DecriptionText.text = Description;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        DescriptionBox.SetActive(false);
    }
}
