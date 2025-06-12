using System;

namespace Skills;

public class Comment
{
    public string Author { get; set; }
    public DateTime Date { get; set; }
    public string Content { get; set; }

    public Comment( string author, DateTime date, string content )
    {
        Author = author;
        Date = date;
        Content = content;
    }
    public override string ToString()
    {
        return $"{Author} ({Date.ToShortDateString()}): {Content}";
    }
    public override bool Equals( object? obj )
    {
        if ( obj is Comment other )
        {
            return Author == other.Author && Date == other.Date && Content == other.Content;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine( Author, Date, Content );
    }
    public static bool operator ==( Comment left, Comment right )
    {
        return Equals( left, right );
    }
    public static bool operator !=( Comment left, Comment right )
    {
        return !Equals( left, right );
    }
    public static implicit operator string( Comment comment )
    {
        return comment.ToString();
    }
    public static explicit operator Comment( string str )
    {
        var parts = str.Split( new[] { " (" }, StringSplitOptions.RemoveEmptyEntries );
        if ( parts.Length != 2 )
        {
            throw new FormatException( "Invalid comment format." );
        }
        var author = parts[0];
        var datePart = parts[1].TrimEnd( ')' );
        var content = parts[1].Substring( datePart.Length + 2 ).Trim();
        if ( !DateTime.TryParse( datePart, out var date ) )
        {
            throw new FormatException( "Invalid date format." );
        }
        return new Comment( author, date, content );
    }
    public static Comment Parse( string str )
    {
        return (Comment)str;
    }
    public static bool TryParse( string str, out Comment? comment )
    {
        try
        {
            comment = Parse( str );
            return true;
        }
        catch
        {
            comment = null;
            return false;
        }
    }
}
