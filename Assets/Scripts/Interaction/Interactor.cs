using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interactor : MonoBehaviour
{
    [Header("Interaction Info")]
    public LayerMask interactableLayerMask;
    Interactable interactable;
    public Image interactImage;
    public Sprite defaultIcon;
    public Vector2 defaultIconSize;
    public Sprite defaultInteractIcon;
    public Vector2 defaultInteractIconSize;

    [Header("Interaction Text")]
    public KeyCode interactionKey;
    public TextMeshProUGUI interactionText;
    public string interactionTextString;

    void Start()
    {
        //interactionText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 3, interactableLayerMask))
        {
            interactionText.text = "Press " + interactionKey + " " + interactionTextString;

            if (hit.collider.GetComponent<Interactable>() != false)
            {
                if(interactable == null || interactable.ID != hit.collider.GetComponent<Interactable>().ID)
                {
                    interactable = hit.collider.GetComponent<Interactable>();

                }
                if(interactable.interactIcon != null)
                {
                    
                    interactImage.sprite = interactable.interactIcon;
                    if(interactable.iconSize == Vector2.zero)
                    {
                        interactImage.rectTransform.sizeDelta = defaultInteractIconSize;
                    }
                    else
                    {
                        interactImage.rectTransform.sizeDelta = interactable.iconSize;
                    }
                }

                else
                {
                    interactImage.sprite = defaultInteractIcon;
                    interactImage.rectTransform.sizeDelta = defaultInteractIconSize;
                    
                }
                if (Input.GetKeyDown(interactionKey))
                {
                    interactable.onInteract.Invoke();
                }

            }
        }
        else
        {
            interactionText.text = "";

            if (interactImage.sprite != defaultIcon)
            {
                interactImage.sprite = defaultIcon;
                interactImage.rectTransform.sizeDelta = defaultIconSize;
            }
        }
    }
}
