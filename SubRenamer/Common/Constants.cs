using System.Collections.Generic;
using System.Linq;

namespace SubRenamer.Common;

public static class Constants
{
    private static readonly HashSet<string> VideoExtensions = ["mkv", "mp4", "flv", "avi", "mov", "rmvb", "wmv", "mpg", "avs", "m4v", "ts","strm"];
    private static readonly HashSet<string> SubtitleExtensions = ["srt", "ass", "ssa", "sub", "idx", "txt", "vtt", "smi", "xml", "json"];

    public static HashSet<string> GetVideoExtensions()
    {
        var append = Config.Get().VideoExtAppend.Split(",");
        if (append.Length > 0) return [..VideoExtensions.Concat(append)];
        return VideoExtensions;
    }
    
    public static HashSet<string> GetSubtitleExtensions()
    {
        var append = Config.Get().SubtitleExtAppend.Split(",");
        if (append.Length > 0) return [..SubtitleExtensions.Concat(append)];
        return SubtitleExtensions;
    }
}
