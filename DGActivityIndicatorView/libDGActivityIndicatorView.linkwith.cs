using ObjCRuntime;

[assembly: LinkWith("libDGActivityIndicatorView.a",
    LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.i386 | LinkTarget.x86_64,
    SmartLink = true,
    ForceLoad = false,
    LinkerFlags = "-ObjC -lz")]