public class _word
{
    private string _text;
    private bool _isHidden;

    // Constructor
    public _word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        // Return "___" if hidden, else return the actual word
        return _isHidden ? "___" : _text;
    }
}
