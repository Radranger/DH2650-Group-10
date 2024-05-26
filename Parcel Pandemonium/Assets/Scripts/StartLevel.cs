using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartLevel : MonoBehaviour
{
    public GameObject DMToggleGameObject;
    public Toggle DriverToggle;

    public Canvas driverTestPhaseCanvas;
    public GameObject driverPlayPhaseCanvas;

    public GameObject driverPlayer;
    public GameObject driverStartPoint;

    private Toggle DMToggle;

    void Start()
    {
        DMToggle = DMToggleGameObject.GetComponent<Toggle>();
    }

    // When both toggles are on, start the level
    void Update()
    {
        if (DMToggle.isOn && DriverToggle.isOn)
        {
            Debug.Log("Both toggles are on");
            // Start the level
            ChangeCanvas();
            ChangePlayerPosition();
            DriverToggle.isOn = false;
            DMToggleGameObject.SetActive(false);
        }
    }

    private void ChangeCanvas()
    {
        driverTestPhaseCanvas.gameObject.SetActive(false);
        driverPlayPhaseCanvas.gameObject.SetActive(true);
    }

    private void ChangePlayerPosition()
    {
        driverPlayer.transform.position = driverStartPoint.transform.position;
        driverPlayer.transform.rotation = driverStartPoint.transform.rotation;
    }
}
