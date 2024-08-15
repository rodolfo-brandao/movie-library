using System.Globalization;
using System.Text.RegularExpressions;

namespace MovieLibrary.Application.Utils.Structures;

/// <summary>
/// Custom struct to handle and validate e-mail addresses.
/// </summary>
internal struct EmailAddress(string address)
{
    private const string EmailDomainRegexPattern = "(@)(.+)$";
    private const string EmailAddressRegexPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
    private const ushort DefaultRegexMatchTimeoutInMilliseconds = 250;

    /// <summary>
    /// Checks whether the email address is valid or not.
    /// </summary>
    /// <returns>True if the e-mail address is valid. Otherwise, false.</returns>
    public bool IsValid()
    {
        if (string.IsNullOrWhiteSpace(address))
        {
            return false;
        }

        try
        {
            // Normalize the domain
            address = Regex.Replace(address, EmailDomainRegexPattern, DomainMapper,
                RegexOptions.None, TimeSpan.FromMilliseconds(200));
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
        catch (ArgumentException)
        {
            return false;
        }

        try
        {
            return Regex.IsMatch(address, EmailAddressRegexPattern,
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(DefaultRegexMatchTimeoutInMilliseconds));
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
    }

    /// <summary>
    /// Splits the e-mail address into username and domain.
    /// </summary>
    /// <returns>A (string, string) tuple containing its username and domain.</returns>
    /// <exception cref="ArgumentException">The given e-mail address is not a valid one.</exception>
    public (string Username, string Domain) Split()
    {
        if (!IsValid())
        {
            throw new ArgumentException("The given e-mail address is not a valid one.");
        }

        var parts = address.Split('@');
        return (parts[0], parts[1]);
    }

    /// <summary>
    /// Examines the domain part of the email and normalizes it.
    /// </summary>
    private static string DomainMapper(Match match)
    {
        var domainName = new IdnMapping().GetAscii(match.Groups[2].Value);
        return match.Groups[1].Value + domainName;
    }
}
