using UnityEngine;

public class Associate : MonoBehaviour
{
    public string title;

    public bool debug;

    [Range(0,100)]
    [Tooltip("DEBUGGING")]
    private int standing;

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
                return $"{title}\nAffinity of {Affinity}\nStanding of {standing}";
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

    public void Log(){
        Debug.Log(LogMessage);
    }

    public void ToggleDebug(){
        debug = !debug;
    }
}
