public class Book
{
    public string Title {get;set;} = "";
    public int PageCount {get;set;}
    public string Status {get;set;}  = "";
    public DateTime PublishedDate {get;set;}
    public string[] Authors {get;set;} = Array.Empty<string>();
    public string[] Categories {get;set;} = Array.Empty<string>();
}