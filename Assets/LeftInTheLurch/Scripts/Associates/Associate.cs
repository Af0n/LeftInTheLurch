using UnityEngine;

[CreateAssetMenu(fileName = "Associate", menuName = "My Assets/Associate", order = 0)]

public class Associate : ScriptableObject {
    [Tooltip("Name of Associate")]
    public string title;
    [Tooltip("Theme of Associate")]
    public ThemeID theme;
    [Space]
    public bool debug;

    // 0-100
    private int standing;

    private static int defaultStanding = 55;

    /* Standing - Standing : Affinity
        0 - 14 : 0; hatred
        15-39  : 1; dislike
        40-64  : 2; neutral
        65-89  : 3; like
        90-100 : 4; love
    */
    public float Affinity{
        get{
            return (standing + 10) / 25;
        }
    }
    
    // Message to be displayed when Logging
    public string LogMessage{
        get{
            if(debug){
                return $"{title} : {theme}\nAffinity of {Affinity}\nStanding of {standing}";
            }
            return $"{title}\nAffinity of {Affinity}";
        }
    }

    // changes standing by delta amount
    public void ChangeStanding(int delta){
        if(debug){
            Debug.Log($"adding {delta} to standing ({standing}): {standing + delta}");
        }

        standing += delta;

        ClampStanding();
    }

    // directly set standing
    public void SetStanding(int value){
        if(debug){
            Debug.Log($"setting standing to {value}");
        }

        standing = value;

        ClampStanding();
    }

    public int GetStanding(){
        return standing;
    }

    // clamps standing between 0-100
    private void ClampStanding(){
        standing = Mathf.Clamp(standing, 0, 100);
    }

    public void ResetStanding(){
        standing = defaultStanding;
    }

    public void Log(){
        Debug.Log(LogMessage);
    }

    public void ToggleDebug(){
        debug = !debug;
    }
}
