using StarterAssets;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ChangeVideo : MonoBehaviour
{
    public VideoPlayer VideoPlayer;
    public VideoClip[] videos;
    public GameObject MovieSelectionUI;
    public StarterAssetsInputs StarterAssets;
    public RawImage RawImage;
    private bool isMovieSelectionOn;
    private int videoIndex;

    void Start()
    {
        isMovieSelectionOn = false;
        StarterAssets.cursorLocked = true;
        StarterAssets.cursorInputForLook = true;
        RawImage.color = Color.black;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isMovieSelectionOn = !isMovieSelectionOn;
            MovieSelectionUI.SetActive(isMovieSelectionOn);
            StarterAssets.cursorLocked = !isMovieSelectionOn;
            StarterAssets.cursorInputForLook = !isMovieSelectionOn;
        }
    }

    public void SetVideoIndex(int index)
    {
        videoIndex = index;
    }

    public void PlayVideo()
    {
        RawImage.color = Color.white;
        VideoPlayer.clip = videos[videoIndex];
        VideoPlayer.Play();
        StarterAssets.cursorLocked = isMovieSelectionOn;
        StarterAssets.cursorInputForLook = isMovieSelectionOn;
        isMovieSelectionOn = !isMovieSelectionOn;
    }
}
