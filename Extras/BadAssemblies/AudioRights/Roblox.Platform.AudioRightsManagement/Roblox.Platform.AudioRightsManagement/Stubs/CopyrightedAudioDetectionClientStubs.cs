namespace Roblox.CopyrightedAudioDetection.Client
{
    // Minimal stubs to satisfy compile-time references
    public interface ICopyrightedAudioFileDetectionClient
    {
        (bool evaluatedIsProtected, string metadata) IsAudioFileCopyrightProtected(string url);
        AudioFileCopyrightProtectedResponse AudioFileCopyrightProtected(string url);
    }

    public struct AudioFileCopyrightProtectedResponse
    {
        public int FileStatus { get; set; }
        public int CopyrightStatus { get; set; }
        public string RawResponse { get; set; }
    }
}
