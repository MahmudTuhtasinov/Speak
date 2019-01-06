using CommandLine;

namespace Speak.App
{
    public class StartOptions
    {
        [Option('l', "list", SetName = "AllInfo", HelpText = "Get list available voices.")]
        public bool VoicesList { get; set; }

        [Option('i', "info", SetName = "VoiceInfo", HelpText = "Get detailed information about voice.")]
        public string VoiceInfo { get; set; }

        [Option('t', "text", SetName = "Speak", HelpText = "Text to speak.")]
        public string Text { get; set; }

        [Option('v', "voice", SetName = "Speak", HelpText = "Select voice.")]
        public string Voice { get; set; }
    }
}