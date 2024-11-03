using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private MonoBehaviour scriptZona;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persistente entre escenas
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ActivateControls(string nameZone)
    {
        switch (nameZone)
        {
            case "Lobby":
                // Activar controles del lobby
                break;
            case "Game1":
                scriptZona = gameObject.AddComponent<Game1Manager>();
                break;
            case "Game2":
                // Activar controles del minijuego 2
                break;
            case "Game3":
                // Activar controles del minijuego 3
                break;
            case "Game4":
                // Activar controles del minijuego 4
                break;
        }
    }

    public void DisableControls(string nameZone)
    {
        // Desactivar los controles de la zona actual si es necesario
    }
}
