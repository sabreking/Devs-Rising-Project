using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// Loader changes states 
/// </summary>
public class Loader : UnitySingletonPersistent<Loader>
{
    public State _state;
   
    public enum State
    {
        Init,
        PresentingTheGame,
        ShiftingtoMainMenu,
    }
    
    public void Start ()
    {
        ChangeState (State.Init);
    }

    IEnumerator InitState ()
    {
        Debug.Log ("Init: Enter");

        ChangeState (State.PresentingTheGame);

        while ( _state == State.Init )
        {
            yield return 0;
        }
        Debug.Log ("Init: Exit");
        //NextState ();
    }

    IEnumerator PresentingTheGameState ()
    {
        Debug.Log ("PresentingTheGame: Enter");

        ShowGameLogo ();
        yield return new WaitForSeconds (3);
        ShowStudioLogo ();
        yield return new WaitForSeconds (3);

        ChangeState (State.ShiftingtoMainMenu);

        while ( _state == State.PresentingTheGame )
        {
            yield return 0;
        }
        Debug.Log ("PresentingTheGame: Exit");
        //NextState ();
    }

    IEnumerator ShiftingtoMainMenuState ()
    {
        Debug.Log ("ShiftingtoMainMenu: Enter");
        LoadMainMenu ();

        while ( _state == State.ShiftingtoMainMenu )
        {
            yield return 0;
        }
        Debug.Log ("ShiftingtoMainMenu: Exit");
    }


    void ChangeState ( State newState )
    {
        _state = newState;
        StartCoroutine (newState.ToString () + "State");
    }

    private void ShowGameLogo ()
    {
    }
    private void ShowStudioLogo ()
    {
    }
    private void LoadMainMenu ()
    {
        SceneManager.LoadScene (1);
    }
}