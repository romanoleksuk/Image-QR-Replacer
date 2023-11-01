﻿using System.Text.RegularExpressions;

public static class RtfContentExtractor
{
    public static string ExtractImageFromRtfContent(string rtfContent)
    {
        var startIndex = rtfContent.IndexOf("{\\pict");
        var endIndex = rtfContent.IndexOf("}\\par");
        var count = endIndex - startIndex;
        return rtfContent.Substring(startIndex, count);
    }

    public static int GetPropertyFromRtfContent(string propertyRtf, string contentRtf)
    {
        var pattern = propertyRtf + @"(\d+)";
        Match match = Regex.Match(contentRtf, pattern);
        return int.Parse(match.Groups[1].Value);
    }
}