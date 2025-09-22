public class Scripture
{
    private string _reference;
    private List<string> _words;
    
// Constructor
    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').ToList();
    }

// Method to hide random words
    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int hidden = 0;

        // Ensure we don't try to hide more words than available
        while (hidden < count && _words.Any(w => !w.StartsWith("___")))
        {
            // Find a random index of a word that is not already hidden
            int index = rand.Next(_words.Count);
            if (!_words[index].StartsWith("___"))
            {
                _words[index] = "___";
                hidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference} {string.Join(" ", _words)}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.StartsWith("___"));
    }
}