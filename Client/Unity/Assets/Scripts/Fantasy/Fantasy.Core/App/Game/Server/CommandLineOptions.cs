#if FANTASY_SERVER
using CommandLine;
using Fantasy.Core;

namespace Fantasy;

public class CommandLineOptions
{
    /// <summary>
    /// 进程Id
    /// </summary>
    [Option("AppId", Required = false, Default = (uint)0, HelpText = "Enter an AppId such as 1")]
    public uint AppId { get; set; }

    /// <summary>
    /// App类型
    /// Game - 游戏服务器App
    /// Export - 导表App
    /// </summary>
    [Option("AppType", Required = false, Default = null, HelpText = "Game,Export")]
    public string AppType { get; set; }

    /// <summary>
    /// 服务器运行模式
    /// Develop - 开发模式（所有Server都在一个进程中）
    /// Release - 发布模式（每个Server都在独立的进程中）
    /// </summary>
    [Option("Mode", Required = false, Default = "Release", HelpText = "Develop:所有Server都在一个进程中,Release:每个Server都在独立的进程中")]
    public string Mode { get; set; }

#if FANTASY_DEVELOP
    /// <summary>
    /// 导表的类型
    /// </summary>
    [Option("ExcelExportType", Required = false, Default = ExportType.None, HelpText = "Increment,All")]
    public ExportType ExportType { get; set; }
#endif
}
#endif
