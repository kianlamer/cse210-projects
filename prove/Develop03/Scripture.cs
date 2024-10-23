public class Scripture
{
    private string _reference;
    private List<string> _verses;

    public Scripture(string reference, List<string> verses)
    {
        _reference = reference;
        _verses = verses;
    }

    public string GetReference()
    {
        return _reference;
    }

    public List<string> GetVerses()
    {
        return _verses;
    }
}