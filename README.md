[![Build status](https://ci.appveyor.com/api/projects/status/0i7blyer1krh86u8?svg=true)](https://ci.appveyor.com/project/VitalyTartynov/speak) [![BCH compliance](https://bettercodehub.com/edge/badge/VitalyTartynov/Speak?branch=master)](https://bettercodehub.com/)

# Speak
MS Windows TTS console app

## Usage
```
  speak -t "Let's dive in." - Speak text with default system voice.
  speak -t "Let's dive in." -v "Microsoft David Desktop" - Speak text using MS David.
  speak -l - List available system voices.
  speak -i "Microsoft David Desktop" - Show detailed information about MS David voice.
```

## Help
```
  -l, --list     Get list available voices.  
  -i, --info     Get detailed information about voice.  
  -t, --text     Text to speak.  
  -v, --voice    Select voice.  
  -h, --volume   (Default: 100) Set voice volume. Values: [0; 100].  
  -r, --rate     (Default: 0) Set voice rate. Values: [-10; 10].  
  --help         Display this help screen.  
  --version      Display version information.
```
