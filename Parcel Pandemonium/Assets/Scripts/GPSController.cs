using UnityEngine;
using UnityEngine.UI;

public class GPSController : MonoBehaviour
{
    public Transform player; // Reference to the player transform
    public Transform goal; // Reference to the goal transform
    public RectTransform gpsScreen; // Reference to the GPS screen RectTransform
    public RectTransform playerDot; // Reference to the player dot RectTransform
    public RectTransform endGoal; // Reference to the goal dot RectTransform

    private Vector2 initialPlayerPosition;
    private Vector2 gpsScreenSize;

    void Start()
    {
        // Set initial player position
        initialPlayerPosition = new Vector2(player.position.x, player.position.z);

        // Calculate GPS screen size
        gpsScreenSize = gpsScreen.sizeDelta;

        // Position the goal dot at its initial position relative to the player
        Vector2 goalOffset = new Vector2(goal.position.x, goal.position.z) - initialPlayerPosition;
        endGoal.anchoredPosition = MapToGPS(goalOffset);
    }

    void Update()
    {
        // Calculate the offset of player relative to the initial position
        Vector2 playerOffset = new Vector2(player.position.x, player.position.z) - initialPlayerPosition;

        // Map the world position to the GPS screen coordinates and update the player's dot position
        playerDot.anchoredPosition = MapToGPS(playerOffset);

       
        // Ensure the end goal dot stays in its initial position relative to the player
        Vector2 goalOffset = new Vector2(goal.position.x, goal.position.z) - initialPlayerPosition;
        endGoal.anchoredPosition = MapToGPS(goalOffset);
    }

    Vector2 MapToGPS(Vector2 worldPosition)
    {
        // Determine the scale factor based on the GPS screen size and game world size
        float scaleFactorX = gpsScreenSize.x / 300f; 
        float scaleFactorY = gpsScreenSize.y / 300f; 

        // Scale and map the world position to GPS screen coordinates
        Vector2 gpsPosition = new Vector2(worldPosition.y * scaleFactorY, worldPosition.x * scaleFactorX);

        // Clamp the positions to ensure they stay within the GPS panel
        gpsPosition.y = Mathf.Clamp(gpsPosition.y, -gpsScreenSize.y / 2, gpsScreenSize.y / 2);
        gpsPosition.x = Mathf.Clamp(gpsPosition.x, -gpsScreenSize.x / 2, gpsScreenSize.x / 2);

        return gpsPosition;
    }
}

