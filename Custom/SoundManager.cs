using System.Media;

public static class SoundManager
{
    private static SoundPlayer _buttonClickPlayer;
    private static bool _isMuted = false;

    public static void Initialize()
    {
        _buttonClickPlayer = new SoundPlayer(kursach.Properties.Resources.buttonClick);
        _buttonClickPlayer.LoadAsync();
    }

    public static void PlayButtonClick()
    {
        if (_isMuted) return;

        _buttonClickPlayer.Play();
    }
    public static void ToggleMute()
    {
        _isMuted = !_isMuted;
    }

    public static void Dispose() // Освобождение ресурсов
    {
        _buttonClickPlayer?.Dispose();
    }
}