using System;

public class Word
{
    private string _text = "";
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayString()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
    
    public bool IsShowing()
    {
        return !_isHidden;
    }
}