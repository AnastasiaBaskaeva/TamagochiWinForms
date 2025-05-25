using System.Media;
using System.IO;
using System.Windows.Forms;

public static class SoundManager
{
    private static SoundPlayer _backgroundPlayer;
    private static SoundPlayer _buttonClickPlayer;
    private static bool _isMuted = false;

    // Инициализация звуков
    public static void Initialize()
    {
        // Звук кнопки
        _buttonClickPlayer = new SoundPlayer(kursach.Properties.Resources.buttonClick);
        _buttonClickPlayer.LoadAsync();
    }

    // Воспроизведение звука кнопки
    public static void PlayButtonClick()
    {
        if (_isMuted) return;

        _buttonClickPlayer.Play();
    }
    public static void ToggleMute()
    {
        _isMuted = !_isMuted;
    }

    // Освобождение ресурсов
    public static void Dispose()
    {
        _buttonClickPlayer?.Dispose();
    }
}